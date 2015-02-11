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
        public static _0frmGlavnaForma _0frmGlavnaForma
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _0frmGlavnaForma glavna = new _0frmGlavnaForma();
            Application.Run(glavna);
           //Application.Run(new GlavnaForma());
            
        }
    }
}
