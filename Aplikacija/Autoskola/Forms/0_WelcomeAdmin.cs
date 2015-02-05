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
    public partial class _00frmWelcomAdmin : Form
    {
        public _00frmWelcomAdmin()
        {
            InitializeComponent();
        }

        //Upravljanje osobama
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _04frmOsobe forma = new _04frmOsobe();
            this.Hide();
            forma.Show();
        }

        //Upravljanje vozilima
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _06frmKatalogVozila forma = new _06frmKatalogVozila();
            this.Hide();
            forma.Show();
        }

        //Back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _0frmGlavnaForma forma = new _0frmGlavnaForma();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _0taForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
