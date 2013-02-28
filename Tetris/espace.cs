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

        public espace(int hauteur,int largeur)
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
        public void setPieceEncour(int x, int y , int type)
        {
            pieceEnCour=new piece(x,y,type);
        }
        public void destructionLigne(int x)
        {


        }
        public void testDinligne(int x)
        {


        }
    }
}
