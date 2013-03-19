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
    *  <summary> Classe case comprenant les coordonnées,la couleur et si elle est pleine
    *  </summary>
    * 
    * */
    partial class Tetris : Form
    {
        static partie tetris;
        static System.Drawing.Graphics graphicsObj;

        public Tetris()
        {
            InitializeComponent();
            
            
        }

        private void Tetris_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
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
            timer1.Interval = 1000 - tetris.Niveau * 80;
            tetris.start();
            Pen myPen = new Pen(Color.Black, 2);
            Rectangle myRectangle = new Rectangle(10, 10, 200, 440);
            graphicsObj.DrawRectangle(myPen, myRectangle);
            myRectangle = new Rectangle(400, 10, 80, 80);
            graphicsObj.DrawRectangle(myPen, myRectangle);
            
            tetris.printPiece(graphicsObj);
            tetris.printPuit(graphicsObj);
           this.ecrire();
           this.playSimpleSound();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tetris.deplacerTimer(1, timer1) == 1)
            {
                timer1.Enabled = false;
                
                gameOver fin = new gameOver(tetris.Score,tetris.Niveau);
                this.Hide();
                fin.ShowDialog();
                this.Close();
                
               
            }
            else
            {
                
                tetris.printPuit(graphicsObj);
                tetris.printPiece(graphicsObj);

                this.ecrire();
            }

        }
        private void playSimpleSound()
        {
            switch (tetris.Musique)
            {
                case 1: timer1.Interval = 38000;
                    break;
                case 2: timer1.Interval = 40000;
                    break;
                case 3: timer1.Interval = 98000;
                    break;
            }
            SoundPlayer simpleSound = new SoundPlayer(@"./Musique\theme" + tetris.Musique + ".wav");
            simpleSound.Play();
        }
        private void ecrire()
        {
            graphicsObj.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(300, 350, 280, 100));
            graphicsObj.FillRectangle(new SolidBrush(Color.White), new Rectangle(300, 350, 280, 100));
            string drawString = "Niveau : " + tetris.Niveau;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 20);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            graphicsObj.DrawString(drawString, drawFont, drawBrush, 300, 350);
            drawString = "Score : " + tetris.Score;
            graphicsObj.DrawString(drawString, drawFont, drawBrush, 300, 380);
            drawString = "Nombres de ligne : " + tetris.NbrLigne;
            graphicsObj.DrawString(drawString, drawFont, drawBrush, 300, 410);
        }
        private void move(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'Q':
                    tetris.deplacerPiece(2);
                    tetris.printPuit(graphicsObj);
                    break;
                case 'q':
                    tetris.deplacerPiece(2);
                    tetris.printPuit(graphicsObj);
                    break;
                //case (char)52:
                case 'D':
                    tetris.deplacerPiece(1);
                    tetris.printPuit(graphicsObj);
                    break;
                case 'd':
                    tetris.deplacerPiece(1);
                    tetris.printPuit(graphicsObj);
                    break;
                case 'a':
                    tetris.rotationPiece(1);
                    tetris.printPuit(graphicsObj);
                    break;
                case 'e':
                    tetris.rotationPiece(2);
                    tetris.printPuit(graphicsObj);
                    break;
                case 's':
                    if(timer1.Interval == 10)
                        timer1.Interval=1000 - tetris.Niveau*80;
                    else
                    timer1.Interval = 10;
                    break;
            }
        }

        private void Tetris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.playSimpleSound();
        }

       


        
        
    }
}
