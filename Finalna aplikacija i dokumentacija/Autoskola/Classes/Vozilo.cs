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
    class Vozilo
    {
        public string naziv { get; set; }
        public string kategorijaVozila { get; set; }
        
        public Vozilo()
        {
           
        }

        /// <summary>
        /// Metoda za pohranu unosa novog vozila u bazu
        /// </summary>
        /// <returns></returns>
        public int PohraniUnos() 
        {
            string sqlUpit = "INSERT INTO vozilo (naziv, kategorijaVozila) VALUES ('" + naziv + "', '"+ kategorijaVozila +"');";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Metoda za brisanje vozila iz baze
        /// </summary>
        /// <param name="IDvozila"></param>
        /// <returns></returns>
        public int ObrisiVozilo(int IDvozila)
        {
            string upitBrisi = "DELETE FROM vozilo WHERE voziloID = '" + IDvozila + "';";
            return DB.Instance.IzvrsiUpit(upitBrisi);

        }

    }
}
