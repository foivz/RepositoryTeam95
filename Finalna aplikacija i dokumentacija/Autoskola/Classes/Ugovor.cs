using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;
using System.IO;




namespace Autoskola
{
    class Ugovor
    {
        
        public string OIBP { get; set; }
        public string Instruktor { get; set; }
        public string kategorijaID { get; set; }
        public string fileName { get; set; }

        public Ugovor() { }

        /// <summary>
        /// Metoda za unos stavki u tablicu Ugovor
        /// </summary>
        /// <returns></returns>
        public int UnesiUgovor()
        {
            string upit = "INSERT INTO ugovor (OIBP, Instruktor, kategorijaID) VALUES ('" + OIBP + "','" + Instruktor + "', '" + kategorijaID + "'); ";
            return DB.Instance.IzvrsiUpit(upit);
        }

        /// <summary>
        /// Metoda za pohranu promjena podataka u bazu
        /// </summary>
        /// <param name="oib"></param>
        /// <returns></returns>
        public int AzurirajUgovor(string oib)
        {
            string sqlUpit = "UPDATE ugovor SET kategorijaID = '" + kategorijaID + "' WHERE OIBP = '" + oib + "'; ";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }


        /// <summary>
        /// Metoda za generiranje ugovora novom polazniku na temelju Word templatea
        /// </summary>
        /// <param name="datoteka"></param>
        /// <param name="saveAs"></param>
        public static void OtvoriWordUgovor(string ime, string prezime, string adresa, string OIB, string kategorija)
        {
            string dat = "\\Ugovor_" + prezime + ".docx";
            
            dat = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + dat;

         
            if (File.Exists(dat))
                File.Delete(dat);

            File.WriteAllBytes(dat, Properties.Resources.Ugovor);


            object missing = System.Reflection.Missing.Value;
            object refDat = (object)dat;

            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();

            Microsoft.Office.Interop.Word.Document dokument = null;

           
                DateTime danas = DateTime.Now;
                object readOnly = false;
                object isVisible = true;

                app.Visible = true;

                //otvaranje i aktiviranje
                dokument = app.Documents.Open(ref refDat, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing, ref missing);
                dokument.Activate();

                //upis
                dokument.Content.InsertBefore("Ime i prezime: " + ime + " " + prezime + "\r\n" + "Adresa: " + adresa + "\r\n" + "OIB: " + OIB + "\r\n" + "Kategorija: " + kategorija);
                dokument.Content.InsertAfter(danas.ToString());

                //Pohrana upisa i zatvaranje datoteke
                dokument.SaveAs2(ref refDat, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            

            MessageBox.Show("Uspješno pohranjen dokument.");



        }

    }
}
