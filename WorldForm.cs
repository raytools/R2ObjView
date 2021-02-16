using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ray2Mod.Game;
using Ray2Mod.Game.Structs.SPO;

namespace R2ObjView
{
    public unsafe partial class WorldForm : Form, IChildFrame
    {
        private TreeNode activeWorld;
        private TreeNode inactiveWorld;
        private TreeNode fatherSector;

        public string ChildStatusText { get; private set; }
        public ToolStrip ChildToolStrip => toolStrip;

        private bool GroupSpo => fmiToolStripButton.Checked;

        public WorldForm()
        {
            InitializeComponent();
            Icon = Resources.IconWorld;
            worldTree.ImageList = IconManager.Icons;

            InitWorldTree();
        }

        private delegate Acp.XHIE_tdfnEnumSpoCallback GetCallbackDelegate(TreeNode parentNode);

        private void InitWorldTree()
        {
            worldTree.Nodes.Clear();

            activeWorld = NewNode("Active Dynamic World", IconId.World);
            inactiveWorld = NewNode("Inactive Dynamic World", IconId.World);
            fatherSector = NewNode("Father Sector", IconId.World);

            worldTree.Nodes.Add(activeWorld);
            worldTree.Nodes.Add(inactiveWorld);
            worldTree.Nodes.Add(fatherSector);

            GetCallbackDelegate getCallbackMethod = GroupSpo ? (GetCallbackDelegate)GetEnumGroupedSpoCallback : GetEnumNonGroupedSpoCallback;

            int nActive = Acp.XHIE_fn_lEnumSpoChildren(*(SuperObject**)Offsets.ActiveDynamicWorld, getCallbackMethod(activeWorld));
            int nInactive = Acp.XHIE_fn_lEnumSpoChildren(*(SuperObject**)Offsets.InactiveDynamicWorld, getCallbackMethod(inactiveWorld));
            int nSectors = Acp.XHIE_fn_lEnumSpoChildren(*(SuperObject**)Offsets.FatherSector, EnumSectorCallback);

            ChildStatusText = $"Active: {nActive} objects, Inactive: {nInactive} objects, Sectors: {nSectors} objects.";
        }

        private Acp.XHIE_tdfnEnumSpoCallback GetEnumGroupedSpoCallback(TreeNode parentNode)
        {
            return spo =>
            {
                string familyName = Acp.XHIE_fn_szGetObjectName(spo, Acp.XHIE_OI_TYPE.TOI_FAMILY);
                string modelName = Acp.XHIE_fn_szGetObjectName(spo, Acp.XHIE_OI_TYPE.TOI_MODEL);
                string spoName = Acp.XHIE_fn_szGetObjectName(spo, Acp.XHIE_OI_TYPE.TOI_INSTANCE);

                TreeNode familyNode = parentNode.Nodes[familyName];
                if (familyNode == null)
                {
                    familyNode = NewNode(familyName, IconId.Family);
                    parentNode.Nodes.Add(familyNode);
                }

                TreeNode modelNode = familyNode.Nodes[modelName];
                if (modelNode == null)
                {
                    modelNode = NewNode(modelName, IconId.Model);
                    familyNode.Nodes.Add(modelNode);
                }

                TreeNode node = NewNode(spoName, IconId.Instance, (IntPtr)spo);
                modelNode.Nodes.Add(node);
            };
        }

        private Acp.XHIE_tdfnEnumSpoCallback GetEnumNonGroupedSpoCallback(TreeNode parentNode)
        {
            return spo =>
            {
                string spoName = Acp.XHIE_fn_szGetObjectName(spo, Acp.XHIE_OI_TYPE.TOI_INSTANCE);
                TreeNode node = NewNode(spoName, IconId.Spo, (IntPtr)spo);
                parentNode.Nodes.Add(node);
            };
        }

        private void EnumSectorCallback(SuperObject* spo)
        {
            string spoName = $"Sector [{(int)spo:X6}]";
            TreeNode node = NewNode(spoName, IconId.Spo, (IntPtr)spo);
            fatherSector.Nodes.Add(node);
        }

        private TreeNode NewNode(string text, IconId iconId, object tag = null)
        {
            return new TreeNode(text, (int)iconId, (int)iconId) { Tag = tag, Name = text };
        }

        private void fmiToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            InitWorldTree();
        }
    }
}