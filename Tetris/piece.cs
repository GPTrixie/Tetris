using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    class piece
    {
        private @case centre;
        private @case[][] tableau;
        private int type;

        public piece() { }
        public piece(int type,int x,int y)// mettre des coordonnées pour le centre cette fct sert de chargement de piece
        {
            this.type=type;
            this.centre=new @case(x,y); // le rajuté la 
            switch(type) // traitement des different cas de piece et chargement des pieces 
            {


            }

        }

        public int Type
        {
            get { return type; }
            set { this.type = value; }
        }

        void deplacerPiece(@case centreBis)
        {


        }
        void rotationPiece(int sens)
        {


        }

    }
}
