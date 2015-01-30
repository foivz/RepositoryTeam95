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
    public partial class _14_Ispiti : Form
    {
        public _14_Ispiti()
        {
            InitializeComponent();
        }

        //Gumb Pohrani
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Gumb Odustani
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _5aForma forma = new _5aForma();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _14_Ispiti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
