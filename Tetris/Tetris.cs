using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Tetris
{
    /**
    *  <summary>  Classe Tetris est une classe héritier de la classe Form qui permet de gérer la partie de Tétris.
    *  </summary>
    * 
    * */
    partial class Tetris : Form
    {
        static partie tetris;
        static System.Drawing.Graphics graphicsObj;
        private int compteur;
        private Random rndNumber = new Random();
        private SoundPlayer simpleSound;

        public Tetris()
        {
            InitializeComponent();
            
            
        }

        private void Tetris_Load(object sender, EventArgs e)
        {
            timerPrincipale.Start();
        }
        /**
    *  <summary> Fonction principal du jeu qui lance la partie de tétris et qui met les valeur de base.
    *  </summary>
    * <param name=musique>parametre qui correspont à la musique choisit au début du programme</param>
      * <param name=niveau>parametre qui correspont au niveau choisit pour commencer la partie</param>
    * */
        public void Jouer(int musique,int niveau)
        {

            graphicsObj = this.CreateGraphics();
            tetris = new partie(musique,niveau);
            timerPrincipale.Interval = 1000 - tetris.Niveau * 80;
            tetris.start();
            tetris.affichage(graphicsObj);
           this.playSimpleSound();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tempNiveau = tetris.Niveau;
            if (tetris.deplacerTimer(timerPrincipale) == 1)
            {
                timerPrincipale.Enabled = false;
                simpleSound.SoundLocation = @"./Musique\trololo2.wav";
                simpleSound.PlayLooping();
                gameOver fin = new gameOver(tetris.Score,tetris.Niveau);
                this.Hide();
                fin.ShowDialog();
                this.Close();
                
               
            }
            else
            {
                tetris.affichage(graphicsObj);
                if (tempNiveau < tetris.Niveau)
                {
                    compteur = 0;
                    timerPrincipale.Stop();
                    simpleSound.SoundLocation = @"./Musique\trololo.wav";
                    simpleSound.PlayLooping();
                    timerLevel.Start();

                }
                
            }

        }
        private void playSimpleSound()
        {
            
           simpleSound=new SoundPlayer();
            if (tetris.Musique != 0)
            {
                simpleSound.SoundLocation = @"./Musique\theme" + tetris.Musique + ".wav";
                simpleSound.PlayLooping();
            }
            else
            {
                simpleSound.Stop();

            }
        }
       
        private void move(object sender, KeyPressEventArgs e)
        {
            if (tetris.Bonus == 5)
            {
                switch (e.KeyChar)
                {
                    case 'D':
                        tetris.deplacerPiece(2);
                        break;
                    case 'd':
                        tetris.deplacerPiece(2);
                        break;
                    case 'Q':
                        tetris.deplacerPiece(1);
                        break;
                    case 'q':
                        tetris.deplacerPiece(1);
                        break;
                    case 'e':
                        tetris.rotationPiece(1);
                        break;
                    case 'E':
                        tetris.rotationPiece(1);
                        break;
                    case 'a':
                        tetris.rotationPiece(2);
                        break;
                    case 'A':
                        tetris.rotationPiece(2);
                        break;
                    case 's':
                        if (timerPrincipale.Interval == 10)
                            timerPrincipale.Interval = 1000 - tetris.Niveau * 80;
                        else
                            timerPrincipale.Interval = 10;
                        break;
                }

            }
            else
            {
                switch (e.KeyChar)
                {
                    case 'Q':
                        tetris.deplacerPiece(2);
                        break;
                    case 'q':
                        tetris.deplacerPiece(2);
                        break;
                    case 'D':
                        tetris.deplacerPiece(1);
                        break;
                    case 'd':
                        tetris.deplacerPiece(1);
                        break;
                    case 'a':
                        tetris.rotationPiece(1);
                        break;
                    case 'A':
                        tetris.rotationPiece(1);
                        break;
                    case 'e':
                        tetris.rotationPiece(2);
                        break;
                    case 'E':
                        tetris.rotationPiece(2);
                        break;
                    case 's':
                        if (timerPrincipale.Interval == 10)
                            timerPrincipale.Interval = 1000 - tetris.Niveau * 80;
                        else
                            timerPrincipale.Interval = 10;
                        break;
                }
            }
            tetris.affichage(graphicsObj);
        }

        private void Tetris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.playSimpleSound();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        private void typeAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tetris.Musique = 1;
            this.playSimpleSound();
        }

        private void typeBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tetris.Musique = 2;
            this.playSimpleSound();
        }

        private void typeCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tetris.Musique = 3;
            this.playSimpleSound();
        }

        private void oFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tetris.Musique = 0;
            this.playSimpleSound();
        }

        private void ouvirLaideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo DocumentAide = new System.Diagnostics.ProcessStartInfo(@"doc\aide.pdf", "");

            System.Diagnostics.Process.Start(DocumentAide); 
        }

        private void timerLevel_Tick(object sender, EventArgs e)
        {
            int temp=rndNumber.Next(6);
            compteur++;
            graphicsObj.DrawImage(Image.FromFile("./image/image"+temp+".jpg"), new Rectangle(500, 470, 60, 60), 0, 0, 60, 60, GraphicsUnit.Pixel);
            if (compteur == 50)
            {
               
                switch(temp)
                {
                    case 0:
                        tetris.bomb(rndNumber.Next(22), rndNumber.Next(10));

                        break;
                    case 1:
                        if (timerPrincipale.Interval == 100)
                        {

                            tetris.Score -= 100;
                        }
                        else
                        {
                            timerPrincipale.Interval = tetris.Timer - 100;
                            tetris.Timer = timerPrincipale.Interval;
                        }
                    break;
                    case 2 :
                        tetris.NbrPiece = tetris.NbrPiece+1;
                    break;
                    case 3:
                        tetris.ajoutLigne(rndNumber.Next(10));
                    break;
                    case 4:
                    timerBonus4.Start();
                    timerBonus4.Interval = 60000;
                    break;
                     }
                timerLevel.Stop();
                timerPrincipale.Start();
                tetris.Bonus = temp;
                playSimpleSound();


            }
        }

        private void timerBonus4_Tick(object sender, EventArgs e)
        {
            timerBonus4.Stop();
            tetris.Bonus = -1;

        }

       


        
        
    }
}
