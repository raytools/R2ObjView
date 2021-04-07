namespace R2ObjView
{
    partial class WorldForm
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
            this.worldTree = new System.Windows.Forms.TreeView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.spoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fmiToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldTree
            // 
            this.worldTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.worldTree.Location = new System.Drawing.Point(0, 0);
            this.worldTree.Name = "worldTree";
            this.worldTree.Size = new System.Drawing.Size(584, 361);
            this.worldTree.TabIndex = 0;
            this.worldTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.worldTree_NodeMouseClick);
            this.worldTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.worldTree_NodeMouseDoubleClick);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spoToolStripButton,
            this.fmiToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(89, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.Visible = false;
            // 
            // spoToolStripButton
            // 
            this.spoToolStripButton.AccessibleDescription = "SuperObject Properties";
            this.spoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.spoToolStripButton.Image = global::R2ObjView.Resources.ImgSpo;
            this.spoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.spoToolStripButton.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.spoToolStripButton.Name = "spoToolStripButton";
            this.spoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.spoToolStripButton.Text = "Superobject Properties";
            this.spoToolStripButton.Click += new System.EventHandler(this.spoToolStripButton_Click);
            // 
            // fmiToolStripButton
            // 
            this.fmiToolStripButton.AccessibleDescription = "Group By Family";
            this.fmiToolStripButton.CheckOnClick = true;
            this.fmiToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fmiToolStripButton.Image = global::R2ObjView.Resources.ImgFamilyTree;
            this.fmiToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fmiToolStripButton.Name = "fmiToolStripButton";
            this.fmiToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.fmiToolStripButton.Text = "Group Objects";
            this.fmiToolStripButton.CheckedChanged += new System.EventHandler(this.fmiToolStripButton_CheckedChanged);
            // 
            // WorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.worldTree);
            this.Name = "WorldForm";
            this.Text = "World Structure";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView worldTree;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton spoToolStripButton;
        private System.Windows.Forms.ToolStripButton fmiToolStripButton;
    }
}