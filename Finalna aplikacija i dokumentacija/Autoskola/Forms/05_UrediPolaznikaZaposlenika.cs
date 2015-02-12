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

        private void _05frmUrediPZ_Load(object sender, EventArgs e)
        {
            cbKategorijaID.SelectedText = staraKategorija;
            cbKategorijaID.SelectedIndex = cbKategorijaID.FindString(staraKategorija);
        }


        public string staraKategorija;
        public string instruktor;
        
        //Gumb za pohranu
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            string novaKategorija = cbKategorijaID.Items[cbKategorijaID.SelectedIndex].ToString();

            string OIB = _04frmOsobe.oib; 
            int roleID = _04frmOsobe.roleID;

            Osoba osoba = new Osoba();
            osoba.ime = txtIme.Text;
            osoba.prezime = txtPrezime.Text;
            osoba.adresa = txtAdresa.Text;
            osoba.brTel = txtTel.Text;
            
            osoba.AzurirajUnos(OIB);

            Role rola = new Role();
            rola.kIme = txtKIme.Text;
            rola.lozinka = txtLozinka.Text;
            
            rola.PohraniAzuriranjeRole(OIB);

            Ugovor ugovor = new Ugovor();
            ugovor.OIBP = OIB;
            ugovor.Instruktor = instruktor;
            ugovor.kategorijaID = novaKategorija;

            if (novaKategorija == staraKategorija && roleID == 3)
            {
                ugovor.AzurirajUgovor(OIB);
                MessageBox.Show("Ažuriranje uspješno!");
                
            }
            else if (roleID == 3)
            {
                ugovor.UnesiUgovor();
                Ugovor.OtvoriWordUgovor(osoba.ime, osoba.prezime, osoba.adresa, OIB, ugovor.kategorijaID);
                MessageBox.Show("Kreiran novi ugovor");
            }
            else 
            {
                MessageBox.Show("Ažuriranje uspješno!"); 
            }
            

            
                            
        }

        //Gumb odustani
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _04frmOsobe forma = new _04frmOsobe();
            this.Hide();
            forma.Show();
        }

        //Unos ispita
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
                _14frmIspiti forma = new _14frmIspiti();
                this.Hide();
                forma.Show();
            
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _5aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
        
    }
}
