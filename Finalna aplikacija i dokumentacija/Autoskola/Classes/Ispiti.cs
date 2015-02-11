using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SQLite;


namespace Autoskola
{
    class Ispiti
    {
        
        public int ispitID { get; set; }
        public bool prolaz { get; set; }
        public DateTime datum { get; set; }
        public string napomena { get; set; }
        public string OIBP { get; set; }
        

        public Ispiti() { }

        /// <summary>
        /// Metoda za pohranu ispita koji se polažu
        /// </summary>
        /// <returns></returns>
        public int PohraniPolaganjeIspita(string OIBP) 
        {
            string upit = "INSERT INTO polaganje (datum, prolaz, napomena, ispitID, OIBP) VALUES ('" + datum + "', '" + prolaz + "','" + napomena + "','" + ispitID + "','" + OIBP + "');";
            return DB.Instance.IzvrsiUpit(upit);
        }


    }
}
