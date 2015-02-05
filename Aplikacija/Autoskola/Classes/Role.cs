using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;
using System.Windows.Forms;

namespace Autoskola
{
    class Role
    {
        public string kIme { get; set; }
        public string lozinka { get; set; }
        public int roleID { get; set; }
        public string OIB { get; set; }

        public Role() { }

        /// <summary>
        /// POhrana ako je roleID 1 ili 2, za admina i instruktora
        /// </summary>
        /// <returns></returns>
        public int PohraniUnos()
        {
            
            string upit = "INSERT INTO role (kIme, lozinka, OIB, roleID) VALUES ('" + kIme + "', '" + lozinka + "','" + OIB + "','" + roleID + "');";
            return DB.Instance.IzvrsiUpit(upit);

        }

        /// <summary>
        /// Pohrana ako je roleID 3, za polaznika, nema unosa korisničkog imena i lozinke
        /// </summary>
        /// <returns></returns>
        public int PohraniUnosPolaznika()
        {
            string upit = "INSERT INTO role (OIB, roleID) VALUES ('" + OIB + "','" + roleID + "');";
            return DB.Instance.IzvrsiUpit(upit);
        }

        public int PohraniAzuriranjeRole(string oib)
        {
            string sqlUpit = "UPDATE role SET kIme = '" + kIme + "', lozinka ='" + lozinka + "' WHERE OIB = '" + oib + "'; ";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
    }
}
