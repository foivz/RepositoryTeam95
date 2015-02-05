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

        //Gumb Evidentiraj polaznika
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _10frmPodaciOVoznji forma = new _10frmPodaciOVoznji();
            this.Hide();
            forma.Show();
        }

        //Gumb za dohvat starih podataka
        private void pictureBox2_Click(object sender, EventArgs e)
        {
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

        //Popis polaznika u dgw-u za odabir daljnjih podataka o vožnji
        private void _09frmEvidencijaPol_Load(object sender, EventArgs e)
        {
            string upit = "SELECT * FROM osoba;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(upit);

            while (dr.Read())
            {
                dgwEvidencijaPol.Rows.Add(dr[0], dr[1], dr[2]);

            }
                
        }




    }
}
