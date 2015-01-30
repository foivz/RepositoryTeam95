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
    public partial class _11aForma : Form
    {
        public _11aForma()
        {
            InitializeComponent();
        }

        //Gumb Izdaj potvrdu---otvori PDF
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _1aForma forma = new _1aForma();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _11aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
