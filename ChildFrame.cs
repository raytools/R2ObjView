using System.Windows.Forms;

namespace R2ObjView
{
    public class ChildFrame : Form
    {
        public virtual string ChildStatusText { get; protected set; }
        public virtual ToolStrip ChildToolStrip { get; }

        protected ChildFrame()
        {
            EnableLevelChanged();
            EnableRefresh();

            FormClosing += OnFormClosing;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            DisableRefresh();
            DisableLevelChanged();
        }

        protected void EnableRefresh() => MainFrame.Instance.RefreshData += RefreshData;
        protected void DisableRefresh() => MainFrame.Instance.RefreshData -= RefreshData;

        protected void EnableLevelChanged() => MainFrame.Instance.LevelChanged += OnLevelChanged;
        protected void DisableLevelChanged() => MainFrame.Instance.LevelChanged -= OnLevelChanged;

        protected virtual void RefreshData()
        {
        }

        protected virtual void OnLevelChanged(string levelName)
        {
        }
    }
}