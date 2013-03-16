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
    public partial class Menu : Form
    {
        /**
    *  <value> Classe case comprenant les coordonnées,la couleur et si elle est pleine
    *  </value>
    * 
    * */
        public int musique;
        /**
    *  <summary> Classe case comprenant les coordonnées,la couleur et si elle est pleine
    *  </summary>
    * 
    * */
        public Menu()
        {
            InitializeComponent();

        }

        private void start_Click(object sender, EventArgs e)
        {
            Tetris test =new  Tetris();
            
            int a;
             try
            {
               a = int.Parse(Niveau.Text);
               this.Hide();
               test.Show();
               test.Jouer(musique,a);
              
            }
            catch(Exception ex)
            {
                erreur.Show();
            }
           
           

            // close application
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            musique = 1;
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            musique = 2;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            musique = 3;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Red;
        }

        
    }
}
