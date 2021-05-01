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
            this.ctbFamily = new System.Windows.Forms.TextBox();
            this.ctbModel = new System.Windows.Forms.TextBox();
            this.ctbInstance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctbX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctbY = new System.Windows.Forms.TextBox();
            this.ctbZ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ctcMain = new System.Windows.Forms.TabControl();
            this.ctpGeneral = new System.Windows.Forms.TabPage();
            this.unloadedWarningLabel = new System.Windows.Forms.Label();
            this.ctbType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctbAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ctpChildren = new System.Windows.Forms.TabPage();
            this.ctvChildren = new System.Windows.Forms.TreeView();
            this.ctpDsgVars = new System.Windows.Forms.TabPage();
            this.clvDsgVars = new System.Windows.Forms.ListView();
            this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idxColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.initValueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelInitColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctpDynamics = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crbDynamTypeComplex = new System.Windows.Forms.RadioButton();
            this.crbDynamTypeAdvanced = new System.Windows.Forms.RadioButton();
            this.crbDynamTypeBase = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDynamicsBase = new System.Windows.Forms.TabPage();
            this.clvDynamBase = new System.Windows.Forms.ListView();
            this.columnHeaderKeys = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValues = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageDynamicsAdvanced = new System.Windows.Forms.TabPage();
            this.clvDynamAdvanced = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageDynamicsComplex = new System.Windows.Forms.TabPage();
            this.clvDynamComplex = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.ctsbSpo = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.ctcMain.SuspendLayout();
            this.ctpGeneral.SuspendLayout();
            this.ctpChildren.SuspendLayout();
            this.ctpDsgVars.SuspendLayout();
            this.ctpDynamics.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageDynamicsBase.SuspendLayout();
            this.tabPageDynamicsAdvanced.SuspendLayout();
            this.tabPageDynamicsComplex.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctbFamily
            // 
            this.ctbFamily.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbFamily.Location = new System.Drawing.Point(113, 8);
            this.ctbFamily.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.ctbFamily.Name = "ctbFamily";
            this.ctbFamily.ReadOnly = true;
            this.ctbFamily.Size = new System.Drawing.Size(295, 20);
            this.ctbFamily.TabIndex = 0;
            // 
            // ctbModel
            // 
            this.ctbModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbModel.Location = new System.Drawing.Point(113, 34);
            this.ctbModel.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.ctbModel.Name = "ctbModel";
            this.ctbModel.ReadOnly = true;
            this.ctbModel.Size = new System.Drawing.Size(295, 20);
            this.ctbModel.TabIndex = 1;
            // 
            // ctbInstance
            // 
            this.ctbInstance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbInstance.Location = new System.Drawing.Point(113, 60);
            this.ctbInstance.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.ctbInstance.Name = "ctbInstance";
            this.ctbInstance.ReadOnly = true;
            this.ctbInstance.Size = new System.Drawing.Size(295, 20);
            this.ctbInstance.TabIndex = 2;
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
            this.groupBox1.Controls.Add(this.ctbX);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ctbY);
            this.groupBox1.Controls.Add(this.ctbZ);
            this.groupBox1.Location = new System.Drawing.Point(208, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(200, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinates";
            // 
            // ctbX
            // 
            this.ctbX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbX.Location = new System.Drawing.Point(39, 21);
            this.ctbX.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ctbX.Name = "ctbX";
            this.ctbX.ReadOnly = true;
            this.ctbX.Size = new System.Drawing.Size(149, 20);
            this.ctbX.TabIndex = 5;
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
            // ctbY
            // 
            this.ctbY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbY.Location = new System.Drawing.Point(39, 47);
            this.ctbY.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ctbY.Name = "ctbY";
            this.ctbY.ReadOnly = true;
            this.ctbY.Size = new System.Drawing.Size(149, 20);
            this.ctbY.TabIndex = 6;
            // 
            // ctbZ
            // 
            this.ctbZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbZ.Location = new System.Drawing.Point(39, 73);
            this.ctbZ.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ctbZ.Name = "ctbZ";
            this.ctbZ.ReadOnly = true;
            this.ctbZ.Size = new System.Drawing.Size(149, 20);
            this.ctbZ.TabIndex = 7;
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
            // ctcMain
            // 
            this.ctcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctcMain.Controls.Add(this.ctpGeneral);
            this.ctcMain.Controls.Add(this.ctpChildren);
            this.ctcMain.Controls.Add(this.ctpDsgVars);
            this.ctcMain.Controls.Add(this.ctpDynamics);
            this.ctcMain.Location = new System.Drawing.Point(5, 5);
            this.ctcMain.Margin = new System.Windows.Forms.Padding(0);
            this.ctcMain.Name = "ctcMain";
            this.ctcMain.SelectedIndex = 0;
            this.ctcMain.Size = new System.Drawing.Size(424, 401);
            this.ctcMain.TabIndex = 14;
            this.ctcMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.ctcMain_Selected);
            // 
            // ctpGeneral
            // 
            this.ctpGeneral.Controls.Add(this.unloadedWarningLabel);
            this.ctpGeneral.Controls.Add(this.ctbType);
            this.ctpGeneral.Controls.Add(this.label8);
            this.ctpGeneral.Controls.Add(this.ctbAddress);
            this.ctpGeneral.Controls.Add(this.label9);
            this.ctpGeneral.Controls.Add(this.groupBox1);
            this.ctpGeneral.Controls.Add(this.label7);
            this.ctpGeneral.Controls.Add(this.label1);
            this.ctpGeneral.Controls.Add(this.label3);
            this.ctpGeneral.Controls.Add(this.ctbFamily);
            this.ctpGeneral.Controls.Add(this.label2);
            this.ctpGeneral.Controls.Add(this.ctbModel);
            this.ctpGeneral.Controls.Add(this.ctbInstance);
            this.ctpGeneral.Location = new System.Drawing.Point(4, 22);
            this.ctpGeneral.Name = "ctpGeneral";
            this.ctpGeneral.Padding = new System.Windows.Forms.Padding(5);
            this.ctpGeneral.Size = new System.Drawing.Size(416, 375);
            this.ctpGeneral.TabIndex = 0;
            this.ctpGeneral.Text = "General";
            this.ctpGeneral.UseVisualStyleBackColor = true;
            // 
            // unloadedWarningLabel
            // 
            this.unloadedWarningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unloadedWarningLabel.AutoEllipsis = true;
            this.unloadedWarningLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unloadedWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unloadedWarningLabel.Location = new System.Drawing.Point(8, 318);
            this.unloadedWarningLabel.Margin = new System.Windows.Forms.Padding(8);
            this.unloadedWarningLabel.Name = "unloadedWarningLabel";
            this.unloadedWarningLabel.Size = new System.Drawing.Size(400, 44);
            this.unloadedWarningLabel.TabIndex = 14;
            this.unloadedWarningLabel.Text = "The superobject pointer has changed or the object was unloaded.";
            this.unloadedWarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unloadedWarningLabel.Visible = false;
            // 
            // ctbType
            // 
            this.ctbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbType.Location = new System.Drawing.Point(55, 108);
            this.ctbType.Margin = new System.Windows.Forms.Padding(10, 3, 5, 3);
            this.ctbType.Name = "ctbType";
            this.ctbType.ReadOnly = true;
            this.ctbType.Size = new System.Drawing.Size(142, 20);
            this.ctbType.TabIndex = 3;
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
            // ctbAddress
            // 
            this.ctbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbAddress.Location = new System.Drawing.Point(266, 108);
            this.ctbAddress.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ctbAddress.Name = "ctbAddress";
            this.ctbAddress.ReadOnly = true;
            this.ctbAddress.Size = new System.Drawing.Size(142, 20);
            this.ctbAddress.TabIndex = 4;
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
            // ctpChildren
            // 
            this.ctpChildren.Controls.Add(this.ctvChildren);
            this.ctpChildren.Location = new System.Drawing.Point(4, 22);
            this.ctpChildren.Name = "ctpChildren";
            this.ctpChildren.Padding = new System.Windows.Forms.Padding(5);
            this.ctpChildren.Size = new System.Drawing.Size(416, 375);
            this.ctpChildren.TabIndex = 1;
            this.ctpChildren.Text = "Children";
            this.ctpChildren.UseVisualStyleBackColor = true;
            // 
            // ctvChildren
            // 
            this.ctvChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctvChildren.Location = new System.Drawing.Point(8, 8);
            this.ctvChildren.Name = "ctvChildren";
            this.ctvChildren.ShowPlusMinus = false;
            this.ctvChildren.Size = new System.Drawing.Size(400, 359);
            this.ctvChildren.TabIndex = 0;
            this.ctvChildren.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ctvChildren_NodeMouseClick);
            this.ctvChildren.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ctvChildren_NodeMouseDoubleClick);
            // 
            // ctpDsgVars
            // 
            this.ctpDsgVars.Controls.Add(this.clvDsgVars);
            this.ctpDsgVars.Location = new System.Drawing.Point(4, 22);
            this.ctpDsgVars.Name = "ctpDsgVars";
            this.ctpDsgVars.Padding = new System.Windows.Forms.Padding(5);
            this.ctpDsgVars.Size = new System.Drawing.Size(416, 375);
            this.ctpDsgVars.TabIndex = 2;
            this.ctpDsgVars.Text = "DsgVars";
            this.ctpDsgVars.UseVisualStyleBackColor = true;
            // 
            // clvDsgVars
            // 
            this.clvDsgVars.AllowColumnReorder = true;
            this.clvDsgVars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clvDsgVars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.typeColumnHeader,
            this.idxColumnHeader,
            this.valueColumnHeader,
            this.initValueColumnHeader,
            this.modelInitColumnHeader});
            this.clvDsgVars.FullRowSelect = true;
            this.clvDsgVars.GridLines = true;
            this.clvDsgVars.HideSelection = false;
            this.clvDsgVars.Location = new System.Drawing.Point(8, 8);
            this.clvDsgVars.MultiSelect = false;
            this.clvDsgVars.Name = "clvDsgVars";
            this.clvDsgVars.Size = new System.Drawing.Size(400, 359);
            this.clvDsgVars.TabIndex = 0;
            this.clvDsgVars.UseCompatibleStateImageBehavior = false;
            this.clvDsgVars.View = System.Windows.Forms.View.Details;
            this.clvDsgVars.ItemActivate += new System.EventHandler(this.clvDsgVars_ItemActivate);
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
            // ctpDynamics
            // 
            this.ctpDynamics.Controls.Add(this.label11);
            this.ctpDynamics.Controls.Add(this.panel1);
            this.ctpDynamics.Controls.Add(this.tabControl1);
            this.ctpDynamics.Controls.Add(this.label10);
            this.ctpDynamics.Location = new System.Drawing.Point(4, 22);
            this.ctpDynamics.Name = "ctpDynamics";
            this.ctpDynamics.Padding = new System.Windows.Forms.Padding(5);
            this.ctpDynamics.Size = new System.Drawing.Size(416, 375);
            this.ctpDynamics.TabIndex = 3;
            this.ctpDynamics.Text = "Dynamics";
            this.ctpDynamics.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(8, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(400, 2);
            this.label11.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crbDynamTypeComplex);
            this.panel1.Controls.Add(this.crbDynamTypeAdvanced);
            this.panel1.Controls.Add(this.crbDynamTypeBase);
            this.panel1.Location = new System.Drawing.Point(111, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 26);
            this.panel1.TabIndex = 1;
            // 
            // crbDynamTypeComplex
            // 
            this.crbDynamTypeComplex.AutoSize = true;
            this.crbDynamTypeComplex.Location = new System.Drawing.Point(156, 3);
            this.crbDynamTypeComplex.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
            this.crbDynamTypeComplex.Name = "crbDynamTypeComplex";
            this.crbDynamTypeComplex.Size = new System.Drawing.Size(65, 17);
            this.crbDynamTypeComplex.TabIndex = 2;
            this.crbDynamTypeComplex.TabStop = true;
            this.crbDynamTypeComplex.Text = "Complex";
            this.crbDynamTypeComplex.UseVisualStyleBackColor = true;
            // 
            // crbDynamTypeAdvanced
            // 
            this.crbDynamTypeAdvanced.AutoSize = true;
            this.crbDynamTypeAdvanced.Location = new System.Drawing.Point(67, 3);
            this.crbDynamTypeAdvanced.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
            this.crbDynamTypeAdvanced.Name = "crbDynamTypeAdvanced";
            this.crbDynamTypeAdvanced.Size = new System.Drawing.Size(74, 17);
            this.crbDynamTypeAdvanced.TabIndex = 1;
            this.crbDynamTypeAdvanced.TabStop = true;
            this.crbDynamTypeAdvanced.Text = "Advanced";
            this.crbDynamTypeAdvanced.UseVisualStyleBackColor = true;
            // 
            // crbDynamTypeBase
            // 
            this.crbDynamTypeBase.AutoSize = true;
            this.crbDynamTypeBase.Location = new System.Drawing.Point(3, 3);
            this.crbDynamTypeBase.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
            this.crbDynamTypeBase.Name = "crbDynamTypeBase";
            this.crbDynamTypeBase.Size = new System.Drawing.Size(49, 17);
            this.crbDynamTypeBase.TabIndex = 0;
            this.crbDynamTypeBase.TabStop = true;
            this.crbDynamTypeBase.Text = "Base";
            this.crbDynamTypeBase.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageDynamicsBase);
            this.tabControl1.Controls.Add(this.tabPageDynamicsAdvanced);
            this.tabControl1.Controls.Add(this.tabPageDynamicsComplex);
            this.tabControl1.Location = new System.Drawing.Point(8, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 321);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageDynamicsBase
            // 
            this.tabPageDynamicsBase.Controls.Add(this.clvDynamBase);
            this.tabPageDynamicsBase.Location = new System.Drawing.Point(4, 22);
            this.tabPageDynamicsBase.Name = "tabPageDynamicsBase";
            this.tabPageDynamicsBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDynamicsBase.Size = new System.Drawing.Size(392, 295);
            this.tabPageDynamicsBase.TabIndex = 0;
            this.tabPageDynamicsBase.Text = "Base";
            this.tabPageDynamicsBase.UseVisualStyleBackColor = true;
            // 
            // clvDynamBase
            // 
            this.clvDynamBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clvDynamBase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderKeys,
            this.columnHeaderValues});
            this.clvDynamBase.GridLines = true;
            this.clvDynamBase.HideSelection = false;
            this.clvDynamBase.Location = new System.Drawing.Point(6, 6);
            this.clvDynamBase.Name = "clvDynamBase";
            this.clvDynamBase.Size = new System.Drawing.Size(380, 283);
            this.clvDynamBase.TabIndex = 0;
            this.clvDynamBase.UseCompatibleStateImageBehavior = false;
            this.clvDynamBase.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderKeys
            // 
            this.columnHeaderKeys.Text = "Property";
            this.columnHeaderKeys.Width = 106;
            // 
            // columnHeaderValues
            // 
            this.columnHeaderValues.Text = "Value";
            this.columnHeaderValues.Width = 242;
            // 
            // tabPageDynamicsAdvanced
            // 
            this.tabPageDynamicsAdvanced.Controls.Add(this.clvDynamAdvanced);
            this.tabPageDynamicsAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tabPageDynamicsAdvanced.Name = "tabPageDynamicsAdvanced";
            this.tabPageDynamicsAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDynamicsAdvanced.Size = new System.Drawing.Size(392, 295);
            this.tabPageDynamicsAdvanced.TabIndex = 1;
            this.tabPageDynamicsAdvanced.Text = "Advanced";
            this.tabPageDynamicsAdvanced.UseVisualStyleBackColor = true;
            // 
            // clvDynamAdvanced
            // 
            this.clvDynamAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clvDynamAdvanced.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.clvDynamAdvanced.GridLines = true;
            this.clvDynamAdvanced.HideSelection = false;
            this.clvDynamAdvanced.Location = new System.Drawing.Point(6, 6);
            this.clvDynamAdvanced.Name = "clvDynamAdvanced";
            this.clvDynamAdvanced.Size = new System.Drawing.Size(380, 283);
            this.clvDynamAdvanced.TabIndex = 1;
            this.clvDynamAdvanced.UseCompatibleStateImageBehavior = false;
            this.clvDynamAdvanced.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Property";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 242;
            // 
            // tabPageDynamicsComplex
            // 
            this.tabPageDynamicsComplex.Controls.Add(this.clvDynamComplex);
            this.tabPageDynamicsComplex.Location = new System.Drawing.Point(4, 22);
            this.tabPageDynamicsComplex.Name = "tabPageDynamicsComplex";
            this.tabPageDynamicsComplex.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDynamicsComplex.Size = new System.Drawing.Size(392, 295);
            this.tabPageDynamicsComplex.TabIndex = 2;
            this.tabPageDynamicsComplex.Text = "Complex";
            this.tabPageDynamicsComplex.UseVisualStyleBackColor = true;
            // 
            // clvDynamComplex
            // 
            this.clvDynamComplex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clvDynamComplex.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.clvDynamComplex.GridLines = true;
            this.clvDynamComplex.HideSelection = false;
            this.clvDynamComplex.Location = new System.Drawing.Point(6, 6);
            this.clvDynamComplex.Name = "clvDynamComplex";
            this.clvDynamComplex.Size = new System.Drawing.Size(380, 283);
            this.clvDynamComplex.TabIndex = 2;
            this.clvDynamComplex.UseCompatibleStateImageBehavior = false;
            this.clvDynamComplex.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Property";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 242;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Dynamics Type:";
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctsbSpo});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(35, 25);
            this.toolStrip.TabIndex = 15;
            this.toolStrip.Text = "toolStrip";
            this.toolStrip.Visible = false;
            // 
            // ctsbSpo
            // 
            this.ctsbSpo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ctsbSpo.Enabled = false;
            this.ctsbSpo.Image = global::R2ObjView.Resources.ImgSpo;
            this.ctsbSpo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctsbSpo.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.ctsbSpo.Name = "ctsbSpo";
            this.ctsbSpo.Size = new System.Drawing.Size(23, 22);
            this.ctsbSpo.Text = "Superobject Properties";
            this.ctsbSpo.Click += new System.EventHandler(this.ctsbSpo_Click);
            // 
            // SpoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.ctcMain);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "SpoForm";
            this.Text = "Bepis - Properties";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ctcMain.ResumeLayout(false);
            this.ctpGeneral.ResumeLayout(false);
            this.ctpGeneral.PerformLayout();
            this.ctpChildren.ResumeLayout(false);
            this.ctpDsgVars.ResumeLayout(false);
            this.ctpDynamics.ResumeLayout(false);
            this.ctpDynamics.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageDynamicsBase.ResumeLayout(false);
            this.tabPageDynamicsAdvanced.ResumeLayout(false);
            this.tabPageDynamicsComplex.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctbFamily;
        private System.Windows.Forms.TextBox ctbModel;
        private System.Windows.Forms.TextBox ctbInstance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ctbX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctbY;
        private System.Windows.Forms.TextBox ctbZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl ctcMain;
        private System.Windows.Forms.TabPage ctpGeneral;
        private System.Windows.Forms.TabPage ctpChildren;
        private System.Windows.Forms.TreeView ctvChildren;
        private System.Windows.Forms.TabPage ctpDsgVars;
        private System.Windows.Forms.TabPage ctpDynamics;
        private System.Windows.Forms.Label unloadedWarningLabel;
        private System.Windows.Forms.TextBox ctbType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton ctsbSpo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ctbAddress;
        private System.Windows.Forms.ListView clvDsgVars;
        private System.Windows.Forms.ColumnHeader idxColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.ColumnHeader valueColumnHeader;
        private System.Windows.Forms.ColumnHeader initValueColumnHeader;
        private System.Windows.Forms.ColumnHeader modelInitColumnHeader;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDynamicsBase;
        private System.Windows.Forms.TabPage tabPageDynamicsAdvanced;
        private System.Windows.Forms.TabPage tabPageDynamicsComplex;
        private System.Windows.Forms.ListView clvDynamBase;
        private System.Windows.Forms.ColumnHeader columnHeaderKeys;
        private System.Windows.Forms.ColumnHeader columnHeaderValues;
        private System.Windows.Forms.ListView clvDynamAdvanced;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView clvDynamComplex;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton crbDynamTypeBase;
        private System.Windows.Forms.RadioButton crbDynamTypeComplex;
        private System.Windows.Forms.RadioButton crbDynamTypeAdvanced;
        private System.Windows.Forms.Label label11;
    }
}