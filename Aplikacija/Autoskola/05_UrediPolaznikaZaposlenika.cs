using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoskola
{
    public partial class _5aForma : Form
    {
        public _5aForma()
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
            
        }

        //Gumb odustani
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _04_Osoba forma = new _04_Osoba();
            this.Hide();
            forma.Show();
        }

        //Unos ispita za polaznika---dodati upit za OIB
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _14_Ispiti forma = new _14_Ispiti();
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
