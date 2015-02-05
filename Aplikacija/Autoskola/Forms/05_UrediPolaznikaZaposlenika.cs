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
    public partial class _05frmUrediPZ : Form
    {
        public _05frmUrediPZ()
        {
            InitializeComponent();

            cbRoleID.Items.Clear();
            cbRoleID.Items.Add("Admin");
            cbRoleID.Items.Add("Instruktor");
            cbRoleID.Items.Add("Polaznik");
        }

        //Gumb za pohranu
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            _04frmOsobe forma = new _04frmOsobe();

            string oib2 = forma.oib; 

            
            Osoba osoba = new Osoba();
            osoba.ime = txtIme.Text;
            osoba.prezime = txtPrezime.Text;
            osoba.adresa = txtAdresa.Text;
            osoba.brTel = txtTel.Text;
            osoba.AzurirajUnos(oib2);

            Role rola = new Role();
            rola.PohraniAzuriranjeRole(oib2);

            Ugovor ugovor = new Ugovor();
            ugovor.AzurirajUgovor(oib2);

            if (oib2 != "") MessageBox.Show("Ažuriranje uspješno!");
                            
        }

        //Gumb odustani
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _04frmOsobe forma = new _04frmOsobe();
            this.Hide();
            forma.Show();
        }

        //Unos ispita za polaznika + provjera da se samo za polaznike može unijeti
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Htjela bih da još provjerava ako je kliknuto na polaznika da samo onda može bit unos ispita omogućen
            //_04frmOsobe osoba = new _04frmOsobe();
            //if (osoba.rbPolaznici.Checked)
            //{
                _14frmIspiti forma = new _14frmIspiti();
                this.Hide();
                forma.Show();
            //}
            //else { }
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _5aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
