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

        public void Jouer(int musique,int level)
        {

            graphicsObj = this.CreateGraphics();
            tetris = new partie(musique,level);
            timer1.Interval = 1000 - tetris.Niveau * 80;
            tetris.start();
            Pen myPen = new Pen(Color.Black, 2);
            Rectangle myRectangle = new Rectangle(10, 10, 202, 442);
            graphicsObj.DrawRectangle(myPen, myRectangle);
            myRectangle = new Rectangle(400, 10, 84, 84);
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
                gameOver fin = new gameOver(tetris.Score);
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
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Public\Music\Sample Music\tetris.wav");
            simpleSound.Play();
        }
        private void ecrire()
        {
            graphicsObj.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(300, 350, 250, 100));
            graphicsObj.FillRectangle(new SolidBrush(Color.White), new Rectangle(300, 350, 250, 100));
            string drawString = "Niveau : " + tetris.Niveau;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 20);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            graphicsObj.DrawString(drawString, drawFont, drawBrush, 300, 350);
            drawString = "Score : " + tetris.Score;
            graphicsObj.DrawString(drawString, drawFont, drawBrush, 300, 380);
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
