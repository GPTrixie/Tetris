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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void start_Click(object sender, EventArgs e)
        {
            Tetris test =new  Tetris();
            this.Hide();
            test.Show();
            test.Jouer(12);
            
        }

        
    }
}
