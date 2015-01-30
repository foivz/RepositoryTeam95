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
    public partial class _7aForma : Form
    {
        public _7aForma()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            upisiKategorijeUCombo();


        }

        //Gumb Pohrani
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo();
            vozilo.naziv = textBox1.Text;
            if (vozilo.PohraniUnos() != 0)
            {
                textBox1.Text = "";
                MessageBox.Show("Uspješno dodano vozilo "+ vozilo.naziv);
            }
        }

        //Gumb Odustani
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _6aForma forma = new _6aForma();
            this.Hide();
            forma.Show();
        }
 

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _7aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Za upis kategorija iz tablice u combobox
        public void upisiKategorijeUCombo() 
        {
            string upit = "SELECT * FROM kategorija;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {

                comboBox1.Items.Add (dr[0].ToString());
            }

        }
    }
}
