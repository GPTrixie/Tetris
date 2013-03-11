using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tetris
{
    class partie
    {
        private int score;
        private int niveau;
        private int temp; // en seconde ? 
        private int musique;
        private espace pieceSuivante;
        private espace puit;

        public partie(int musique)
        {
            score = 0;
            temp = 0;
            niveau = 0;
            this.musique = musique;
            puit = new espace(22, 10); // taille de l'écran de jeux
            pieceSuivante = new espace(4, 4); // taille des carrés des pieces
            ;

        }
        public int Score
        {
            get { return score; }
            set { this.score = value; }
        }
        public int Niveau
        {
            get { return Niveau; }
            set { this.Niveau = value; }
        }
        public int Musique
        {
            get { return musique; }
            set { this.musique = value; }
        }
        public int Temp
        {
            get { return temp; }
            set { this.temp = value; }
        }
        public piece randPiece(Random rndNumber)
        {

            return new piece(0, 0, rndNumber.Next(7));
        }
        public void setPuit(espace puit)
        {
            this.puit = puit;

        }
        public void setPieceSuivante(espace pieceSuivante)
        {
            this.pieceSuivante = pieceSuivante;

        }
        public void start()
        {
            Random rndNumber = new Random();
            puit.setPieceEncour(randPiece(rndNumber));
            pieceSuivante.setPieceEncour(randPiece(rndNumber));
            puit.placerPiece();
            pieceSuivante.placerPiece();


        }
        public void printPiece(Graphics graphicsObj)
        {
            SolidBrush myBrush = new SolidBrush(Color.Red);
            SolidBrush myBrush2 = new SolidBrush(Color.White);
            
            @case[][] tableauTemp = pieceSuivante.getPieceEncour().getTableau();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tableauTemp[i][j].Pleine == 1)
                    {
                        graphicsObj.FillRectangle(myBrush, new Rectangle(402+i*20, 12+j*20, 20, 20));
                    }
                    else
                    {
                        graphicsObj.FillRectangle(myBrush2, new Rectangle(402 + i * 20, 12 + j * 20, 20, 20));
                    }
                }
            }
        }
        public void printPuit(Graphics graphicsObj)
        {
            SolidBrush myBrush = new SolidBrush(Color.Red);
            SolidBrush myBrush2 = new SolidBrush(Color.White);

            for (int i = 0; i < puit.Hauteur; i++)
            {
                for (int j = 0; j < puit.Largeur; j++)
                {
                    if (puit.getCase(i, j) == 1)
                    {
                        graphicsObj.FillRectangle(myBrush, new Rectangle(12 + j * 20, 12 + i * 20, 20, 20));
                    }
                    else
                    {
                        graphicsObj.FillRectangle(myBrush2, new Rectangle(12 + j * 20, 12 + i * 20, 20, 20));
                    }
                }
            }
        }

        public void deplacerTimer(int vitesse, System.Windows.Forms.Timer timer1)
        {
            if (puit.testDeplacementPiece(3) == 3)
            {
                puit.deplacerPiece(vitesse * 1, 0);
            }
            else
            {
                timer1.Interval = 1000; //changer par rapport a la vitesse
                placementPiece();
                puit.setPieceEncour(pieceSuivante.getPieceEncour());
                Random rndNumber = new Random();
                pieceSuivante.supprimerPiece();
                pieceSuivante.setPieceEncour(randPiece(rndNumber));
                puit.placerPiece();
                pieceSuivante.placerPiece();
            }
        }
        public void deplacerPiece(int sens)
        {
            if (puit.testDeplacementPiece(sens) == sens)
            {
                if (sens == 1)
                {
                    puit.deplacerPiece(0, 1);
                }
                else
                {
                    puit.deplacerPiece(0, -1);
                }
            }
            else
            {
                
            }
        }
        public void rotationPiece(int sens)
        {
            if (puit.testRotation(sens) == sens)
            {
                if (sens == 1)
                {
                    
                    puit.rotationPiece(sens);
                }
                else
                {
                    puit.rotationPiece(sens);
                }
            }
            else
            {

            }
        }
        public void placementPiece()
        {
            int i=puit.Hauteur -1;
            while (puit.testLigneVide(i) == false)
            {
                if (puit.testFinligne(i) == true)
                {
                    puit.descendrePiece(i);
                    score += 10;
                   
                    i -= 1;
                }
                i--;
            }
        }
    }
}
