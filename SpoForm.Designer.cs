﻿namespace R2ObjView
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
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ptrTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.childrenTabPage = new System.Windows.Forms.TabPage();
            this.childrenTreeView = new System.Windows.Forms.TreeView();
            this.dsgvarTabPage = new System.Windows.Forms.TabPage();
            this.dsgvarListView = new System.Windows.Forms.ListView();
            this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idxColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.initValueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelInitColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.unloadedWarningLabel = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.spoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.childrenTabPage.SuspendLayout();
            this.dsgvarTabPage.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // familyTextBox
            // 
            this.familyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.familyTextBox.Location = new System.Drawing.Point(113, 8);
            this.familyTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.familyTextBox.Name = "familyTextBox";
            this.familyTextBox.ReadOnly = true;
            this.familyTextBox.Size = new System.Drawing.Size(295, 20);
            this.familyTextBox.TabIndex = 0;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelTextBox.Location = new System.Drawing.Point(113, 34);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(295, 20);
            this.modelTextBox.TabIndex = 1;
            // 
            // instanceTextBox
            // 
            this.instanceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instanceTextBox.Location = new System.Drawing.Point(113, 60);
            this.instanceTextBox.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.instanceTextBox.Name = "instanceTextBox";
            this.instanceTextBox.ReadOnly = true;
            this.instanceTextBox.Size = new System.Drawing.Size(295, 20);
            this.instanceTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Family Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Instance Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cxTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cyTextBox);
            this.groupBox1.Controls.Add(this.czTextBox);
            this.groupBox1.Location = new System.Drawing.Point(208, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(200, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinates";
            // 
            // cxTextBox
            // 
            this.cxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cxTextBox.Location = new System.Drawing.Point(39, 21);
            this.cxTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cxTextBox.Name = "cxTextBox";
            this.cxTextBox.ReadOnly = true;
            this.cxTextBox.Size = new System.Drawing.Size(149, 20);
            this.cxTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Z:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y:";
            // 
            // cyTextBox
            // 
            this.cyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cyTextBox.Location = new System.Drawing.Point(39, 47);
            this.cyTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cyTextBox.Name = "cyTextBox";
            this.cyTextBox.ReadOnly = true;
            this.cyTextBox.Size = new System.Drawing.Size(149, 20);
            this.cyTextBox.TabIndex = 8;
            // 
            // czTextBox
            // 
            this.czTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.czTextBox.Location = new System.Drawing.Point(39, 73);
            this.czTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.czTextBox.Name = "czTextBox";
            this.czTextBox.ReadOnly = true;
            this.czTextBox.Size = new System.Drawing.Size(149, 20);
            this.czTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(8, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(400, 2);
            this.label7.TabIndex = 13;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.generalTabPage);
            this.mainTabControl.Controls.Add(this.childrenTabPage);
            this.mainTabControl.Controls.Add(this.dsgvarTabPage);
            this.mainTabControl.Controls.Add(this.tabPage4);
            this.mainTabControl.Location = new System.Drawing.Point(5, 5);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(424, 401);
            this.mainTabControl.TabIndex = 14;
            this.mainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.mainTabControl_Selected);
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.typeTextBox);
            this.generalTabPage.Controls.Add(this.label8);
            this.generalTabPage.Controls.Add(this.ptrTextBox);
            this.generalTabPage.Controls.Add(this.label9);
            this.generalTabPage.Controls.Add(this.groupBox1);
            this.generalTabPage.Controls.Add(this.label7);
            this.generalTabPage.Controls.Add(this.label1);
            this.generalTabPage.Controls.Add(this.label3);
            this.generalTabPage.Controls.Add(this.familyTextBox);
            this.generalTabPage.Controls.Add(this.label2);
            this.generalTabPage.Controls.Add(this.modelTextBox);
            this.generalTabPage.Controls.Add(this.instanceTextBox);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(5);
            this.generalTabPage.Size = new System.Drawing.Size(416, 375);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeTextBox.Location = new System.Drawing.Point(55, 108);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 5, 3);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(142, 20);
            this.typeTextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Type:";
            // 
            // ptrTextBox
            // 
            this.ptrTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptrTextBox.Location = new System.Drawing.Point(266, 108);
            this.ptrTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ptrTextBox.Name = "ptrTextBox";
            this.ptrTextBox.ReadOnly = true;
            this.ptrTextBox.Size = new System.Drawing.Size(142, 20);
            this.ptrTextBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Address:";
            // 
            // childrenTabPage
            // 
            this.childrenTabPage.Controls.Add(this.childrenTreeView);
            this.childrenTabPage.Location = new System.Drawing.Point(4, 22);
            this.childrenTabPage.Name = "childrenTabPage";
            this.childrenTabPage.Padding = new System.Windows.Forms.Padding(5);
            this.childrenTabPage.Size = new System.Drawing.Size(416, 375);
            this.childrenTabPage.TabIndex = 1;
            this.childrenTabPage.Text = "Children";
            this.childrenTabPage.UseVisualStyleBackColor = true;
            // 
            // childrenTreeView
            // 
            this.childrenTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.childrenTreeView.Location = new System.Drawing.Point(8, 8);
            this.childrenTreeView.Name = "childrenTreeView";
            this.childrenTreeView.ShowPlusMinus = false;
            this.childrenTreeView.Size = new System.Drawing.Size(400, 359);
            this.childrenTreeView.TabIndex = 0;
            this.childrenTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.childrenTreeView_NodeMouseClick);
            this.childrenTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.childrenTreeView_NodeMouseDoubleClick);
            // 
            // dsgvarTabPage
            // 
            this.dsgvarTabPage.Controls.Add(this.dsgvarListView);
            this.dsgvarTabPage.Location = new System.Drawing.Point(4, 22);
            this.dsgvarTabPage.Name = "dsgvarTabPage";
            this.dsgvarTabPage.Padding = new System.Windows.Forms.Padding(5);
            this.dsgvarTabPage.Size = new System.Drawing.Size(416, 375);
            this.dsgvarTabPage.TabIndex = 2;
            this.dsgvarTabPage.Text = "DsgVars";
            this.dsgvarTabPage.UseVisualStyleBackColor = true;
            // 
            // dsgvarListView
            // 
            this.dsgvarListView.AllowColumnReorder = true;
            this.dsgvarListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dsgvarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.typeColumnHeader,
            this.idxColumnHeader,
            this.valueColumnHeader,
            this.initValueColumnHeader,
            this.modelInitColumnHeader});
            this.dsgvarListView.FullRowSelect = true;
            this.dsgvarListView.GridLines = true;
            this.dsgvarListView.HideSelection = false;
            this.dsgvarListView.Location = new System.Drawing.Point(8, 8);
            this.dsgvarListView.MultiSelect = false;
            this.dsgvarListView.Name = "dsgvarListView";
            this.dsgvarListView.Size = new System.Drawing.Size(400, 359);
            this.dsgvarListView.TabIndex = 0;
            this.dsgvarListView.UseCompatibleStateImageBehavior = false;
            this.dsgvarListView.View = System.Windows.Forms.View.Details;
            this.dsgvarListView.ItemActivate += new System.EventHandler(this.dsgvarListView_ItemActivate);
            // 
            // typeColumnHeader
            // 
            this.typeColumnHeader.Text = "Type";
            this.typeColumnHeader.Width = 80;
            // 
            // idxColumnHeader
            // 
            this.idxColumnHeader.Text = "Index";
            this.idxColumnHeader.Width = 40;
            // 
            // valueColumnHeader
            // 
            this.valueColumnHeader.Text = "Value";
            this.valueColumnHeader.Width = 120;
            // 
            // initValueColumnHeader
            // 
            this.initValueColumnHeader.Text = "Init Value";
            this.initValueColumnHeader.Width = 100;
            // 
            // modelInitColumnHeader
            // 
            this.modelInitColumnHeader.Text = "Model Init";
            this.modelInitColumnHeader.Width = 100;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(8);
            this.tabPage4.Size = new System.Drawing.Size(416, 375);
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
            this.unloadedWarningLabel.Size = new System.Drawing.Size(416, 39);
            this.unloadedWarningLabel.TabIndex = 14;
            this.unloadedWarningLabel.Text = "The superobject pointer has changed or the object was unloaded.";
            this.unloadedWarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unloadedWarningLabel.Visible = false;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spoToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(35, 25);
            this.toolStrip.TabIndex = 15;
            this.toolStrip.Text = "toolStrip";
            this.toolStrip.Visible = false;
            // 
            // spoToolStripButton
            // 
            this.spoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.spoToolStripButton.Enabled = false;
            this.spoToolStripButton.Image = global::R2ObjView.Resources.ImgSpo;
            this.spoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.spoToolStripButton.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.spoToolStripButton.Name = "spoToolStripButton";
            this.spoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.spoToolStripButton.Text = "Superobject Properties";
            this.spoToolStripButton.Click += new System.EventHandler(this.spoToolStripButton_Click);
            // 
            // SpoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.unloadedWarningLabel);
            this.Controls.Add(this.mainTabControl);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "SpoForm";
            this.Text = "Bepis - Properties";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            this.childrenTabPage.ResumeLayout(false);
            this.dsgvarTabPage.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
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
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage childrenTabPage;
        private System.Windows.Forms.TreeView childrenTreeView;
        private System.Windows.Forms.TabPage dsgvarTabPage;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label unloadedWarningLabel;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton spoToolStripButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ptrTextBox;
        private System.Windows.Forms.ListView dsgvarListView;
        private System.Windows.Forms.ColumnHeader idxColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.ColumnHeader valueColumnHeader;
        private System.Windows.Forms.ColumnHeader initValueColumnHeader;
        private System.Windows.Forms.ColumnHeader modelInitColumnHeader;
    }
}