using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;


namespace Autoskola
{
    class Kategorija
    {
        
        public string kategorijaID { get; set; }

        public Kategorija() { }

        /// <summary>
        /// Metoda za pohranu unosa nove kategorije vozila u bazu
        /// </summary>
        /// <returns></returns>
        public int PohraniUnos()
        {

            string sqlUpit = "INSERT INTO kategorija (kategorijaID) VALUES ('" + kategorijaID + "');";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
    }
}
