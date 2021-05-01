using System;
using System.Windows.Forms;
using R2ObjView.SPO;
using Ray2Mod.Components.Types;
using Ray2Mod.Game.Structs.AI;
using Ray2Mod.Game.Structs.Dynamics;
using Ray2Mod.Game.Structs.Dynamics.Blocks;
using Ray2Mod.Game.Structs.EngineObject;
using Ray2Mod.Game.Structs.MathStructs;
using Ray2Mod.Game.Structs.SPO;

namespace R2ObjView
{
    public unsafe partial class SpoForm : ChildFrame
    {
        public override ToolStrip ChildToolStrip => toolStrip;

        private Pointer<SuperObject> SuperObject;
        private string familyName;
        private string modelName;
        private string instanceName;

        private string spoNameUsable;

        private Vector3 Position => SuperObject.StructPtr->matrixPtr->position;

        private ObjectTreeManager treeManager;
        private TreeNode parentNode;

        private DsgVarListManager dsgvarManager;
        private DynamManager dynamManager;

        public SpoForm(Pointer<SuperObject> spo)
        {
            InitializeComponent();
            SuperObject = spo;

            string spoNameRaw = Acp.XHIE_fn_szGetObjectName(SuperObject, Acp.XHIE_OI_TYPE.TOI_INSTANCE);
            spoNameUsable = spoNameRaw ?? $"{SuperObject.StructPtr->type} [{(int)SuperObject:X8}]";

            Text = $"{spoNameUsable} - Properties";
            Icon = Resources.IconSpo;

            familyName = ctbFamily.Text =
                Acp.XHIE_fn_szGetObjectName(SuperObject, Acp.XHIE_OI_TYPE.TOI_FAMILY) ?? "(Unknown)";

            modelName = ctbModel.Text =
                Acp.XHIE_fn_szGetObjectName(SuperObject, Acp.XHIE_OI_TYPE.TOI_MODEL) ?? "(Unknown)";

            instanceName = ctbInstance.Text = spoNameRaw ?? "(Unknown)";

            ctbAddress.Text = $"0x{(int)SuperObject:X8}";
            ctbType.Text = $"{SuperObject.StructPtr->type} (0x{(int)SuperObject.StructPtr->type:X})";

            treeManager = new ObjectTreeManager();
            treeManager.InitIcons(ctvChildren);

            if (SuperObject.StructPtr->type == SuperObjectType.Perso)
            {
                dsgvarManager = new DsgVarListManager();
                dsgvarManager.InitIcons(clvDsgVars);
                Acp.XAI_fn_lEnumSpoDsgVars(SuperObject, dsgvarManager.GetInitDsgVarsCallback(clvDsgVars));

                if (SuperObject.StructPtr->PersoData->dynam != null)
                {
                    dynamManager = new DynamManager(SuperObject);
                    dynamManager.InitListView(clvDynamBase, DynamicsBlockBase.DynamicsType.Base);
                    dynamManager.InitListView(clvDynamAdvanced, DynamicsBlockBase.DynamicsType.Advanced);
                    dynamManager.InitListView(clvDynamComplex, DynamicsBlockBase.DynamicsType.Complex);

                    switch (dynamManager.DynamType)
                    {
                        case DynamicsBlockBase.DynamicsType.Base:
                            crbDynamTypeBase.Checked = true;
                            break;

                        case DynamicsBlockBase.DynamicsType.Advanced:
                            crbDynamTypeAdvanced.Checked = true;
                            break;

                        case DynamicsBlockBase.DynamicsType.Complex:
                            crbDynamTypeComplex.Checked = true;
                            break;
                    }
                }
                else
                {
                    ctpDynamics.Enabled = false;
                }
            }
            else
            {
                ctpDsgVars.Enabled = false;
                ctpDynamics.Enabled = false;
            }

            parentNode = treeManager.NewTreeNode("Children", IconId.List);
            ctvChildren.Nodes.Add(parentNode);

            MainFrame.Instance.LevelChanged += OnLevelChanged;
            UpdateSpoData();
        }

        protected override void OnLevelChanged(string levelName)
        {
            DisableRefresh();
            DisableLevelChanged();

            Text += " (unloaded)";
            unloadedWarningLabel.Visible = true;

            // Disable all interactive controls
            ctpChildren.Enabled = false;
            ctpDsgVars.Enabled = false;
            ctpDynamics.Enabled = false;
        }

        protected override void RefreshData()
        {
            UpdateSpoData();
            dsgvarManager?.UpdateAll();
            dynamManager?.UpdateAll();
        }

        private void UpdateSpoData()
        {
            ctbX.Text = $"{Position.x:F3}";
            ctbY.Text = $"{Position.y:F3}";
            ctbZ.Text = $"{Position.z:F3}";

            treeManager.InvalidateAll();
            int nChildren =
                Acp.XHIE_fn_lEnumSpoChildren(SuperObject, treeManager.GetEnumNonGroupedSpoCallback(parentNode));
            treeManager.RemoveInvalidated();

            parentNode.Text = $"Children ({nChildren})";
            parentNode.Expand();
        }

        private void ctvChildren_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                treeManager.ShowSpoDetails(e.Node);
            }
        }

        private void ctsbSpo_Click(object sender, EventArgs e)
        {
            TreeNode node = ctvChildren.SelectedNode;
            treeManager.ShowSpoDetails(node);
        }

        private void ctvChildren_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ctsbSpo.Enabled = e.Node.Tag is Pointer<SuperObject>;
        }

        private void ctcMain_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == ctpChildren)
            {
                ctsbSpo.Enabled = ctvChildren.SelectedNode?.Tag is Pointer<SuperObject>;
            }
            else
            {
                ctsbSpo.Enabled = false;
            }
        }

        private void clvDsgVars_ItemActivate(object sender, EventArgs e)
        {
            if (clvDsgVars.SelectedItems[0].Tag is DsgVarListItem item)
            {
                dsgvarManager.ShowDetails(item, spoNameUsable);
            }
        }
    }
}