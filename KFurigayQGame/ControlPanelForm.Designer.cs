namespace KFurigayQGame
{
    partial class ControlPanelForm
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
            this.btnCtrlDesign = new System.Windows.Forms.Button();
            this.btnCtrlPlay = new System.Windows.Forms.Button();
            this.btnCtrlExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCtrlDesign
            // 
            this.btnCtrlDesign.Location = new System.Drawing.Point(51, 41);
            this.btnCtrlDesign.Name = "btnCtrlDesign";
            this.btnCtrlDesign.Size = new System.Drawing.Size(121, 47);
            this.btnCtrlDesign.TabIndex = 0;
            this.btnCtrlDesign.Text = "Design";
            this.btnCtrlDesign.UseVisualStyleBackColor = true;
            this.btnCtrlDesign.Click += new System.EventHandler(this.btnCtrlDesign_Click);
            // 
            // btnCtrlPlay
            // 
            this.btnCtrlPlay.Location = new System.Drawing.Point(318, 41);
            this.btnCtrlPlay.Name = "btnCtrlPlay";
            this.btnCtrlPlay.Size = new System.Drawing.Size(121, 47);
            this.btnCtrlPlay.TabIndex = 1;
            this.btnCtrlPlay.Text = "Play";
            this.btnCtrlPlay.UseVisualStyleBackColor = true;
            this.btnCtrlPlay.Click += new System.EventHandler(this.btnCtrlPlay_Click);
            // 
            // btnCtrlExit
            // 
            this.btnCtrlExit.Location = new System.Drawing.Point(184, 134);
            this.btnCtrlExit.Name = "btnCtrlExit";
            this.btnCtrlExit.Size = new System.Drawing.Size(121, 47);
            this.btnCtrlExit.TabIndex = 2;
            this.btnCtrlExit.Text = "Exit";
            this.btnCtrlExit.UseVisualStyleBackColor = true;
            this.btnCtrlExit.Click += new System.EventHandler(this.btnCtrlExit_Click);
            // 
            // ControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(504, 212);
            this.Controls.Add(this.btnCtrlExit);
            this.Controls.Add(this.btnCtrlPlay);
            this.Controls.Add(this.btnCtrlDesign);
            this.Name = "ControlPanelForm";
            this.Text = "QGame Control Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCtrlDesign;
        private System.Windows.Forms.Button btnCtrlPlay;
        private System.Windows.Forms.Button btnCtrlExit;
    }
}

