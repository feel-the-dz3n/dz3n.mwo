using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dz3n.MWO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //if (DateTime.Now >= new DateTime(2018, 10, 12, 00, 00, 00))
            //{ 
            //    MessageBox.Show("Testing period expired. Please, contact Dz3n to get new build\n\nfuck you ;)", "Dz3n.MWO");
            //    Environment.Exit(0);
            //}
            //else
            //{

            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
