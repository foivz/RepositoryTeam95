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
    public partial class _6aForma : Form
    {
        public _6aForma()
        {
            InitializeComponent();
        }

        //Gumb Dodaj novo vozilo
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _7aForma forma = new _7aForma();
            this.Hide();
            forma.Show();
        }

        //Gumb Obrisi vozilo
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo();
            vozilo.ObrisiVozilo();
        }

        //Gumb Dodaj novu kategoriju vozila
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _13aForma forma = new _13aForma();
            this.Hide();
            //poziv metode
            forma.Show();
           
        }

        //Back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _0taForma forma = new _0taForma();
            this.Hide();
            forma.Show();
        }

        //Automatsko popunjavanje dataGrida kad se loada forma
        private void _6aForma_Load(object sender, EventArgs e)
        {
            string upit = "SELECT * FROM vozilo;";

            DbDataReader dr = DB.Instance.DohvatiDataReader(upit);

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1]);
            }

        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _6aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
