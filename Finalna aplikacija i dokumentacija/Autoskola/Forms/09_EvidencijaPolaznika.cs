using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoskola
{
    public partial class _09frmEvidencijaPol : Form
    {
        public _09frmEvidencijaPol()
        {
            InitializeComponent();
        }

        public static string OIBP;
        
        //Gumb Evidentiraj polaznika
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OIBP = dgwEvidencijaPol.SelectedRows[0].Cells[0].Value.ToString(); 
            _10frmPodaciOVoznji forma = new _10frmPodaciOVoznji();
            this.Hide();
            forma.Show();
        }

        //Gumb za dohvat starih podataka
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OIBP = dgwEvidencijaPol.SelectedRows[0].Cells[0].Value.ToString();  
            _12frmPodaciOPol forma = new _12frmPodaciOPol();
            this.Hide();
            forma.Show();
        }

        //Back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _01frmWelcomeInstruktor forma = new _01frmWelcomeInstruktor();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _9aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Popis polaznika dodijeljenih ugovorm u dgw-u za odabir daljnjih podataka o vožnji
        private void _09frmEvidencijaPol_Load(object sender, EventArgs e)
        {
            string instrOIB = DB.Instance.prijavljenaOsoba.OIB;
            string instrIme = DB.Instance.prijavljenaOsoba.ime;
            string instrPrezime = DB.Instance.prijavljenaOsoba.prezime;
            string instruktor = instrIme + " " + instrPrezime;


            //upit iz ugovora za oibOsobe
            string upit1 = "SELECT * FROM ugovor WHERE Instruktor = '" + instruktor + "';";
            DbDataReader datareader = DB.Instance.DohvatiDataReader(upit1);
           
            while (datareader.Read())
            {
                string oibUgovor = datareader[2].ToString();

                string upit = "SELECT * FROM osoba;";
                DbDataReader dr = DB.Instance.DohvatiDataReader(upit);
                while (dr.Read())
                {

                    string oibOsoba = dr[0].ToString();

                    if (oibUgovor == oibOsoba)
                    {

                        dgwEvidencijaPol.Rows.Add(dr[0], dr[1], dr[2]);

                    }
                }
            }
                
        }




    }
}
