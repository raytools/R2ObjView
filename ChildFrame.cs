using System.Windows.Forms;

namespace R2ObjView
{
    public class ChildFrame : Form
    {
        public virtual string ChildStatusText { get; protected set; }
        public virtual ToolStrip ChildToolStrip { get; }

        protected ChildFrame()
        {
            EnableRefresh();
            FormClosing += OnFormClosing;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            DisableRefresh();
        }

        protected void EnableRefresh()
        {
            MainFrame.Instance.RefreshData += RefreshData;
        }

        protected void DisableRefresh()
        {
            MainFrame.Instance.RefreshData -= RefreshData;
        }

        protected virtual void RefreshData()
        {
        }
    }
}