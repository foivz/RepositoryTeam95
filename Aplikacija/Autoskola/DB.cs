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
            ConnectionString = @"Data Source = autoskolaDB.db3"; 
            //promijniti ako premjestimo bazu, zasad neka tu bude

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




    }
}
