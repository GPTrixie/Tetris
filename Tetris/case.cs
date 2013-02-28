using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    class @case
    {
        private Boolean pleine;
        private int x;
        private int y;


        public @case() { }
        public @case(int x,int y) {
            pleine = false;
            this.x=x;
            this.y=y;

        }

        public Boolean Pleine
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
