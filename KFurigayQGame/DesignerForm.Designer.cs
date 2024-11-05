namespace KFurigayQGame
{
    partial class DesignerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignerForm));
            this.panelToolbox = new System.Windows.Forms.Panel();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.lblToolbox = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelToolbox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolbox
            // 
            this.panelToolbox.Controls.Add(this.btnGreenBox);
            this.panelToolbox.Controls.Add(this.btnRedBox);
            this.panelToolbox.Controls.Add(this.btnGreenDoor);
            this.panelToolbox.Controls.Add(this.btnRedDoor);
            this.panelToolbox.Controls.Add(this.btnWall);
            this.panelToolbox.Controls.Add(this.btnNone);
            this.panelToolbox.Location = new System.Drawing.Point(12, 134);
            this.panelToolbox.Name = "panelToolbox";
            this.panelToolbox.Size = new System.Drawing.Size(136, 358);
            this.panelToolbox.TabIndex = 0;
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenBox.ImageIndex = 5;
            this.btnGreenBox.ImageList = this.imageList;
            this.btnGreenBox.Location = new System.Drawing.Point(0, 295);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(136, 51);
            this.btnGreenBox.TabIndex = 5;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.btnGreenBox_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "imgNone.jpg");
            this.imageList.Images.SetKeyName(1, "imgWall.jpg");
            this.imageList.Images.SetKeyName(2, "imgRedDoor.jpg");
            this.imageList.Images.SetKeyName(3, "imgGreenDoor.jpg");
            this.imageList.Images.SetKeyName(4, "imgRedBox.jpg");
            this.imageList.Images.SetKeyName(5, "imgGreenBox.jpg");
            // 
            // btnRedBox
            // 
            this.btnRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedBox.ImageIndex = 4;
            this.btnRedBox.ImageList = this.imageList;
            this.btnRedBox.Location = new System.Drawing.Point(0, 238);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(136, 51);
            this.btnRedBox.TabIndex = 4;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.btnRedBox_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenDoor.ImageIndex = 3;
            this.btnGreenDoor.ImageList = this.imageList;
            this.btnGreenDoor.Location = new System.Drawing.Point(0, 181);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(136, 51);
            this.btnGreenDoor.TabIndex = 3;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.btnGreenDoor_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedDoor.ImageIndex = 2;
            this.btnRedDoor.ImageList = this.imageList;
            this.btnRedDoor.Location = new System.Drawing.Point(0, 124);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(136, 51);
            this.btnRedDoor.TabIndex = 2;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.btnRedDoor_Click);
            // 
            // btnWall
            // 
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.ImageIndex = 1;
            this.btnWall.ImageList = this.imageList;
            this.btnWall.Location = new System.Drawing.Point(0, 67);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(136, 51);
            this.btnWall.TabIndex = 1;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.btnWall_Click);
            // 
            // btnNone
            // 
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNone.ImageIndex = 0;
            this.btnNone.ImageList = this.imageList;
            this.btnNone.Location = new System.Drawing.Point(0, 10);
            this.btnNone.Name = "btnNone";
            this.btnNone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNone.Size = new System.Drawing.Size(136, 51);
            this.btnNone.TabIndex = 0;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // lblToolbox
            // 
            this.lblToolbox.AutoSize = true;
            this.lblToolbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblToolbox.Location = new System.Drawing.Point(33, 97);
            this.lblToolbox.Name = "lblToolbox";
            this.lblToolbox.Size = new System.Drawing.Size(80, 24);
            this.lblToolbox.TabIndex = 1;
            this.lblToolbox.Text = "Toolbox";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblRows.Location = new System.Drawing.Point(12, 41);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(46, 17);
            this.lblRows.TabIndex = 2;
            this.lblRows.Text = "Rows:";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(73, 41);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(107, 20);
            this.txtRows.TabIndex = 3;
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(286, 41);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(107, 20);
            this.txtColumns.TabIndex = 5;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblColumns.Location = new System.Drawing.Point(214, 41);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(66, 17);
            this.lblColumns.TabIndex = 4;
            this.lblColumns.Text = "Columns:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(431, 37);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(145, 27);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // gridPanel
            // 
            this.gridPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.gridPanel.Location = new System.Drawing.Point(217, 145);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(489, 491);
            this.gridPanel.TabIndex = 7;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(740, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // DesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(740, 648);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtColumns);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblToolbox);
            this.Controls.Add(this.panelToolbox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.gridPanel);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "DesignerForm";
            this.Text = "Design Form";
            this.panelToolbox.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelToolbox;
        private System.Windows.Forms.Label lblToolbox;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}