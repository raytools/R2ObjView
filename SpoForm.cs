using System;
using System.Windows.Forms;
using Ray2Mod.Components.Types;
using Ray2Mod.Game.Structs.MathStructs;
using Ray2Mod.Game.Structs.SPO;

namespace R2ObjView
{
    public unsafe partial class SpoForm : ChildFrame
    {
        public override ToolStrip ChildToolStrip => toolStrip;

        private Pointer<SuperObject> SuperObject { get; }
        private string FamilyName { get; }
        private string ModelName { get; }
        private string InstanceName { get; }

        private Vector3 Position => SuperObject.StructPtr->matrixPtr->position;

        private ObjectTreeManager treeManager;
        private TreeNode parentNode;

        public SpoForm(Pointer<SuperObject> spo)
        {
            InitializeComponent();
            SuperObject = spo;

            string spoName = Acp.XHIE_fn_szGetObjectName(SuperObject, Acp.XHIE_OI_TYPE.TOI_INSTANCE);

            Text = (spoName ?? $"{SuperObject.StructPtr->type} [{(int)SuperObject:X8}]") + " - Properties";
            Icon = Resources.IconSpo;

            FamilyName = familyTextBox.Text =
                Acp.XHIE_fn_szGetObjectName(SuperObject, Acp.XHIE_OI_TYPE.TOI_FAMILY) ?? "(Unknown)";

            ModelName = modelTextBox.Text =
                Acp.XHIE_fn_szGetObjectName(SuperObject, Acp.XHIE_OI_TYPE.TOI_MODEL) ?? "(Unknown)";

            InstanceName = instanceTextBox.Text = spoName ?? "(Unknown)";

            typeTextBox.Text = $"{SuperObject.StructPtr->type} (0x{(int)SuperObject.StructPtr->type:X})";

            treeManager = new ObjectTreeManager();
            treeManager.InitIcons(childrenTreeView);

            parentNode = treeManager.NewTreeNode("Children", IconId.Spo);
            childrenTreeView.Nodes.Add(parentNode);

            MainFrame.Instance.LevelChanged += OnLevelChanged;
            UpdateSpoData();
        }

        private void OnLevelChanged(string levelName)
        {
            DisableRefresh();
            MainFrame.Instance.LevelChanged -= OnLevelChanged;

            Text += " (unloaded)";
            unloadedWarningLabel.Visible = true;

            // Disable all interactive controls
            childrenTreeView.Enabled = false;
        }

        protected override void RefreshData()
        {
            UpdateSpoData();
        }

        private void UpdateSpoData()
        {
            cxTextBox.Text = $"{Position.x:F3}";
            cyTextBox.Text = $"{Position.y:F3}";
            czTextBox.Text = $"{Position.z:F3}";

            treeManager.InvalidateAll();
            int nChildren = Acp.XHIE_fn_lEnumSpoChildren(SuperObject, treeManager.GetEnumNonGroupedSpoCallback(parentNode));
            treeManager.RemoveInvalidated();

            parentNode.Text = $"Children ({nChildren})";
            parentNode.Expand();
        }

        private void childrenTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                treeManager.ShowSpoDetails(e.Node);
            }
        }

        private void spoToolStripButton_Click(object sender, EventArgs e)
        {
            TreeNode node = childrenTreeView.SelectedNode;
            treeManager.ShowSpoDetails(node);
        }

        private void childrenTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            spoToolStripButton.Enabled = e.Node.Tag is Pointer<SuperObject>;
        }

        private void mainTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == childrenTabPage)
            {
                spoToolStripButton.Enabled = childrenTreeView.SelectedNode?.Tag is Pointer<SuperObject>;
            }
            else
            {
                spoToolStripButton.Enabled = false;
            }
        }
    }
}