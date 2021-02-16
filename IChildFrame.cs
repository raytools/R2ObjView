using System;
using System.Windows.Forms;

namespace R2ObjView
{
    public interface IChildFrame
    {
        string ChildStatusText { get; }

        ToolStrip ChildToolStrip { get; }
    }
}