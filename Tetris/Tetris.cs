using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tetris
{
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
        }

        public void Jouer(int musique)
        {
            graphicsObj = this.CreateGraphics();
            tetris = new partie(musique);
            tetris.start();
            Pen myPen = new Pen(Color.Black, 2);
            Rectangle myRectangle = new Rectangle(10, 10, 208, 448);

            graphicsObj.DrawRectangle(myPen, myRectangle);
            myRectangle = new Rectangle(400, 10, 88, 88);
            graphicsObj.DrawRectangle(myPen, myRectangle);
            tetris.printPiece(graphicsObj);
            tetris.printPuit(graphicsObj);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tetris.deplacerTimer(1,timer1);
            tetris.printPuit(graphicsObj);
            tetris.printPiece(graphicsObj);
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

       


        
        
    }
}
