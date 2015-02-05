using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoskola
{
    class Osoba
    {
        public string OIB { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa { get; set; }
        public string brTel { get; set; }
 
        public Osoba() 
        { }

        /// <summary>
        /// Metoda za pohranu unosa novih polaznika u bazu
        /// </summary>
        /// <returns></returns>
        public int PohraniUnos()
        {
            string sqlUpit = "INSERT INTO osoba (OIB, ime, prezime, adresa, brTel) VALUES ('" + OIB + "', '" + ime + "','" + prezime + "','" + adresa + "','" + brTel + "');";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Metoda za azuriranje podataka u tablicu Osoba
        /// </summary>
        /// <returns></returns>
        public int AzurirajUnos(string oib)
        {
            
            string sqlUpit = "UPDATE osoba SET ime = '" + ime + "', prezime ='" + prezime + "', adresa ='" + adresa + "', brTel ='" + brTel + "' WHERE OIB = '" + oib + "'; ";
            return DB.Instance.IzvrsiUpit(sqlUpit);

        }

        
    }
}
