using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tetris
{
    /**
    *  <summary> Classe case comprenant les coordonnées,la couleur et si elle est pleine
    *  </summary>
    * 
    * */
    public partial class gameOver : Form
    {
        private int testE;
        private int score;
        /**
        *  <summary> Classe case comprenant les coordonnées,la couleur et si elle est pleine
        *  </summary>
        * 
        * */
        public gameOver(int score,int niveau)
        {
            InitializeComponent();
            this.score = score;
            label2.Text = "Score : " + score;
            label3.Text = "Niveau : " + niveau;
            testE = 1;
        }

        private void gameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            int continuer = 1;
            if (testE == 1)
            {
                string tmpFileName = Path.GetTempFileName();
                string temp;
                string[] temp2;
                TextReader tr = new StreamReader("./doc/score");
                TextWriter tw = new StreamWriter(tmpFileName);

                FileInfo f = new FileInfo("./doc/score");

                while (tr.Peek() > 0)
                {
                    temp =tr.ReadLine();
                    temp2=temp.Split(' ');
                    if (Convert.ToInt32(temp2[3]) <this.score  &&  continuer == 1)
                    {
                        tw.WriteLine(speudo.Text + " " + label2.Text + " " + label3.Text);
                        continuer = 0;
                    }
                   
                    tw.WriteLine(temp);
                }
                if (continuer == 1)
                {
                    tw.WriteLine(speudo.Text + " " + label2.Text + " " + label3.Text);

                }
                tr.Close();
                tr.Dispose();
                tw.Flush();
                tw.Close();
                tw.Dispose();
                File.Replace(tmpFileName, "./doc/score", string.Format("{0}.old", "./doc/score"));
               
                label5.Visible = true;
                testE = 0;
            }

        }

       

       
    }
}
