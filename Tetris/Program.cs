using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tetris
{
    
    /// <summary>
    /// La classe programme est la première classe lancé dans le logiciel qui gère les forms au démarache .
    /// </summary>
    /// <@author> Lucas</@author>
    static class Program
    {
        /// <summary>
        /// Action principal du programme qui lance le form Menu.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());

            Application.Exit();
        }
    }
}
