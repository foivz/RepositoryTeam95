using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;

namespace Autoskola
{
    public partial class _11frmIzdavanjePotvrde : Form
    {
        public _11frmIzdavanjePotvrde()
        {
            InitializeComponent();
        }

        //Gumb Izdaj potvrdu
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //dodatna provjera ima li polaznik položene ispite ID 1 i 2 
            string oib = dgwIzdavanjePotvrde.SelectedRows[0].Cells[0].Value.ToString();

            string upit = "SELECT * FROM polaganje WHERE OIBP='" + oib + "';";

            DbDataReader reader = DB.Instance.DohvatiDataReader(upit);

            bool polozen1 = false, polozen2 = false;

            while (reader.Read())
            {
                if (reader[3].ToString() == "1")
                {
                    if (reader[1].ToString() != "")
                    {
                        polozen1 = true;
                    }
                }
                if (reader[3].ToString() == "2")
                {
                    if (reader[1].ToString() != "")
                    {
                        polozen2 = true;
                    }
                }
            }

            if (polozen1 && polozen2)
            {

                string upit1 = "SELECT * FROM osoba WHERE OIB = '" + oib + "';";
                DbDataReader read = DB.Instance.DohvatiDataReader(upit1);
                read.Read();
                string ime = read[1].ToString();
                string prezime = read[2].ToString();
                string adresa = read[3].ToString();

                string upit2 = "SELECT * FROM ugovor WHERE OIBP = '" + oib + "';";
                DbDataReader read2 = DB.Instance.DohvatiDataReader(upit2);
                read2.Read();

                string kategorija = read2[4].ToString();
                MessageBox.Show("Printam potvrdu...");
                Potvrda.OtvoriWordUgovor(ime, prezime, adresa, oib, kategorija);
            }
            else
                MessageBox.Show("Polaznik nije položio prethodna dva ispita!");
            
        }

        //Back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _01frmWelcomeInstruktor forma = new _01frmWelcomeInstruktor();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _11aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public static string oib;
        public static string oibUPolaganju;

        //Za izlistavanje svih polaznika u dataGridView
        private void _11frmIzdavanjePotvrde_Load(object sender, EventArgs e)
        {

            dgwIzdavanjePotvrde.Rows.Clear();

            string upit = "SELECT * FROM osoba";
            DbDataReader datareader = DB.Instance.DohvatiDataReader(upit);

            while (datareader.Read())
            {
                oib = datareader[0].ToString();

                string upit2 = "SELECT * FROM polaganje WHERE OIBP = '" + oib + "';";
                DbDataReader dr = DB.Instance.DohvatiDataReader(upit2);
                while (dr.Read())
                {
                    bool prolaz = bool.Parse(dr[1].ToString());
                    int ispitID = int.Parse(dr[3].ToString());
                    oibUPolaganju = dr[4].ToString();

                    if (oibUPolaganju == oib)
                    {
                        if (ispitID == 3)
                        {
                            dgwIzdavanjePotvrde.Rows.Add(datareader[0], datareader[1], datareader[2]);
                        }

                    }
                }
            }

        }

        
    }
}
