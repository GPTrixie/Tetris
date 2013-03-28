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
    *  <summary> Classe partie definie les principale fonction du jeux et qui va garder les données principales de la parie.
    *  </summary>
    * 
    * */
    class partie
    {
        private int score;
        private int niveau;
        private int nbrLigne;
        private int musique;
        private espace pieceSuivante;
        private espace puit;
        private int bonus;
        private int nbrPiece;
        private int timer;
        /**
   *  <summary> Constructeur par défaut.
   *  </summary>
   * 
   * */
        public partie(int musique,int niveau)
        {
            timer = 1000;
            score = 0;
            bonus=-1;
            nbrLigne = 0;
            nbrPiece = 8;
            this.niveau = niveau;
            this.musique = musique;
            puit = new espace(22, 10); // taille de l'écran de jeux
            pieceSuivante = new espace(4, 4); // taille des carrés des pieces
            

        }
        /**
   *  <summary> Timer est une variable qui corespont au delais entre chaque impulision du timer  principale.
   *  </summary>
   * 
   * */
        public int Timer
        {
            get { return timer; }
            set { this.timer = value; }
        }
        /**
  *  <summary> Bonus est une variable qui corespont au bonus en cours du niveau (-1 pas de bonus)
  *  </summary>
  * 
  * */
        public int Bonus
        {
            get { return bonus; }
            set { this.bonus = value; }
        }
        /**
  *  <summary> NbrPiece est une variable qui corespont au nombre de ligne qui est détruites.
  * 
  * */
        public int NbrPiece
        {
            get { return nbrPiece; }
            set { this.nbrPiece = value; }
        }
        /**
  *  <summary> Score est une variable qui corespont au score du joueur.
  * 
  * */
        public int Score
        {
            get { return score; }
            set { this.score = value; }
        }
        /**
    *  <summary> Niveau permet de définir le niveau où est le jouer, la vitesse augemente proportionellement au niveau(-40*niveau ms)
    *  </summary>
    * 
    * */
        public int Niveau
        {
            get { return niveau; }
            set { this.niveau = value; }
        }
        /**
    *  <summary> Musique définie quel musique est jouer pendant la partie sachant qu'il y a que 3 musique.
    *  </summary>
    * 
    * */
        public int Musique
        {
            get { return musique; }
            set { this.musique = value; }
        }

        /**
    *  <summary>nbrLigne définie le nombre de ligne détruite depusi le debut de la partie de tétris.
    *  </summary>
    * 
    * */
        public int NbrLigne
        {
            get { return nbrLigne; }
            set { this.nbrLigne = value; }
        }


        /**
    *  <summary>Cette fonction permet de créer un pièce aléatoirement dans la plage des pièces à charger.
    *  </summary>
* <param name=rndNumber>parametre qui correspont à un seed aléatoire et qui permet d'avoir un nombre aléatoire</param>
 * <returns>Renvoie une pièce créer aléatoirement</returns>
    * */
        public piece randPiece(Random rndNumber)
        {

            return new piece(0, 0, rndNumber.Next(nbrPiece));
        }
        /**
    *  <summary>Cette fonction permet de lancer une partie.Et de créer la première pièce.
    *  </summary>
    * */
 
        public void start()
        {
            Random rndNumber = new Random();
            puit.setPieceEnCour(randPiece(rndNumber));
            pieceSuivante.setPieceEnCour(randPiece(rndNumber));
            puit.placerPiece();
            pieceSuivante.placerPiece();


        }
        /**
    *  <summary>Cette fonction permet d'afficher la partie sur l'ecran en dessinant dessus.
    *  </summary>
* <param name=graphicsObj>parametre qui correspont à l'ecran graphics qui permet de dessiner dessus</param>
    * */
        public void affichage( Graphics graphicsObj)
        {
            int colorier = 0;
            BufferedGraphics bg = BufferedGraphicsManager.Current.Allocate(graphicsObj, new Rectangle(0, 30,660, 600));
            graphicsObj = bg.Graphics;
            graphicsObj.Clear(Color.White);
            graphicsObj.DrawImage(Image.FromFile("./image/trollFace.png"), new Rectangle(0, 30, 660, 600), 0, 0, 660, 600, GraphicsUnit.Pixel);
            graphicsObj.DrawImage(Image.FromFile("./image/fond.jpg"), new Rectangle(20,50, 200, 440), 0, 0, 200, 440, GraphicsUnit.Pixel);
            
            SolidBrush myBrush = new SolidBrush(Color.Red);
            SolidBrush myBrush2 = new SolidBrush(Color.White);
            Pen myPen = new Pen(Color.Black, 4);
            @case[][] tableauTemp = pieceSuivante.getPieceEncour().getTableau();

            graphicsObj.DrawRectangle(myPen, new Rectangle(20, 50, 200, 440));
            graphicsObj.DrawRectangle(myPen, new Rectangle(400, 40, 80, 80));
            graphicsObj.DrawRectangle(myPen, new Rectangle(500, 470, 60, 60));
            if (bonus != -1)
            {
                graphicsObj.DrawImage(Image.FromFile("./image/image" + bonus + ".jpg"), new Rectangle(500, 470, 60, 60), 0, 0, 60, 60, GraphicsUnit.Pixel);

            }
            int i, j;


            for (i = 0; i < puit.Hauteur; i++)
            {
                for (j = 0; j < puit.Largeur; j++)
                {
                    
                    if (bonus == 4 && colorier ==1)
                    {
                        myBrush.Color = Color.Black;
                        colorier = 0;
                        graphicsObj.FillRectangle(myBrush, new Rectangle(20 + j * 20, 50 + i * 20, 20, 20));
                        graphicsObj.DrawRectangle(myPen, new Rectangle(20 + j * 20, 50 + i * 20, 20, 20));
                    }
                    else
                    {
                        if (puit.getCase(i, j) == 1)
                        {
                            switch (puit.getCaseColor(i, j))
                            {
                                case 0: myBrush.Color = Color.Green;
                                    break;
                                case 1: myBrush.Color = Color.Cyan;
                                    break;
                                case 2: myBrush.Color = Color.Red;
                                    break;
                                case 3: myBrush.Color = Color.Blue;
                                    break;
                                case 4: myBrush.Color = Color.Orange;
                                    break;
                                case 5: myBrush.Color = Color.Magenta;
                                    break;
                                case 6: myBrush.Color = Color.Gray;
                                    break;
                                case 7: myBrush.Color = Color.Chartreuse;
                                    break;
                                case 8: myBrush.Color = Color.BlueViolet;
                                    break;
                                case 9: myBrush.Color = Color.LawnGreen;
                                    break;
                                case 10: myBrush.Color = Color.Khaki;
                                    break;
                                default: myBrush.Color = Color.Black;
                                    break;
                            }
                            graphicsObj.FillRectangle(myBrush, new Rectangle(20 + j * 20, 50 + i * 20, 20, 20));
                            graphicsObj.DrawRectangle(myPen, new Rectangle(20 + j * 20, 50 + i * 20, 20, 20));
                        }
                        colorier = 1;
                    }
                    
                
                 }
            }
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (tableauTemp[i][j].Pleine == 1)
                    {
                        switch (tableauTemp[i][j].Color)
                        {
                            case 0: myBrush.Color = Color.Green;
                                break;
                            case 1: myBrush.Color = Color.Cyan;
                                break;
                            case 2: myBrush.Color = Color.Red;
                                break;
                            case 3: myBrush.Color = Color.Blue;
                                break;
                            case 4: myBrush.Color = Color.Orange;
                                break;
                            case 5: myBrush.Color = Color.Magenta;
                                break;
                            case 6: myBrush.Color = Color.Gray;
                                break;
                            case 7: myBrush.Color = Color.Chartreuse;
                                break;
                            case 8: myBrush.Color = Color.BlueViolet;
                                break;
                            case 9: myBrush.Color = Color.LawnGreen;
                                break;
                            case 10: myBrush.Color = Color.Khaki;
                                break;
                            default: myBrush.Color = Color.Black;
                                break;


                        }
                        graphicsObj.FillRectangle(myBrush, new Rectangle(400 + j * 20, 40 + i * 20, 20, 20));
                        graphicsObj.DrawRectangle(myPen, new Rectangle(400 + j * 20, 40 + i * 20, 20, 20));

                    }
                }
            }

            graphicsObj.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(300, 350, 280, 100));
            graphicsObj.FillRectangle(new SolidBrush(Color.White), new Rectangle(300, 350, 280, 100));
            string drawString = "Niveau : " + Niveau;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 20);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            graphicsObj.DrawString(drawString, drawFont, drawBrush, 300, 350);
            drawString = "Score : " + Score;
            graphicsObj.DrawString(drawString, drawFont, drawBrush, 300, 380);
            drawString = "Nombres de ligne : " + NbrLigne;
            graphicsObj.DrawString(drawString, drawFont, drawBrush, 300, 410);
            // Affichage du buffer à l'écran
            bg.Render();
            // On libère les objets graphique
            bg.Dispose();
            graphicsObj.Dispose();
        }
        /**
    *  <summary>Cette fonction qui déplace la pièce vers le bas et si la pièce touche le bas de l'écran.
    *  </summary>
* <param name=timer1>parametre qui correspont au timer principale du jeux</param>
         * <returns> Renvoie un entier : 1 si fin de la partie et 0 autrement </returns>
    * */
        public int deplacerTimer( System.Windows.Forms.Timer timer1)
        {
            if (puit.testDeplacementPiece(3) == 3)
            {
                puit.deplacerPiece( 1, 0);
                return 0;
            }
            else
            {
                if (puit.testFinJeux() == 1)
                {
                    return 1;

                }
                timer1.Interval = timer;
                placementPiece();
                puit.setPieceEnCour(pieceSuivante.getPieceEncour());
                Random rndNumber = new Random();
                pieceSuivante.supprimerPiece();
                pieceSuivante.setPieceEnCour(randPiece(rndNumber));
                puit.placerPiece();
                pieceSuivante.placerPiece();
                return 0;
            }
        }
        /**
    *  <summary>Cette fonction va appeler la fonction  deplacer pour les déplacements latéraux  en fonction du test éffectuer et du sens envoyer
         *  en paramètre.
    *  </summary>
* <param name=sens>parametre qui correspont sens où on veux déplacer la pièce</param>
    * */
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
        }
        /**
    *  <summary>Cette fonction va appeler la fonction rotation pour les rotations  en fonction du test éffectuer et du sens envoyer
         *  en paramètre.
    *  </summary>
* <param name=sens>parametre qui correspont sens où on veux tourner la pièce</param>
    * */
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

        }
        /**
    *  <summary>Cette fonction va gerer les actions quand une ligne va étre complété en contant le nombre de lignes complète et en augementant 
         *  le score en conséquence.
    *  </summary>
    * */
        public void placementPiece()
        {
            int compteur = 0;
            int i=puit.Hauteur -1;
            while (i>-1 && puit.testLigneVide(i) == false)
            {
                if (puit.testFinligne(i) == true)
                {
                    puit.descendrePiece(i);
                    compteur++;
                    
                    i++;
                   
                }
                i--;
            }

                switch (compteur)
                {
                    case 1: score += 40*(niveau+1);
                        nbrLigne++;
                        break;
                    case 2: score += 100 * (niveau + 1);
                        nbrLigne += 2;
                        break;
                    case 3: score += 300 * (niveau + 1);
                        nbrLigne += 3;
                        break;
                    case 4: score += 1200 * (niveau + 1);
                        nbrLigne += 4;
                        break;
                }
                if (bonus == 4 && compteur !=0)
                {
                    score += 1000;

                }
           while(score >1500*niveau+100)
            {
                niveau++;
            }
      }
        /**
    *  <summary>Cette fonction va gerer l'action du Bonus Bomb en détruisant 6 cases aléatoirement sur le puit.
         *  <param name=centreBombeX>parametre qui correspont au coordonnée verticale du centre de la détruction</param>
         *  <param name=centreBombeY>parametre qui correspont au coordonnée horizontale du centre de la détruction</param>
    *  </summary>
    * */
        public void bomb(int centreBombeX, int centreBombeY)
        {
            int tempX = centreBombeX+3;
            int tempY = centreBombeY+3;
            if (centreBombeX + 3 > 22)
                tempX = centreBombeX + 3 -( 22 - centreBombeX + 3);
            if (centreBombeY + 3 > 10)
                tempY = centreBombeY + 3 - (10 - centreBombeY + 3);

            for (int i = centreBombeX; i < tempX; i++)
            {
                for (int j = centreBombeY; j < tempY; j++)
                {

                    puit.setCase(i, j, 0);

                }


            }

        }
        /**
    *  <summary>Cette fonction va gerer l'action du Bonus ajout ligne en appelant la fonction ajoutLigne.
         *  <param name=nbrDeCase>parametre qui correspont à la case a laisser pleine</param>
    *  </summary>
    * */
        public void ajoutLigne(int nbrDeCase)
        {
            puit.ajoutLigne(nbrDeCase);

        }
           
    }
}
