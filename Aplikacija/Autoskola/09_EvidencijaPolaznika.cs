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
    public partial class _9aForma : Form
    {
        public _9aForma()
        {
            InitializeComponent();
        }

        //Gumb Evidentiraj polaznika
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _10aForma forma = new _10aForma();
            this.Hide();
            forma.Show();
        }

        //Gumb za dohvat starih podataka
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _12aForma forma = new _12aForma();
            this.Hide();
            forma.Show();
        }

        //Back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _1aForma forma = new _1aForma();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _9aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
