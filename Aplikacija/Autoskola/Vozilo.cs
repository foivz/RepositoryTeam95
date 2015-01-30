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
        
        public Vozilo()
        {
           
        }

        /// <summary>
        /// Metoda za pohranu unosa novog vozila u bazu
        /// </summary>
        /// <returns></returns>
        public int PohraniUnos() 
        {
           
            string sqlUpit = "INSERT INTO vozilo (naziv) VALUES ('" + naziv + "');";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Metoda za brisanje vozila iz tablice u bazi
        /// </summary>
        /// <returns></returns>
        public int ObrisiVozilo() 
        {   
            _6aForma forma = new _6aForma();
            string ID = forma.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//sere to
            string upitBrisi = "DELETE FROM vozilo WHERE voziloID = '" + ID + "';";
            return DB.Instance.IzvrsiUpit(upitBrisi);
        }
    }
}
