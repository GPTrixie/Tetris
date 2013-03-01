using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    class @case
    {
        private int pleine;
        private int x;
        private int y;


        public @case() { }

        public @case(int x,int y) 
        {
            pleine = 0;
            this.x=x;
            this.y=y;
        }

        public int Pleine
        {
            get{return pleine;}
            set{this.pleine = value;}
        }
        public int X 
        {
            get { return x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return y; }
            set { this.y = value; }
        }


    }
}
