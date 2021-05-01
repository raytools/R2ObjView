using System;
using System.Windows.Forms;
using Ray2Mod.Components.Types;
using Ray2Mod.Game.Structs.MathStructs;

namespace R2ObjView.VarEdit
{
    public unsafe partial class VectorEdit : Form
    {
        private Pointer<Vector3> Vector { get; }
        private bool Edited = false;

        public VectorEdit(Pointer<Vector3> vector, string name = "Vector")
        {
            InitializeComponent();

            Text = $"Edit {name}...";
            Vector = vector;

            xNumBox.Minimum = yNumBox.Minimum = zNumBox.Minimum = decimal.MinValue;
            xNumBox.Maximum = yNumBox.Maximum = zNumBox.Maximum = decimal.MaxValue;

            xNumBox.Value = (decimal)Vector.StructPtr->x;
            yNumBox.Value = (decimal)Vector.StructPtr->y;
            zNumBox.Value = (decimal)Vector.StructPtr->z;
        }

        private void ValueChanged_UpdateEditedFlag(object sender, EventArgs e)
        {
            if (!Edited)
            {
                Edited = true;
                Text += " (modified)";
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Vector.StructPtr->x = (float)xNumBox.Value;
            Vector.StructPtr->y = (float)yNumBox.Value;
            Vector.StructPtr->z = (float)zNumBox.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
