using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoskola
{
    class Evidencija
    {
        public TimeSpan vrijemeP { get; set; }
        public TimeSpan vrijemeK { get; set; }
        public int voziloID { get; set; }
        public string OIBP { get; set; }
        public string OIBI { get; set; }
        public DateTime datum { get; set; }

        public Evidencija() { }

        /// <summary>
        /// Metoda za pohranu unosa novih evidencija u bazu
        /// </summary>
        /// <returns></returns>
        public int PohraniUnos()
        {
            string sqlUpit = "INSERT INTO evidencija (vrijemeP, vrijemeK, voziloID, OIBP, OIBI, datum) VALUES ('" + vrijemeP + "', '" + vrijemeK + "','" + voziloID + "','" + OIBP + "','" + OIBI + "' , '" + datum  + "');";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
    }
}
