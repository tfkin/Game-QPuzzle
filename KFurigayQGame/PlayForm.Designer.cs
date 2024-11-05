namespace KFurigayQGame
{
    partial class PlayForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMoves = new System.Windows.Forms.Label();
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.txtBoxes = new System.Windows.Forms.TextBox();
            this.lblBoxes = new System.Windows.Forms.Label();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGameToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Location = new System.Drawing.Point(580, 47);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(94, 13);
            this.lblMoves.TabIndex = 1;
            this.lblMoves.Text = "Number of Moves:";
            // 
            // txtMoves
            // 
            this.txtMoves.Enabled = false;
            this.txtMoves.Location = new System.Drawing.Point(583, 63);
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.ReadOnly = true;
            this.txtMoves.Size = new System.Drawing.Size(176, 20);
            this.txtMoves.TabIndex = 2;
            // 
            // txtBoxes
            // 
            this.txtBoxes.Enabled = false;
            this.txtBoxes.Location = new System.Drawing.Point(583, 117);
            this.txtBoxes.Name = "txtBoxes";
            this.txtBoxes.ReadOnly = true;
            this.txtBoxes.Size = new System.Drawing.Size(176, 20);
            this.txtBoxes.TabIndex = 4;
            // 
            // lblBoxes
            // 
            this.lblBoxes.AutoSize = true;
            this.lblBoxes.Location = new System.Drawing.Point(580, 101);
            this.lblBoxes.Name = "lblBoxes";
            this.lblBoxes.Size = new System.Drawing.Size(144, 13);
            this.lblBoxes.TabIndex = 3;
            this.lblBoxes.Text = "Number of Remaining Boxes:";
            // 
            // gridPanel
            // 
            this.gridPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPanel.Location = new System.Drawing.Point(12, 37);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(539, 459);
            this.gridPanel.TabIndex = 5;
            // 
            // btnUp
            // 
            this.btnUp.Enabled = false;
            this.btnUp.Location = new System.Drawing.Point(629, 338);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(66, 61);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Location = new System.Drawing.Point(629, 405);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(66, 61);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Location = new System.Drawing.Point(557, 405);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(66, 61);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Enabled = false;
            this.btnRight.Location = new System.Drawing.Point(701, 405);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(66, 61);
            this.btnRight.TabIndex = 9;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtBoxes);
            this.Controls.Add(this.lblBoxes);
            this.Controls.Add(this.txtMoves);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PlayForm";
            this.Text = "Play Form";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.TextBox txtBoxes;
        private System.Windows.Forms.Label lblBoxes;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
    }
}