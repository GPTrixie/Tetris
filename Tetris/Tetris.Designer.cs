namespace Tetris
{
    partial class Tetris
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
            this.timerPrincipale = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tetrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvirLaideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerLevel = new System.Windows.Forms.Timer(this.components);
            this.timerBonus4 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerPrincipale
            // 
            this.timerPrincipale.Interval = 1000;
            this.timerPrincipale.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tetrisToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tetrisToolStripMenuItem
            // 
            this.tetrisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.tetrisToolStripMenuItem.Name = "tetrisToolStripMenuItem";
            this.tetrisToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.tetrisToolStripMenuItem.Text = "Tetris";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItem1.Text = "Rejouer";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musiqueToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // musiqueToolStripMenuItem
            // 
            this.musiqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeAToolStripMenuItem,
            this.typeBToolStripMenuItem,
            this.typeCToolStripMenuItem,
            this.oFFToolStripMenuItem});
            this.musiqueToolStripMenuItem.Name = "musiqueToolStripMenuItem";
            this.musiqueToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.musiqueToolStripMenuItem.Text = "Musique";
            // 
            // typeAToolStripMenuItem
            // 
            this.typeAToolStripMenuItem.Name = "typeAToolStripMenuItem";
            this.typeAToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.typeAToolStripMenuItem.Text = "Type A";
            this.typeAToolStripMenuItem.Click += new System.EventHandler(this.typeAToolStripMenuItem_Click);
            // 
            // typeBToolStripMenuItem
            // 
            this.typeBToolStripMenuItem.Name = "typeBToolStripMenuItem";
            this.typeBToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.typeBToolStripMenuItem.Text = "Type B";
            this.typeBToolStripMenuItem.Click += new System.EventHandler(this.typeBToolStripMenuItem_Click);
            // 
            // typeCToolStripMenuItem
            // 
            this.typeCToolStripMenuItem.Name = "typeCToolStripMenuItem";
            this.typeCToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.typeCToolStripMenuItem.Text = "Type C";
            this.typeCToolStripMenuItem.Click += new System.EventHandler(this.typeCToolStripMenuItem_Click);
            // 
            // oFFToolStripMenuItem
            // 
            this.oFFToolStripMenuItem.Name = "oFFToolStripMenuItem";
            this.oFFToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.oFFToolStripMenuItem.Text = "OFF";
            this.oFFToolStripMenuItem.Click += new System.EventHandler(this.oFFToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvirLaideToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // ouvirLaideToolStripMenuItem
            // 
            this.ouvirLaideToolStripMenuItem.Name = "ouvirLaideToolStripMenuItem";
            this.ouvirLaideToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ouvirLaideToolStripMenuItem.Text = "Ouvir l\'aide";
            this.ouvirLaideToolStripMenuItem.Click += new System.EventHandler(this.ouvirLaideToolStripMenuItem_Click);
            // 
            // timerLevel
            // 
            this.timerLevel.Tick += new System.EventHandler(this.timerLevel_Tick);
            // 
            // timerBonus4
            // 
            this.timerBonus4.Tick += new System.EventHandler(this.timerBonus4_Tick);
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(644, 562);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tetris";
            this.Text = "Tetris";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tetris_FormClosed);
            this.Load += new System.EventHandler(this.Tetris_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.move);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerPrincipale;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tetrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvirLaideToolStripMenuItem;
        private System.Windows.Forms.Timer timerLevel;
        private System.Windows.Forms.Timer timerBonus4;


    }
}