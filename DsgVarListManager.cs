using System.Collections.Generic;
using System.Windows.Forms;
using Ray2Mod.Game.Structs;
using Ray2Mod.Game.Structs.MathStructs;

namespace R2ObjView
{
    public unsafe class DsgVarListManager
    {
        public List<DsgVarListItem> DsgVarList = new List<DsgVarListItem>();

        public DsgVarListManager()
        {
        }

        public Acp.XAI_tdfnEnumDsgVarCallback GetInitDsgVarsCallback(ListView list)
        {
            return (idx, type, value, initValue, modelInitValue) =>
            {
                DsgVarListItem dsgVar = new DsgVarListItem(idx, type, value, initValue, modelInitValue);
                DsgVarList.Add(dsgVar);

                ListViewItem listItem = GetViewItem(dsgVar);
                list.Items.Add(listItem);

                return true;
            };
        }

        public void InitIcons(ListView list)
        {
            list.SmallImageList = IconManager.Icons;
            list.LargeImageList = IconManager.Icons;
        }

        public void ShowDetails(DsgVarListItem item, string namePrefix)
        {
            DetailsGridForm form = new DetailsGridForm($"{namePrefix} - {item.Type} {item.Id} - Details");
            InitIcons(form.listView);
            form.AddColumn("Init Value", 80);
            form.AddColumn("Model Init", 80);

            // TODO: Testing just on vectors
            if (item.Type == DsgVarType.Vector)
            {
                Vector3* value = (Vector3*)item.Value;
                Vector3* initValue = (Vector3*)item.InitValue;
                Vector3* modelValue = (Vector3*)item.ModelValue;
                
                ListViewItem vectorX = new ListViewItem(
                    new[] { "X", $"{value->x}", $"{initValue->x}", $"{modelValue->x}" },
                    (int)IconId.Float
                );

                ListViewItem vectorY = new ListViewItem(
                    new[] { "Y", $"{value->y}", $"{initValue->y}", $"{modelValue->y}" },
                    (int)IconId.Float
                );

                ListViewItem vectorZ = new ListViewItem(
                    new[] { "Z", $"{value->z}", $"{initValue->z}", $"{modelValue->z}" },
                    (int)IconId.Float
                );

                form.AddItem(vectorX, vectorY, vectorZ);
            }

            MainFrame.Instance.ShowChildAtCursor(form);
        }

        private ListViewItem GetViewItem(DsgVarListItem item)
        {
            if (item.ListItem == null)
            {
                string valueText = GetDsgVarString(item.Type, item.Value);
                string initValueText = GetDsgVarString(item.Type, item.InitValue);
                string modelInitText = GetDsgVarString(item.Type, item.ModelValue);
                IconId icon = GetDsgVarIcon(item.Type);

                item.ListItem = new ListViewItem(
                    new[] { $"{item.Type}", $"{item.Id}", valueText, initValueText, modelInitText },
                    (int)icon
                );
                item.ListItem.Tag = item;
            }

            return item.ListItem;
        }

        private static string GetDsgVarString(DsgVarType type, void* value)
        {
            if (value == null)
            {
                return "---";
            }

            switch (type)
            {
                case DsgVarType.Byte:
                    return $"{*(sbyte*)value}";

                case DsgVarType.UByte:
                    return $"{*(byte*)value}";

                case DsgVarType.Short:
                    return $"{*(short*)value}";

                case DsgVarType.UShort:
                    return $"{*(ushort*)value}";

                case DsgVarType.Int:
                    return $"{*(int*)value}";

                case DsgVarType.UInt:
                    return $"{*(uint*)value}";

                case DsgVarType.Float:
                    return $"{*(float*)value}";

                case DsgVarType.Boolean:
                    return $"{*(bool*)value}";

                case DsgVarType.Vector:
                    Vector3* vector = (Vector3*)value;
                    return $"({vector->x}, {vector->y}, {vector->z})";

                case DsgVarType.Text:
                // TODO

                case DsgVarType.SuperObject:
                case DsgVarType.Perso:
                // TODO

                default:
                    return $"0x{*(int*)value:X}";
            }
        }

        private static IconId GetDsgVarIcon(DsgVarType type)
        {
            switch (type)
            {
                case DsgVarType.Byte:
                case DsgVarType.UByte:
                    return IconId.Byte;

                case DsgVarType.Short:
                case DsgVarType.UShort:
                    return IconId.Short;

                case DsgVarType.Int:
                case DsgVarType.UInt:
                    return IconId.Int;

                case DsgVarType.Float:
                    return IconId.Float;

                case DsgVarType.Boolean:
                    return IconId.Boolean;

                case DsgVarType.Vector:
                    return IconId.Vector;

                case DsgVarType.Text:
                    return IconId.Text;

                case DsgVarType.SuperObject:
                case DsgVarType.Perso:
                    return IconId.Pointer;

                default:
                    return IconId.Empty;
            }
        }
    }
}