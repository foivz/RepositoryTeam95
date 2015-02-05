using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;


namespace Autoskola
{
    class Ugovor
    {
        public string stavke { get; set; }
        public string OIBP { get; set; }
        public string Instruktor { get; set; }
        public string kategorijaID { get; set; }

        public Ugovor() { }

        /// <summary>
        /// Metoda za unos stavki u tablicu Ugovor
        /// </summary>
        /// <returns></returns>
        public int UnesiUgovor()
        {
            string upit = "INSERT INTO ugovor (stavke, OIBP, Instruktor, kategorijaID) VALUES ('" + stavke + "', '" + OIBP + "','" + Instruktor + "', '" + kategorijaID + "'); ";
            return DB.Instance.IzvrsiUpit(upit);
        }

        public int AzurirajUgovor(string oib)
        {
            string sqlUpit = "UPDATE ugovor SET kategorijaID = '" + kategorijaID + "' WHERE OIBP = '" + oib + "'; ";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
    }
}
