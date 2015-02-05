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
    public partial class _06frmKatalogVozila : Form
    {
        public _06frmKatalogVozila()
        {
            InitializeComponent();
        }

        //Gumb Dodaj novo vozilo
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _07frmDodajNovoVozilo forma = new _07frmDodajNovoVozilo();
            this.Hide();
            forma.Show();
        }

        //Gumb Obrisi vozilo
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo();
            
            int uspjeh = vozilo.ObrisiVozilo(int.Parse(this.dgwKatalog.SelectedRows[0].Cells[0].Value.ToString()));


            if (uspjeh == 1) 
            {
                MessageBox.Show("Vozilo obrisano!");

                //sa potonjom f-jom red koji pobrišemo u bazi se briše i iz dgw-a
                dgwKatalog.Rows.RemoveAt(this.dgwKatalog.SelectedRows[0].Index); 

            } 

            else MessageBox.Show("Nešto je pošlo po krivu :/ Vozilo nije obrisano.");
        }
        
        //Gumb Dodaj novu kategoriju vozila
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _13frmUnosKat forma = new _13frmUnosKat();
            this.Hide();
            //poziv metode
            forma.Show();
           
        }

        //Back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _00frmWelcomAdmin forma = new _00frmWelcomAdmin();
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
                dgwKatalog.Rows.Add(dr[0], dr[1]);
            }

        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _6aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
