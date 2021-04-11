using System.Drawing;
using System.Windows.Forms;

namespace R2ObjView
{
    public static class IconManager
    {
        public static ImageList Icons;

        public static void InitIcons()
        {
            Icons = new ImageList
            {
                ImageSize = new Size(16, 16),
                ColorDepth = ColorDepth.Depth4Bit,
                TransparentColor = Color.White
            };

            Icons.Images.AddStrip(Resources.NodeIcons);
        }

    }

    public enum IconId : int
    {
        World,
        Spo,

        Family,
        Model,
        Instance,

        Empty,

        Pointer,
        List,
        Byte,
        Short,
        Int,
        Float,
        Boolean,
        Vector,
        Text,
    }
}