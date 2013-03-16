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
    *  <summary> Classe case comprenant les coordonnées,la couleur et si elle est pleine
    *  </summary>
    * 
    * */
    class partie
    {
        private int score;
        private int niveau;
        private int temp; // en seconde ? 
        private int musique;
        private espace pieceSuivante;
        private espace puit;

        public partie(int musique,int niveau)
        {
            score = 0;
            temp = 0;
            this.niveau = niveau;
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
            get { return niveau; }
            set { this.niveau = value; }
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

            return new piece(0, 0, rndNumber.Next(8));
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
            SolidBrush myBrush = new SolidBrush(Color.Black);
            SolidBrush myBrush2 = new SolidBrush(Color.White);
            Pen myPen = new Pen(Color.Black, 2);
            @case[][] tableauTemp = pieceSuivante.getPieceEncour().getTableau();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
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
                            case 7: myBrush.Color = Color.Gold;
                                break;
                            default: myBrush.Color = Color.Black;
                                break;
    

                        }
                        graphicsObj.FillRectangle(myBrush, new Rectangle(402+i*20, 12+j*20, 20, 20));
                        graphicsObj.DrawRectangle(myPen, new Rectangle(402 + i * 20, 12 + j * 20, 20, 20));
                    
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
            Pen myPen = new Pen(Color.Black, 2);
            
            for (int i = 0; i < puit.Hauteur; i++)
            {
                for (int j = 0; j < puit.Largeur; j++)
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
                            case 7: myBrush.Color = Color.Gold;
                                break;
                            default: myBrush.Color = Color.Black;
                                break;


                        }
                        graphicsObj.FillRectangle(myBrush, new Rectangle(12 + j * 20, 12 + i * 20, 20, 20));
                        graphicsObj.DrawRectangle(myPen, new Rectangle(12 + j * 20, 12 + i * 20, 20, 20));
                    
                    }
                    else
                    {
                        graphicsObj.FillRectangle(myBrush2, new Rectangle(12 + j * 20, 12 + i * 20, 20, 20));
                    }
                }
            }
        }

        public int deplacerTimer(int vitesse, System.Windows.Forms.Timer timer1)
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
                
                timer1.Interval = 1000 - niveau*80; //changer par rapport a la vitesse
                placementPiece();
                puit.setPieceEncour(pieceSuivante.getPieceEncour());
                Random rndNumber = new Random();
                pieceSuivante.supprimerPiece();
                pieceSuivante.setPieceEncour(randPiece(rndNumber));
                puit.placerPiece();
                pieceSuivante.placerPiece();
                return 0;
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
            int compteur = 0;
            int i=puit.Hauteur -1;
            while (puit.testLigneVide(i) == false && i>-1)
            {
                if (puit.testFinligne(i) == true)
                {
                    puit.descendrePiece(i);
                    compteur++;
                    
                    i++;
                   
                }
                i--;
            }
            if (compteur != 0)
            {
                score += 10 * niveau*compteur;
               while (score > 10 * niveau * 4)
                {
                    niveau++;
                }
            }
            }

           
    }
}
