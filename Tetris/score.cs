using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tetris
{
    /**
    *  <summary> Classe Score est une classe héritier de la classe Form qui permet de gérer l'affichage du tableau de score.
    *  </summary>
    * 
    * */
    public partial class score : Form
    {
        public score()
        {
            InitializeComponent();
        }

        private void score_Load(object sender, EventArgs e)
        {
            StreamReader infile = File.OpenText("./doc/score");
            string[] temp;
            temp = infile.ReadLine().Split(' ');
            sp1.Text = temp[0];
            sc1.Text = temp[3];
            nv1.Text = temp[6];
            temp = infile.ReadLine().Split(' ');
            sp2.Text = temp[0];
            sc2.Text = temp[3];
            nv2.Text = temp[6];
            temp = infile.ReadLine().Split(' ');
            sp3.Text = temp[0];
            sc3.Text = temp[3];
            nv3.Text = temp[6];
        }
    }
}
