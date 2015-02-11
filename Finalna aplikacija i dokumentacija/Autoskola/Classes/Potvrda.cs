using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoskola
{
    class Potvrda
    {
        public Potvrda() 
        {
        
        }

        /// <summary>
        /// Metoda za generiranje nove potvrde iz postojećeg templatea
        /// </summary>
        /// <param name="ime"></param>
        /// <param name="prezime"></param>
        /// <param name="adresa"></param>
        /// <param name="OIB"></param>
        /// <param name="kategorija"></param>
        public static void OtvoriWordPotvrda(string ime, string prezime, string adresa, string OIB, string kategorija)
        {
            string dat = "\\Potvrda_" + prezime + ".docx";
            dat = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + dat;

            if (File.Exists(dat))
                File.Delete(dat);

            File.WriteAllBytes(dat, Properties.Resources.Potvrda);


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
            dokument.Content.InsertAfter("Ime i prezime: " + ime + " " + prezime + "\r\n" + "Adresa: " + adresa + "\r\n" + "OIB: " + OIB + "\r\n" + "Kategorija: " + kategorija + "\n\n\n\nU Varaždinu, " + danas.ToString());

            //Pohrana upisa i zatvaranje datoteke
            dokument.SaveAs2(ref refDat, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);

            MessageBox.Show("Uspješno pohranjen dokument.");

        }
    }
}
