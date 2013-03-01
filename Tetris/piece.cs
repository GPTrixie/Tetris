using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Tetris
{
    class piece
    {
        private @case centre; // nom malheureux, c'est les coordonné du carré. On prend comme point du référence du carré le point en haut à gauche
        private @case[][] tableau; // Un tableau 4,4 ou il y aura des 0 pour les cases vides et des 1 pour les cases pleines pour une pièce à l'intérieur de son carré 4x4
        private int type;

        public piece() { }
        public piece(int x, int y, int type)// mettre des coordonnées pour le centre cette fct sert de chargement de piece
        {
            String temp;

            try
            {

                StreamReader infile = File.OpenText("./Pieces/" + type + ".piece");

                tableau = new @case[4][];
                for (int i = 0; i < 4; i++)
                {
                    tableau[i] = new @case[4];

                    temp = infile.ReadLine();


                    for (int j = 0; j < 4; j++)
                    {

                        tableau[i][j] = new @case(i, j);
                        tableau[i][j].Pleine = (int)char.GetNumericValue((char)temp[2 * j]);
                    }
                }



                this.type = type;
                this.centre = new @case(x, y);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public int Type
        {
            get { return type; }
            set { this.type = value; }
        }
        public void setCentre(@case centre)
        {
            this.centre = centre;
        }
        public @case getCentre()
        {
            return centre;
        }
        public @case[][] getTableau()
        {
            return tableau;
        }
        public void rotationPiece(int sens) // Le centre de rotation est toujours (2,1), et on rotate dans le sens trigo
        {
            if (this.type == 2) // Si c'est la barre, qu'on traite à part
            {
                if (tableau[0][0].Pleine == 1)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (j == 1)
                            {
                                tableau[i][j].Pleine = 1;

                            }
                            else
                            {
                                tableau[i][j].Pleine = 0;
                            }
                        }
                    }
                }
                else
                {

                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (i == 0)
                            {
                                tableau[i][j].Pleine = 1;

                            }
                            else
                            {
                                tableau[i][j].Pleine = 0;
                            }
                        }
                    }
                }
            }
            else // on fait les bourrins y'a que 9 cas.
            {
                int temp;
                if (sens == 1)
                {
                    temp = tableau[0][1].Pleine;
                    tableau[0][1].Pleine = tableau[0][3].Pleine;
                    tableau[0][3].Pleine = tableau[2][3].Pleine;
                    tableau[2][3].Pleine = tableau[2][1].Pleine;
                    tableau[2][1].Pleine = temp;
                    temp = tableau[0][2].Pleine;
                    tableau[0][2].Pleine = tableau[1][3].Pleine;
                    tableau[1][3].Pleine = tableau[2][2].Pleine;
                    tableau[2][2].Pleine = tableau[1][1].Pleine;
                    tableau[1][1].Pleine = temp;
                }
                else
                {
                    temp = tableau[0][1].Pleine;
                    tableau[0][1].Pleine = tableau[2][1].Pleine;
                    tableau[2][1].Pleine = tableau[2][3].Pleine;
                    tableau[2][3].Pleine = tableau[0][3].Pleine;
                    tableau[0][3].Pleine = temp;
                    temp = tableau[0][2].Pleine;
                    tableau[0][2].Pleine = tableau[1][1].Pleine;
                    tableau[1][1].Pleine = tableau[2][2].Pleine;
                    tableau[2][2].Pleine = tableau[1][3].Pleine;
                    tableau[1][3].Pleine = temp;

                }
            }



        }

        public void afficherTest()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(tableau[i][j].Pleine);
                }
                Console.WriteLine(" ");
            }
        }

    }
}
