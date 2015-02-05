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

        //Gumb Izdaj potvrdu---otvori PDF
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //+provjeri tko može dobit potvrdu
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

        //Za izlistavanje svih polaznika u dataGridView
        private void _11frmIzdavanjePotvrde_Load(object sender, EventArgs e)
        {
            string upit = "SELECT * FROM osoba;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(upit);

            while (dr.Read()) 
            {
                dgwIzdavanjePotvrde.Rows.Add(dr[1], dr[2]);

            }

        }

        
    }
}
