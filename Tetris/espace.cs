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


            tableau = new @case[hauteur][];
            for (int i = 0; i < hauteur; i++)
            {
                tableau[i] = new @case[largeur];
                for (int j = 0; j < largeur; j++)
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
        public int testDeplacementPiece(int sens) //renvoie l'entier d'entre si possible de bouger autrement envoie 0 (1 droite, 2 gauche 3 bas)
        {
            @case[][] temp = pieceEnCour.getTableau();
            if (sens == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (j + 1 > 3)
                        {
                            if (temp[i][j].Pleine == 1)
                            {
                                if (j + pieceEnCour.getCentre().Y + 1 < largeur)
                                {
                                    if (tableau[i + pieceEnCour.getCentre().X][j + pieceEnCour.getCentre().Y + 1].Pleine == 1)
                                    {

                                        return 0;

                                    }
                                }
                                else
                                {
                                    return 0;
                                }
                            }
                        }
                        else
                        {
                            if (temp[i][j].Pleine == 1 && temp[i][j + 1].Pleine != 1)
                            {
                                if (j + pieceEnCour.getCentre().Y + 1 < largeur)
                                {
                                    if (tableau[i + pieceEnCour.getCentre().X][j + pieceEnCour.getCentre().Y + 1].Pleine == 1)
                                    {

                                        return 0;

                                    }
                                }
                                else
                                {
                                    return 0;
                                }
                            }

                        }

                    }
                }
                return 1;
            }
            if (sens == 2)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (j == 0)
                        {
                            if (temp[i][j].Pleine == 1)
                            {
                                if (j + pieceEnCour.getCentre().Y != 0)
                                {
                                    if (tableau[i + pieceEnCour.getCentre().X][j + pieceEnCour.getCentre().Y - 1].Pleine == 1)
                                    {

                                        return 0;

                                    }
                                }
                                else
                                {
                                    return 0;
                                }
                            }
                        }
                        else
                        {
                            if (temp[i][j].Pleine == 1 && temp[i][j - 1].Pleine != 1)
                            {
                                if (j + pieceEnCour.getCentre().Y != 0)
                                {
                                    if (tableau[i + pieceEnCour.getCentre().X][j + pieceEnCour.getCentre().Y - 1].Pleine == 1)
                                    {

                                        return 0;

                                    }
                                }
                                else
                                {
                                    return 0;
                                }
                            }

                        }

                    }
                }
                return 2;
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 4)
                        {
                            if (temp[i][j].Pleine == 1)
                            {
                                if (i + pieceEnCour.getCentre().X != hauteur - 1)
                                {
                                    if (tableau[i + pieceEnCour.getCentre().X + 1][j + pieceEnCour.getCentre().Y].Pleine == 1)
                                    {

                                        return 0;

                                    }
                                }
                                else
                                {
                                    return 0;
                                }
                            }
                        }
                        else
                        {
                            if (temp[i][j].Pleine == 1 && temp[i + 1][j].Pleine != 1)
                            {
                                if (j + pieceEnCour.getCentre().Y != hauteur - 1)
                                {
                                    if (tableau[i + pieceEnCour.getCentre().X + 1][j + pieceEnCour.getCentre().Y].Pleine == 1)
                                    {

                                        return 0;

                                    }
                                }
                                else
                                {
                                    return 0;
                                }
                            }

                        }

                    }
                }
                return 3;
            }


        }


        public void deplacerPiece(int x, int y)
        {
            @case centre = new @case(x + pieceEnCour.getCentre().X, y + pieceEnCour.getCentre().Y);
            this.supprimerPiece();
            pieceEnCour.setCentre(centre);
            this.placerPiece();
        }
        public void rotationPiece(int sens)
        {
            this.supprimerPiece();
            pieceEnCour.rotationPiece(sens);
            this.placerPiece();
        }
        public void destructionLigne(int x)
        {
            for (int j = 0; j < largeur; j++)
            {
                tableau[x][j].Pleine = 0;
            }

        }
        public Boolean testFinligne(int x)
        {
            for (int j = 0; j < hauteur; j++)
            {
                if (tableau[x][j].Pleine == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void afficherTest()
        {
            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    Console.Write(tableau[i][j].Pleine);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
