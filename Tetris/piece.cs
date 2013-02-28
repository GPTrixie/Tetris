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
        public piece(int type,int x,int y)// mettre des coordonnées pour le centre cette fct sert de chargement de piece
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
                        tableau[i][j].Pleine = (int)temp[2*j];
                    }
                }



                this.type = type;
                this.centre = new @case(x, y);
            }
            catch (IOException e) { }

        
        }

        public int Type
        {
            get { return type; }
            set { this.type = value; }
        }

        void deplacerPiece(@case centreBis)
        {


        }
       public void rotationPiece(int sens) // Le centre de rotation est toujours (2,1), et on rotate dans le sens trigo
       {
           if (this.type == 2) // Si c'est la barre, qu'on traite à part
           {
               if( elle est ----)
               {
                   on la Met |
               }
                   else
               {
                   on la Met ----
               }
           }
           else // on fait les bourrins y'a que 9 cas.
           {
               int temp
               tableau[1][1].Pleine = temp;      
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
