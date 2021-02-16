using System;
using System.Windows.Forms;

namespace R2ObjView
{
    public partial class MainFrame : Form
    {
        private WorldForm worldForm;

        private string _statusText;

        public string StatusText
        {
            get
            {
                if (ActiveMdiChild is IChildFrame child && !string.IsNullOrEmpty(child.ChildStatusText))
                    return child.ChildStatusText;

                return _statusText;
            }
            set
            {
                _statusText = value;
                statusLine.Text = _statusText;
            }
        }

        public MainFrame()
        {
            InitializeComponent();
            Icon = Resources.glidetect;
            StatusText = "Ready.";
        }

        private void ShowChild(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region View menu

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        #endregion

        #region Windows menu

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren) childForm.Close();
        }

        #endregion

        #region Tooltips

        private void ToolMouseEnter(object sender, EventArgs e)
        {
            // HACK: Using AccessibleDescription as tooltip
            switch (sender)
            {
                case ToolStripItem item:
                    statusLine.Text = item.AccessibleDescription;
                    break;

                case Control control:
                    statusLine.Text = control.AccessibleDescription;
                    break;
            }
        }

        private void ToolMouseLeave(object sender, EventArgs e)
        {
            statusLine.Text = StatusText;
        }

        private void toolStrip_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            e.Item.MouseEnter += ToolMouseEnter;
            e.Item.MouseLeave += ToolMouseLeave;
        }

        private void toolStrip_ItemRemoved(object sender, ToolStripItemEventArgs e)
        {
            e.Item.MouseEnter -= ToolMouseEnter;
            e.Item.MouseLeave -= ToolMouseLeave;
        }

        #endregion

        private void WorldItemClick(object sender, EventArgs e)
        {
            if (worldForm == null)
            {
                worldForm = new WorldForm();
                worldForm.FormClosed += WorldFormClosed;

                ShowChild(worldForm);
            }
            else
            {
                worldForm.Show();

                if (worldForm.WindowState == FormWindowState.Minimized)
                {
                    worldForm.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void WorldFormClosed(object sender, FormClosedEventArgs e)
        {
            worldForm = null;
        }

        private void MainFrame_MdiChildActivate(object sender, EventArgs e)
        {
            statusLine.Text = StatusText;
            ToolStripManager.RevertMerge(toolStrip);

            if (ActiveMdiChild is IChildFrame child)
            {
                ToolStripManager.Merge(child.ChildToolStrip, toolStrip);
            }
        }
    }
}