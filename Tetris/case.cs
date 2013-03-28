using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    /**
     *  <summary> La classe case définie si un carré est remplit ou pas à des certaines coordonés
     *  </summary>
     * 
     * */
    class @case
    {
        /**
     *  <summary> La variable plein définie si la cases est vide ou pas elle varie entre les valeurs 0 et 1
     *  </summary>
     * 
     * */
        private int pleine;
        /**
     *  <summary> La variable x définie les coordonnées selon la hauteur
     *  </summary>
     * 
     * */
        private int x;
        /**
     *  <summary> La variable y définie les coordonnées selon la largeur
     *  </summary>
     * 
     * */
        private int y;
        /**
     *  <summary> La variable color définit la couleur de la case qui est définit selon un entier de 0 à 8 corespondant au type de piece 
     *  </summary>
     * 
     * */
        private int color;
        /**
     *  <summary> Constructeur par défaut
     *  </summary>
     * 
     * */
        public @case() { }
        /**
     *  <summary> Constructeur qui construit une case aux coordonnées données
     *  </summary>
     * 
         * <param name=x>parametre qui correspont à sa position verticale</param>
         * <param name=y>parametre qui correspont à sa position horizontale</param>
     * */
        public @case(int x,int y) 
        {
            pleine = 0;
            this.x=x;
            this.y=y;
        }
        /**
    *  <summary> Cela permettera a acceder si la case est remplit ou pas se qui serfira pour les tests et pour afficher à l'écran
    *  </summary>
    * 
    * */
        public int Pleine
        {
            get{return pleine;}
            set{this.pleine = value;}
        }
        /**
    *  <summary> Cela permettera a acceder à la couleur de la case.
    *  </summary>
    * 
    * */
        public int Color
        {
            get { return color; }
            set { this.color = value; }
        }
        /**
    *  <summary> La variable x définie les coordonnées selon la hauteur
    *  </summary>
    * 
    * */
        public int X 
        {
            get { return x; }
            set { this.x = value; }
        }
        /**
     *  <summary> La variable y définie les coordonnées selon la largeur
     *  </summary>
     * 
     * */
        public int Y
        {
            get { return y; }
            set { this.y = value; }
        }


    }
}
