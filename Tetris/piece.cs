using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Tetris
{
    /**
    *  <summary> Classe piece qui définira les piéces du tétris elle sera composé d'un tableau de case
    *  </summary>
    * 
    * */
    class piece
    {
        private @case centre; // nom malheureux, c'est les coordonné du carré. On prend comme point du référence du carré le point en haut à gauche
        private @case[][] tableau; // Un tableau 4,4 ou il y aura des 0 pour les cases vides et des 1 pour les cases pleines pour une pièce à l'intérieur de son carré 4x4
        private int type;
        /**
    *  <summary> Constructeur par défauts
    *  </summary>
    * 
    * */
        public piece() { }
        /**
   *  <summary> Constructeur qui construit la piece de type données et pour centre la case de coordonnées X et Y
         *  On construit les pièces en allant chercher dans les fichier .piece  dans le dossier pieces
         * <param name=x>parametre qui correspont à sa position verticale du centre de la pièce</param>
         * <param name=y>parametre qui correspont à sa position horizontale du centre de la pièce</param>
         * <param name=type>parametre qui correspont au type de la pièce charger</param>
   *  </summary>
   * 
   * */
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
                        tableau[i][j].Color = type;
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
        /**
    *  <summary> Le type permet de difinir qu'elle est la pièce (et qui corespont aussi à la couleur de la pièce)
         *  On a en tous 9 pièce numéroté de 0 à 8
    *  </summary>
    * 
    * */
        public int Type
        {
            get { return type; }
            set { this.type = value; }
        }

        /**
    *  <summary> Cette fonction permet de définir un nouveau centre à la pièce
    *  </summary>
    * 
    * */
        public void setCentre(@case centre)
        {
            this.centre = centre;
        }
        /**
    *  <summary> Cette fonction permet de récupérer le centre de la pièce
         *  <returns>Renvoie une case </returns>
    *  </summary>
    * 
    * */
        public @case getCentre()
        {
            return centre;
        }
        /**
    *  <summary> Cette fonction permet de récupérer le tableau de type  case comportant la pièce 
    *  <returns>Renvoie un tableau case </returns>
    *  </summary>
    * 
    * */
        public @case[][] getTableau()
        {
            return tableau;
        }
        /**
   *  <summary> Cette fonction permet de faire les rotations des pièces.
         *  Toutes le pièce on un centre de rotation autour de la case (2,1) sauf la barrequ'on traite séparement.
 * <param name=sens>parametre qui permet de savoir dans quel sens il faut faire la rotation.
         * 1 on tourne dans le sens trigo
         * 2 on tourne dans le sens inverse</param>
   *  </summary>
   * 
   * */

        public void rotationPiece(int sens) 
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
                                tableau[i][j].Color = type;


                            }
                            else
                            {
                                tableau[i][j].Pleine = 0;
                                tableau[i][j].Color = 0;
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
                                tableau[i][j].Color = type;

                            }
                            else
                            {
                                tableau[i][j].Pleine = 0;
                                tableau[i][j].Color = 0;
                            }
                        }
                    }
                }
            }
            else 
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
                    temp = tableau[0][1].Color;
                    tableau[0][1].Color = tableau[0][3].Color;
                    tableau[0][3].Color = tableau[2][3].Color;
                    tableau[2][3].Color = tableau[2][1].Color;
                    tableau[2][1].Color = temp;
                    temp = tableau[0][2].Color;
                    tableau[0][2].Color = tableau[1][3].Color;
                    tableau[1][3].Color = tableau[2][2].Color;
                    tableau[2][2].Color = tableau[1][1].Color;
                    tableau[1][1].Color = temp;
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
                    temp = tableau[0][1].Color;
                    tableau[0][1].Color = tableau[2][1].Color;
                    tableau[2][1].Color = tableau[2][3].Color;
                    tableau[2][3].Color = tableau[0][3].Color;
                    tableau[0][3].Color = temp;
                    temp = tableau[0][2].Color;
                    tableau[0][2].Color = tableau[1][1].Color;
                    tableau[1][1].Color = tableau[2][2].Color;
                    tableau[2][2].Color = tableau[1][3].Color;
                    tableau[1][3].Color = temp;


                }
            }



        }

       

    }
}
