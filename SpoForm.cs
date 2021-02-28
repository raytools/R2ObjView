using System.Windows.Forms;
using Ray2Mod.Components.Types;
using Ray2Mod.Game.Structs.MathStructs;
using Ray2Mod.Game.Structs.SPO;

namespace R2ObjView
{
    public unsafe partial class SpoForm : Form, IChildFrame
    {
        public string ChildStatusText { get; }
        public ToolStrip ChildToolStrip { get; }

        private Pointer<SuperObject> SuperObject { get; }
        private string FamilyName { get; }
        private string ModelName { get; }
        private string InstanceName { get; }

        private Vector3 Position => SuperObject.StructPtr->matrixPtr->position;

        public SpoForm(Pointer<SuperObject> spo)
        {
            SuperObject = spo;
            InitializeComponent();

            FamilyName = familyTextBox.Text =
                Acp.XHIE_fn_szGetObjectName(SuperObject, Acp.XHIE_OI_TYPE.TOI_FAMILY) ??
                $"Unknown [{(int)SuperObject:X8}]";

            ModelName = modelTextBox.Text =
                Acp.XHIE_fn_szGetObjectName(SuperObject, Acp.XHIE_OI_TYPE.TOI_MODEL) ??
                $"Unknown [{(int)SuperObject:X8}]";

            InstanceName = instanceTextBox.Text =
                Acp.XHIE_fn_szGetObjectName(SuperObject, Acp.XHIE_OI_TYPE.TOI_INSTANCE) ??
                $"Unknown [{(int)SuperObject:X8}]";

            Text = $"{InstanceName} - Properties";
            Icon = Resources.IconSpo;

            cxTextBox.Text = $"{Position.x:F3}";
            cyTextBox.Text = $"{Position.y:F3}";
            czTextBox.Text = $"{Position.z:F3}";
        }
    }
}