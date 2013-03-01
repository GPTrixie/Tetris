using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    class espace
    {
        private int hauteur;
        private int largeur;
        private piece pieceEnCour;
        private @case[][] tableau;


        public espace() { }

        public espace(int hauteur, int largeur)
        {
            this.largeur = largeur;
            this.hauteur = hauteur;
            pieceEnCour = new piece(); //peut etre pas utile


            tableau = new @case[largeur][];
            for (int i = 0; i < largeur; i++)
            {
                tableau[i] = new @case[hauteur];
                for (int j = 0; j < hauteur; j++)
                {
                    tableau[i][j] = new @case(i, j);
                }
            }

        }

        public int Hauteur
        {
            get { return hauteur; }
            set { this.hauteur = value; }
        }
        public int Largeur
        {
            get { return largeur; }
            set { this.largeur = value; }
        }

        public int getCase(int x, int y)
        {

            return tableau[x][y].Pleine;

        }
        public void setPieceEncour(int x, int y, int type)
        {
            pieceEnCour = new piece(x, y, type);
        }
        public piece getPieceEncour()
        {
            return pieceEnCour;
        }

        public void placerPiece()
        {
            @case[][] temp = pieceEnCour.getTableau();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (temp[i][j].Pleine == 1)
                    {
                        tableau[i + pieceEnCour.getCentre().X][j + pieceEnCour.getCentre().Y].Pleine = 1;
                    }
                }
            }

        }
        public void supprimerPiece()
        {
            @case[][] temp = pieceEnCour.getTableau();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (temp[i][j].Pleine == 1)
                    {
                        tableau[i + pieceEnCour.getCentre().X][j + pieceEnCour.getCentre().Y].Pleine = 0;
                    }
                }
            }

        }
        public void deplacerPiece(@case centre)
        {
            this.supprimerPiece();
            pieceEnCour.setCentre(centre);
            this.placerPiece();
        }
        public void destructionLigne(int x)
        {


        }
        public void testDinligne(int x)
        {


        }
        public void afficherTest()
        {
            for (int i = 0; i < largeur; i++)
            {
                for (int j = 0; j < hauteur; j++)
                {
                    Console.Write(tableau[i][j].Pleine);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
