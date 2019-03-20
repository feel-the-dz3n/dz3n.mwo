/* 
   PROJECT:     Most Wanted Online -> Launcher
   LICENSE:     (See it on GitHub page)
   FILE:        Program.cs
   DESCRIPTION: Program initialization and entry point
   PROGRAMMERS: Yaroslav Kibysh (2018 - 2019)
   GITHUB:      https://github.com/feel-the-dz3n/dz3n.mwo
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dz3n.MWO
{
    static class Program
    {
        public static DotNetTranslator.AvailableTranslations Translation;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Translation = Dz3n.MWO.Translation.Builder.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
