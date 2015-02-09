using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SQLite;

namespace Autoskola
{
    public partial class _12frmPodaciOPol : Form
    {
        public _12frmPodaciOPol()
        {
            InitializeComponent();
        }

        //Back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _09frmEvidencijaPol forma = new _09frmEvidencijaPol();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _12aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Upis u dataGridView prilikom loadanja forme
        private void _12frmPodaciOPol_Load(object sender, EventArgs e)
        {

            string upitOsoba = "SELECT * FROM osoba WHERE OIB = '" + _09frmEvidencijaPol.OIBP + "';";
            DbDataReader drOsoba = DB.Instance.DohvatiDataReader(upitOsoba);
            string oibOsoba = drOsoba[0].ToString();

            string upitUgovor = "SELECT * FROM ugovor;";
            DbDataReader drUgovor = DB.Instance.DohvatiDataReader(upitUgovor);

            string upitVoznja = "SELECT * FROM evidencija WHERE OIBP = '" + oibOsoba + "';";
            DbDataReader drVoznja = DB.Instance.DohvatiDataReader(upitVoznja);

            DateTime razlika = new DateTime();

            DateTimeConverter cnv = new DateTimeConverter();
            

            while (drVoznja.Read()) 
            {
                DateTime pocetnoVrijeme = (DateTime)cnv.ConvertFromString(drVoznja[0].ToString());
                DateTime ZavrsnoVrijeme = (DateTime)cnv.ConvertFromString(drVoznja[1].ToString());

                razlika = razlika.Add(ZavrsnoVrijeme.Subtract(pocetnoVrijeme));
            }


            dgvPodaci.Rows.Add(drOsoba[0].ToString(), drOsoba[1].ToString(), drOsoba[2].ToString(),drUgovor[3].ToString(), razlika.ToString("HH:mm:ss"));

        }
       


        
    }
}
