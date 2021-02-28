using System.Windows.Forms;

namespace R2ObjView
{
    public class ChildFrame : Form
    {
        public virtual string ChildStatusText { get; protected set; }
        public virtual ToolStrip ChildToolStrip { get; }

        protected ChildFrame()
        {
            MainFrame.Instance.RefreshData += RefreshData;
            FormClosing += OnFormClosing;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            UnsubscribeRefresh();
        }

        protected void UnsubscribeRefresh()
        {
            MainFrame.Instance.RefreshData -= RefreshData;
        }

        protected virtual void RefreshData()
        {
        }
    }
}