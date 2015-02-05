using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoskola
{
    public partial class _02frmUnosNovihPZ : Form
    {
        public _02frmUnosNovihPZ()
        {
            InitializeComponent();

            cbKategorijaID.Items.Clear();
            cbRoleID.Items.Clear();
            upisiKategorijeUCombo();
            upisiRoleUCombo();
            cbInstruktor.Items.Clear();
            upisiInstruktoraUCombo();          
        }

        //Gumb za pohranu
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba();
            Role role = new Role();
            Ugovor ugovor = new Ugovor();

            osoba.OIB = txtOIB.Text;
            osoba.ime = txtIme.Text;
            osoba.prezime = txtPrezime.Text;
            osoba.adresa = txtAdresa.Text;
            osoba.brTel = txtTel.Text;
            
            role.kIme = txtKIme.Text;
            role.lozinka = txtLozinka.Text;
            role.roleID = int.Parse(cbRoleID.Text);
            role.OIB = txtOIB.Text;

            ugovor.OIBP = txtOIB.Text;
            ugovor.Instruktor = cbInstruktor.Text;
            ugovor.kategorijaID = cbKategorijaID.Text;
            ugovor.stavke = "STAVKE DOPUNI: BANANAAAAAAAA!!!";

            if (osoba.PohraniUnos() != 0 )
            {
                if (role.roleID == 1 || role.roleID==2)
                {
                    role.PohraniUnos(); //to je zbog tog što izvrsiUpit vraća int redova koje je unio
                    
                        txtIme.Text = "";
                        txtPrezime.Text = "";
                        txtAdresa.Text = "";
                        txtKIme.Text = "";
                        txtLozinka.Text = "";
                        txtOIB.Text = "";
                        txtTel.Text = "";

                        MessageBox.Show("Uspješno dodan zaposlenik " + osoba.ime + " " + osoba.prezime + ".");                
                }
                else if (ugovor.UnesiUgovor() != 0)
                {
                    if (role.roleID == 3)
                    {
                        role.PohraniUnosPolaznika();

                        txtIme.Text = "";
                        txtPrezime.Text = "";
                        txtAdresa.Text = "";
                        txtOIB.Text = "";
                        txtTel.Text = "";

                        MessageBox.Show("Uspješno dodan polaznik " + osoba.ime + " " + osoba.prezime + " i generiran je ugovor za tog polaznika.");
                    }
                }
                else  { }
            }
        }

        //Gumb odustani
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _00frmWelcomAdmin forma = new _00frmWelcomAdmin();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _2aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void upisiKategorijeUCombo()
        {
            string upit = "SELECT * FROM kategorija;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {

                cbKategorijaID.Items.Add(dr[0].ToString());
            }
        }

        public void upisiRoleUCombo()
        {
            string upit = "SELECT * FROM kreiranjeRola;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(upit);
           
            while (dr.Read())
            {

                cbRoleID.Items.Add(dr[0].ToString());
            }
        }

        public void upisiInstruktoraUCombo() 
        {
            string upit = "SELECT * FROM role WHERE roleID == 2;";

            DbDataReader dr = DB.Instance.DohvatiDataReader(upit);

            while (dr.Read())
            {
                string upit2 = "SELECT * FROM osoba WHERE OIB = '" + dr[2].ToString() + "'; ";

                DbDataReader dr2 = DB.Instance.DohvatiDataReader(upit2);

                dr2.Read();

                string ime = dr2[1].ToString();
                string prezime = dr2[2].ToString();
                string zajedno = ime + " " + prezime;

                cbInstruktor.Items.Add(zajedno);
            }
        }
    }
}
