
namespace R2ObjView.VarEdit
{
    partial class VectorEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zNumBox = new System.Windows.Forms.NumericUpDown();
            this.yNumBox = new System.Windows.Forms.NumericUpDown();
            this.xNumBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(69, 103);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(150, 103);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Z:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "X:";
            // 
            // zNumBox
            // 
            this.zNumBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zNumBox.DecimalPlaces = 3;
            this.zNumBox.Location = new System.Drawing.Point(58, 65);
            this.zNumBox.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.zNumBox.Name = "zNumBox";
            this.zNumBox.Size = new System.Drawing.Size(160, 20);
            this.zNumBox.TabIndex = 2;
            this.zNumBox.ValueChanged += new System.EventHandler(this.ValueChanged_UpdateEditedFlag);
            // 
            // yNumBox
            // 
            this.yNumBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yNumBox.DecimalPlaces = 3;
            this.yNumBox.Location = new System.Drawing.Point(58, 39);
            this.yNumBox.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.yNumBox.Name = "yNumBox";
            this.yNumBox.Size = new System.Drawing.Size(160, 20);
            this.yNumBox.TabIndex = 1;
            this.yNumBox.ValueChanged += new System.EventHandler(this.ValueChanged_UpdateEditedFlag);
            // 
            // xNumBox
            // 
            this.xNumBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xNumBox.DecimalPlaces = 3;
            this.xNumBox.Location = new System.Drawing.Point(58, 13);
            this.xNumBox.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.xNumBox.Name = "xNumBox";
            this.xNumBox.Size = new System.Drawing.Size(160, 20);
            this.xNumBox.TabIndex = 0;
            this.xNumBox.ValueChanged += new System.EventHandler(this.ValueChanged_UpdateEditedFlag);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 2);
            this.label1.TabIndex = 15;
            // 
            // VectorEdit
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(234, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xNumBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.yNumBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zNumBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VectorEdit";
            this.Padding = new System.Windows.Forms.Padding(6, 10, 6, 6);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VectorEdit";
            ((System.ComponentModel.ISupportInitialize)(this.zNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown xNumBox;
        private System.Windows.Forms.NumericUpDown yNumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown zNumBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}