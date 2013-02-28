using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    class partie
    {
        private int score;
        private int niveau;
        private int temp; // en seconde ? 
        private int musique;
        private espace pieceSuivante;
        private espace puit;

        public partie(int musique)
        {
            score = 0;
            temp = 0;
            niveau = 0;
            this.musique = musique;
            puit = new espace(); // taille de l'écrand de jeux
            pieceSuivante = new espace(); // taille des carré des pieces

        }
        public int Score
        {
            get { return score; }
            set { this.score = value; }
        }
        public int Niveau
        {
            get { return Niveau; }
            set { this.Niveau = value; }
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
        
    }
}
