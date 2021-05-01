using System.Windows.Forms;
using Ray2Mod.Game.Structs;

namespace R2ObjView.SPO
{
    public unsafe class DsgVarListItem
    {
        public int Id { get; }
        public DsgVarType Type { get; }
        public void* Value { get; }
        public void* InitValue { get; }
        public void* ModelValue { get; }

        public ListViewItem ListItem { get; set; }

        public DsgVarListItem(int id, DsgVarType type, void* value, void* initValue, void* modelValue)
        {
            Id = id;
            Type = type;
            Value = value;
            InitValue = initValue;
            ModelValue = modelValue;
            ListItem = null;
        }
    }
}