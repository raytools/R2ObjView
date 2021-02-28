namespace R2ObjView
{
    partial class SpoForm
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
            this.familyTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.instanceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cxTextBox = new System.Windows.Forms.TextBox();
            this.cyTextBox = new System.Windows.Forms.TextBox();
            this.czTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // familyTextBox
            // 
            this.familyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.familyTextBox.Location = new System.Drawing.Point(127, 12);
            this.familyTextBox.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.familyTextBox.Name = "familyTextBox";
            this.familyTextBox.ReadOnly = true;
            this.familyTextBox.Size = new System.Drawing.Size(345, 20);
            this.familyTextBox.TabIndex = 0;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelTextBox.Location = new System.Drawing.Point(127, 38);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(345, 20);
            this.modelTextBox.TabIndex = 1;
            // 
            // instanceTextBox
            // 
            this.instanceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instanceTextBox.Location = new System.Drawing.Point(127, 64);
            this.instanceTextBox.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.instanceTextBox.Name = "instanceTextBox";
            this.instanceTextBox.ReadOnly = true;
            this.instanceTextBox.Size = new System.Drawing.Size(345, 20);
            this.instanceTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Family Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Instance Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cxTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cyTextBox);
            this.groupBox1.Controls.Add(this.czTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(200, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinates";
            // 
            // cxTextBox
            // 
            this.cxTextBox.Location = new System.Drawing.Point(38, 21);
            this.cxTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cxTextBox.Name = "cxTextBox";
            this.cxTextBox.ReadOnly = true;
            this.cxTextBox.Size = new System.Drawing.Size(154, 20);
            this.cxTextBox.TabIndex = 7;
            // 
            // cyTextBox
            // 
            this.cyTextBox.Location = new System.Drawing.Point(38, 47);
            this.cyTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cyTextBox.Name = "cyTextBox";
            this.cyTextBox.ReadOnly = true;
            this.cyTextBox.Size = new System.Drawing.Size(154, 20);
            this.cyTextBox.TabIndex = 8;
            // 
            // czTextBox
            // 
            this.czTextBox.Location = new System.Drawing.Point(38, 73);
            this.czTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.czTextBox.Name = "czTextBox";
            this.czTextBox.ReadOnly = true;
            this.czTextBox.Size = new System.Drawing.Size(154, 20);
            this.czTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Z:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(460, 2);
            this.label7.TabIndex = 13;
            // 
            // SpoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instanceTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.familyTextBox);
            this.Name = "SpoForm";
            this.Text = "Bepis - Properties";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox familyTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox instanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cxTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cyTextBox;
        private System.Windows.Forms.TextBox czTextBox;
        private System.Windows.Forms.Label label7;
    }
}