using System;
using System.Windows.Forms;

namespace R2ObjView
{
    public interface IChildFrame
    {
        IMainFrame MainFrame { get; set; }
        string ChildStatusText { get; }
        ToolStrip ChildToolStrip { get; }
    }
}