using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{ /**
     *  <summary> Classe espace corespont à l'endroit ou il y aura l'espace de jeux ou l'espace ou on affichera la prochaine pièce 
     *  </summary>
     * 
     * */
    class espace
    {
        private int hauteur;
        private int largeur;
        private piece pieceEnCour;
        private @case[][] tableau;

        /**
     *  <summary> Constructeur par défauts
     *  </summary>
     * 
     * */
        public espace() { }
        /**
     *  <summary> Constructeur qui définie un espace par sa hauteur et sa largeur et alloue la mémoire du tableau de case en fonction.
         *  Le tableau commence à 0 
     *  </summary>
     * 
     * */
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
        /**
     *  <summary> Hauteur est le nombre de case verticalement de l'espace
     *  </summary>
     * 
     * */
        public int Hauteur
        {
            get { return hauteur; }
            set { this.hauteur = value; }
        }
        /**
     *  <summary> Largeur est le nombre de case horizontalement de l'espace
     *  </summary>
     * 
     * */
        public int Largeur
        {
            get { return largeur; }
            set { this.largeur = value; }
        }
        /**
     *  <summary> Fonction qui renvoie la valeur pleine d'une case du tableau.
     *  </summary>
          * <param name=x>parametre qui correspont à la position horizontale de la case voulue</param>
         * <param name=y>parametre qui correspont à la position verticale de la case voulue</param>
         * <returns>Renvoie un entier corespondant à la valeur Plein de la case (x,y)</returns>
     * 
     * */
        public int getCase(int x, int y) 
        {

            return tableau[x][y].Pleine;

        }
        /**
     *  <summary> Fonction qui renvoie la valeur color d'une case du tableau.
     *  </summary>
          * <param name=x>parametre qui correspont à la position horizontale de la case voulue</param>
         * <param name=y>parametre qui correspont à la position verticale de la case voulue</param>
         * <returns>Renvoie un entier corespondant à la valeur color de la case (x,y)</returns>
     * 
     * */
        public int getCaseColor(int x, int y)//couleur
        {

            return tableau[x][y].Color;

        }
        /**
     *  <summary> Méthode qui définie la piece en cours.
     *  </summary>
          * <param name=pieceEnCour>parametre qui correspont a la pièce que l'ont veut mettre dans l'espace </param>

     * */
        public void setPieceEnCour(piece pieceEnCour)
        {
            this.pieceEnCour = pieceEnCour;
        }
        /**
     *  <summary> Méthode qui définie la piece en cours.
     *  </summary>
     * <returns>Renvoie un type piece corespondant à la piece en cour dans l'espace</returns>

     * */

        public piece getPieceEncour()
        {
            return pieceEnCour;
        }
        /**
     *  <summary> Méthode qui remplie le tableau de l'espace à l'endroit où  est la pièce.
     *  </summary>

     * */
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
                        tableau[i + pieceEnCour.getCentre().X][j + pieceEnCour.getCentre().Y].Color = pieceEnCour.Type;
                    }
                }
            }

        }
        /**
   *  <summary> Méthode qui supprime la piece dans  le tableau de l'espace à l'endroit où  elle est .
   *  </summary>
   * */
        public void supprimerPiece()
        {
            @case[][] temp = pieceEnCour.getTableau();
             int A = pieceEnCour.getCentre().X;
             int B = pieceEnCour.getCentre().Y;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (temp[i][j].Pleine == 1)
                    {
                       
                        tableau[i + A][j + B].Pleine = 0;
                        tableau[i + A][j + B].Color = 0;
                    }
                }
            }

        }
        /**
  *  <summary> Méthode qui va test sur le tableau de l'espace si la piece peut se déplacer .
  *  </summary>
*    <param name=sens>parametre qui correspont au sens ou l'on veut tester le déplacement(1 droite, 2 gauche 3 bas)  </param>
 * <returns>Renvoie le sens ou on a test si le déplacement est possible autrement 0 si on peut pas se déplacer</returns>
         * * */
        public int testDeplacementPiece(int sens) 
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
                        if (i == 3)
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
                                if (i + pieceEnCour.getCentre().X < hauteur-1)
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
        /**
  *  <summary> Méthode qui va test sur le tableau de l'espace si la piece peut faire la rotation dans le sens indiquer .
  *  </summary>
*    <param name=sens>parametre qui correspont au sens ou l'on veut faire la rotation (1 droite, 2 gauche )  </param>
 * <returns>Renvoie le sens ou on a test si la rotation est possible autrement 0 si on peut pas faire la rotation</returns>
         * * */
        public int testRotation(int sens)
        {

                if( pieceEnCour.getCentre().Y >largeur -4)
                  return 0;

            piece tempPiece =new piece(pieceEnCour.getCentre().X,pieceEnCour.getCentre().Y,pieceEnCour.Type);
            @case[][] temp2 = pieceEnCour.getTableau();

            

            tempPiece.rotationPiece(sens);
            
            @case[][] temp = tempPiece.getTableau();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    
                        if (temp[i][j].Pleine == 1 && temp2[i][j].Pleine != 1 && tableau[i + pieceEnCour.getCentre().X][j + pieceEnCour.getCentre().Y].Pleine == 1)
                        {
                            return 0;
                        }
                }
            }
            return sens;
        }
        /**
  *  <summary> Méthode qui va déplacer la piece en 3 étapes ,la première en supprimant la piece du tableau,la deuxieme en changant le 
         *  centre de la piece et en 3eme on va placer la piece avec le nouveau centre.
  *  </summary>
*    <param name=x>parametre qui correspont au coordonnées horizontale  du centre ou on veut déplacer la pièce</param>
 *     <param name=y>parametre qui correspont au coordonnées verticale  du centre ou on veut déplacer la pièce</param>
        * */
        public void deplacerPiece(int x, int y)
        {
            @case centre = new @case(x + pieceEnCour.getCentre().X, y + pieceEnCour.getCentre().Y);
            this.supprimerPiece();
            pieceEnCour.setCentre(centre);
            this.placerPiece();
        }
        /**
  *  <summary> Méthode qui va déplacer la piece en 3 étapes ,la première en supprimant la piece du tableau,la deuxieme en faisant uen rotation à la pièce 
         *  et en 3eme on va placer la piece avec la rotation effectué.
  *  </summary>
*    <param name=sens>parametre qui correspont au sens de la rotation à effectuer</param>
      * */

        public void rotationPiece(int sens)
        {
           this.supprimerPiece();
            pieceEnCour.rotationPiece(sens);
           this.placerPiece();
        }

        public Boolean testFinligne(int x)
        {
            for (int j = 0; j < largeur; j++)
            {
                if (tableau[x][j].Pleine == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public Boolean testLigneVide(int x)
        {
            for (int j = 0; j < largeur; j++)
            {
                if (tableau[x][j].Pleine == 1)
                {
                    return false;
                }
            }
            return true;
        }
        public void descendrePiece(int ligne)
        {
            int j = ligne;
            while (testLigneVide(j) == false &&  j >-1)
            {
                for (int i = 0; i < largeur; i++)
                {
                    tableau[j][i].Pleine = tableau[j - 1][i].Pleine;
                    tableau[j][i].Color = tableau[j - 1][i].Color;
                }
                j--;
            }

            for (int i = 0; i < largeur; i++)
            {
                tableau[j][i].Pleine = 0;
            }
        }

        public int testFinJeux()
        {

            @case[][] temp = pieceEnCour.getTableau();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (temp[i][j].Pleine == 1 && tableau[i][j].Pleine == 1)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
    }


}
