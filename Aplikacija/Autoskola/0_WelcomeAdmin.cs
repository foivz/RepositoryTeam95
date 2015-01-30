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
    public partial class _0taForma : Form
    {
        public _0taForma()
        {
            InitializeComponent();
        }

        //Upravljanje osobama
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _04_Osoba forma = new _04_Osoba();
            this.Hide();
            forma.Show();
        }

        //Upravljanje vozilima
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _6aForma forma = new _6aForma();
            this.Hide();
            forma.Show();
        }

        //Back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GlavnaForma forma = new GlavnaForma();
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
