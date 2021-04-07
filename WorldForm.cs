using System;
using System.Windows.Forms;
using Ray2Mod.Components.Types;
using Ray2Mod.Game;
using Ray2Mod.Game.Structs.SPO;

namespace R2ObjView
{
    public unsafe partial class WorldForm : ChildFrame
    {
        public override ToolStrip ChildToolStrip => toolStrip;

        private TreeNode activeWorld;
        private TreeNode inactiveWorld;
        private TreeNode fatherSector;

        private ObjectTreeManager treeManager;
        private bool GroupSpo => fmiToolStripButton.Checked;

        public WorldForm()
        {
            InitializeComponent();
            Icon = Resources.IconWorld;

            treeManager = new ObjectTreeManager();
            treeManager.InitIcons(worldTree);

            InitWorldTree();
        }

        protected override void RefreshData()
        {
            UpdateWorldTree();
        }

        private void InitWorldTree()
        {
            spoToolStripButton.Enabled = false;

            treeManager.Clear();
            worldTree.Nodes.Clear();

            activeWorld = treeManager.NewTreeNode("Active Dynamic World", IconId.World);
            inactiveWorld = treeManager.NewTreeNode("Inactive Dynamic World", IconId.World);
            fatherSector = treeManager.NewTreeNode("Father Sector", IconId.World);

            worldTree.Nodes.Add(activeWorld);
            worldTree.Nodes.Add(inactiveWorld);
            worldTree.Nodes.Add(fatherSector);

            UpdateWorldTree();
        }

        private void UpdateWorldTree()
        {
            treeManager.InvalidateAll();

            ObjectTreeManager.GetCallbackDelegate getCallbackMethod = treeManager.GetEnumCallback(GroupSpo);

            int nActive = Acp.XHIE_fn_lEnumSpoChildren(*(SuperObject**)Offsets.ActiveDynamicWorld,
                getCallbackMethod(activeWorld));
            int nInactive = Acp.XHIE_fn_lEnumSpoChildren(*(SuperObject**)Offsets.InactiveDynamicWorld,
                getCallbackMethod(inactiveWorld));
            int nSectors = Acp.XHIE_fn_lEnumSpoChildren(*(SuperObject**)Offsets.FatherSector, treeManager.GetEnumNonGroupedSpoCallback(fatherSector));

            treeManager.RemoveInvalidated(GroupSpo);

            ChildStatusText = $"Active: {nActive} objects, Inactive: {nInactive} objects, Sectors: {nSectors} objects.";
            MainFrame.Instance.SetStatus(this, ChildStatusText);
        }

        private void fmiToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            InitWorldTree();
        }

        private void worldTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                treeManager.ShowSpoDetails(e.Node);
            }
        }

        private void spoToolStripButton_Click(object sender, EventArgs e)
        {
            TreeNode node = worldTree.SelectedNode;
            treeManager.ShowSpoDetails(node);
        }

        private void worldTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            spoToolStripButton.Enabled = e.Node.Tag is Pointer<SuperObject>;
        }
    }
}