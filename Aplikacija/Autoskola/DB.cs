using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;

namespace Autoskola
{
    class DB
    {
        private static DB instance; //Singleton
        private string connectionString; //Putanja za spajanje
        private SQLiteConnection spajanje; //konekcija

        public static DB Instance 
        {
            get 
            {
                if (instance == null) { instance = new DB(); }
                return instance;
            }

        }
        
        public string ConnectionString 
        {
            get { return connectionString; }
            private set {connectionString = value; }
        }

        public SQLiteConnection Connection 
        {
            get { return spajanje; }
            private set { spajanje = value; }
        }
        
        //konstruktor i destruktor

        private DB() 
        {
            //datoteka s bazom u bin-->Debug direktoriju aplikacije
            ConnectionString = @"Data Source = autoskolaDB.db3"; 
            Connection = new SQLiteConnection(ConnectionString);
            Connection.Open();

        }

        ~DB() 
        {
            Connection.Close();
            Connection = null;
        }

        
        //metode za dohvat podataka i izvršenje upita

        public DbDataReader DohvatiDataReader (string sqlUpit)
        {
            SQLiteCommand naredba = new SQLiteCommand(sqlUpit, Connection);
            return naredba.ExecuteReader();

        }

        public object DohvatiVrijednost(string sqlUpit) 
        {
            SQLiteCommand naredba = new SQLiteCommand(sqlUpit, Connection);
            return naredba.ExecuteScalar();
        }

        public int IzvrsiUpit(string sqlUpit) 
        {
            SQLiteCommand naredba = new SQLiteCommand(sqlUpit, Connection);
            return naredba.ExecuteNonQuery();
        }


        
        public Osoba prijavljenaOsoba;

        /// <summary>
        /// Metoda za čuvanje podataka o osobi od logina. 
        /// </summary>
        /// <param name="kIme"></param>
        /// <param name="lozinka"></param>
        public void prijava(string kIme, string lozinka)
        {
            string upit = "SELECT * FROM role WHERE kIme = '" + kIme + "' AND lozinka = '" + lozinka + "';";

            DbDataReader reader = DB.Instance.DohvatiDataReader(upit);
            reader.Read();
            string OIB = reader[2].ToString();

            upit = "SELECT * FROM osoba WHERE OIB = '" + OIB + "';";
            reader = DB.Instance.DohvatiDataReader(upit);
            reader.Read();

            prijavljenaOsoba = new Osoba();
            prijavljenaOsoba.OIB = OIB;
            prijavljenaOsoba.ime = reader[1].ToString();
            prijavljenaOsoba.prezime = reader[2].ToString();
            prijavljenaOsoba.adresa = reader[3].ToString();
            prijavljenaOsoba.brTel = reader[4].ToString();



        }
    }
}
