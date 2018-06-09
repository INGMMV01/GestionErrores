﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new Form1());
            }
            catch(LogicalException e)
            {
                MessageBox.Show(e.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
