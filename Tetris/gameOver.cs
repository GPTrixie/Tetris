using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tetris
{
    /**
    *  <summary> Classe case comprenant les coordonnées,la couleur et si elle est pleine
    *  </summary>
    * 
    * */
    public partial class gameOver : Form
    {

        /**
        *  <summary> Classe case comprenant les coordonnées,la couleur et si elle est pleine
        *  </summary>
        * 
        * */
        public gameOver(int score,int niveau)
        {
            InitializeComponent();
            label2.Text = "Score : " + score;
            label3.Text = "Niveau : " + niveau;
            
        }

        private void gameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

       
    }
}
