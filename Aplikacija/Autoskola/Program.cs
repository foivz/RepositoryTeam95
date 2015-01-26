using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace Autoskola
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlavnaForma glavna = new GlavnaForma();
            Application.Run(glavna);
           //Application.Run(new GlavnaForma());
            
        }
    }
}
