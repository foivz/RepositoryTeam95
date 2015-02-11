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
    public partial class _07frmDodajNovoVozilo : Form
    {
        public _07frmDodajNovoVozilo()
        {
            InitializeComponent();
            cbKategorija.Items.Clear();
            upisiKategorijeUCombo();


        }

        //Gumb Pohrani
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo();
            vozilo.naziv = txtNaziv.Text;
            vozilo.kategorijaVozila = cbKategorija.Text;
            if (vozilo.PohraniUnos() != 0)
            {
                txtNaziv.Text = "";
                MessageBox.Show("Uspješno dodano vozilo "+ vozilo.naziv + " kategorije " + vozilo.kategorijaVozila + ".");
            }
        }

        //Gumb Odustani
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _06frmKatalogVozila forma = new _06frmKatalogVozila();
            this.Hide();
            forma.Show();
        }

        //Za upis kategorija iz tablice u combobox
        public void upisiKategorijeUCombo()
        {
            string upit = "SELECT * FROM kategorija;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {

                cbKategorija.Items.Add(dr[0].ToString());
            }

        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _7aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      
    }
}
