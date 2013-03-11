namespace Tetris
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // Musique
            // 
            this.Musique.AutoSize = true;
            this.Musique.Location = new System.Drawing.Point(98, 80);
            this.Musique.Name = "Musique";
            this.Musique.Size = new System.Drawing.Size(53, 13);
            this.Musique.TabIndex = 1;
            this.Musique.Text = "Musique :";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(36, 213);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Musique);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Musique;
        private System.Windows.Forms.Button start;

    }
}

