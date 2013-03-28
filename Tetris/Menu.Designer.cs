namespace Tetris
{
    partial class Menu
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
            this.Musique = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Niveau = new System.Windows.Forms.TextBox();
            this.erreur = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tetrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejouerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvirLaideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Musique
            // 
            this.Musique.AutoSize = true;
            this.Musique.Font = new System.Drawing.Font("Nightclub BTN Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Musique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Musique.Location = new System.Drawing.Point(94, 36);
            this.Musique.Name = "Musique";
            this.Musique.Size = new System.Drawing.Size(79, 24);
            this.Musique.TabIndex = 1;
            this.Musique.Text = "Musique :";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(176, 113);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type B";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type C";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nightclub BTN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Niveau : ";
            // 
            // Niveau
            // 
            this.Niveau.Location = new System.Drawing.Point(115, 115);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(36, 20);
            this.Niveau.TabIndex = 7;
            // 
            // erreur
            // 
            this.erreur.AutoSize = true;
            this.erreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.erreur.Location = new System.Drawing.Point(42, 160);
            this.erreur.Name = "erreur";
            this.erreur.Size = new System.Drawing.Size(209, 24);
            this.erreur.TabIndex = 8;
            this.erreur.Text = "Erreur Niveau Inccorect";
            this.erreur.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tetrisToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(283, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tetrisToolStripMenuItem
            // 
            this.tetrisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rejouerToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.tetrisToolStripMenuItem.Name = "tetrisToolStripMenuItem";
            this.tetrisToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.tetrisToolStripMenuItem.Text = "Tetris";
            // 
            // rejouerToolStripMenuItem
            // 
            this.rejouerToolStripMenuItem.Name = "rejouerToolStripMenuItem";
            this.rejouerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rejouerToolStripMenuItem.Text = "Rejouer";
            this.rejouerToolStripMenuItem.Click += new System.EventHandler(this.rejouerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scoreToolStripMenuItem.Text = "score";
            this.scoreToolStripMenuItem.Click += new System.EventHandler(this.scoreToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(283, 198);
            this.Controls.Add(this.erreur);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Musique);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Tetris";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Musique;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Niveau;
        private System.Windows.Forms.Label erreur;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tetrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejouerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvirLaideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;

    }
}

