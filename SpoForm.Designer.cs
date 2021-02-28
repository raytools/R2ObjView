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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cyTextBox = new System.Windows.Forms.TextBox();
            this.czTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.childrenTreeView = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.unloadedWarningLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // familyTextBox
            // 
            this.familyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.familyTextBox.Location = new System.Drawing.Point(116, 11);
            this.familyTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.familyTextBox.Name = "familyTextBox";
            this.familyTextBox.ReadOnly = true;
            this.familyTextBox.Size = new System.Drawing.Size(339, 20);
            this.familyTextBox.TabIndex = 0;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelTextBox.Location = new System.Drawing.Point(116, 37);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(339, 20);
            this.modelTextBox.TabIndex = 1;
            // 
            // instanceTextBox
            // 
            this.instanceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instanceTextBox.Location = new System.Drawing.Point(116, 63);
            this.instanceTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.instanceTextBox.Name = "instanceTextBox";
            this.instanceTextBox.ReadOnly = true;
            this.instanceTextBox.Size = new System.Drawing.Size(339, 20);
            this.instanceTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Family Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 66);
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
            this.groupBox1.Location = new System.Drawing.Point(11, 108);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Z:";
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
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(11, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(444, 2);
            this.label7.TabIndex = 13;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Controls.Add(this.tabPage3);
            this.mainTabControl.Controls.Add(this.tabPage4);
            this.mainTabControl.Location = new System.Drawing.Point(5, 5);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(474, 401);
            this.mainTabControl.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.familyTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.modelTextBox);
            this.tabPage1.Controls.Add(this.instanceTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8);
            this.tabPage1.Size = new System.Drawing.Size(466, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.childrenTreeView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(8);
            this.tabPage2.Size = new System.Drawing.Size(466, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Children";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // childrenTreeView
            // 
            this.childrenTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.childrenTreeView.Location = new System.Drawing.Point(11, 11);
            this.childrenTreeView.Name = "childrenTreeView";
            this.childrenTreeView.Size = new System.Drawing.Size(444, 353);
            this.childrenTreeView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(8);
            this.tabPage3.Size = new System.Drawing.Size(466, 375);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DsgVars";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(8);
            this.tabPage4.Size = new System.Drawing.Size(466, 375);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bepis";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // unloadedWarningLabel
            // 
            this.unloadedWarningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unloadedWarningLabel.AutoEllipsis = true;
            this.unloadedWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unloadedWarningLabel.Location = new System.Drawing.Point(9, 363);
            this.unloadedWarningLabel.Margin = new System.Windows.Forms.Padding(8);
            this.unloadedWarningLabel.Name = "unloadedWarningLabel";
            this.unloadedWarningLabel.Size = new System.Drawing.Size(466, 39);
            this.unloadedWarningLabel.TabIndex = 14;
            this.unloadedWarningLabel.Text = "The superobject pointer has changed or the object was unloaded.";
            this.unloadedWarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unloadedWarningLabel.Visible = false;
            // 
            // SpoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.unloadedWarningLabel);
            this.Controls.Add(this.mainTabControl);
            this.Name = "SpoForm";
            this.Text = "Bepis - Properties";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView childrenTreeView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label unloadedWarningLabel;
    }
}