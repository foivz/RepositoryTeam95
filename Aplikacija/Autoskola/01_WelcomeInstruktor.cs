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
    public partial class _1aForma : Form
    {
        public _1aForma()
        {
            InitializeComponent();
        }

        //evidencija aktivnosti polaznika
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _9aForma forma = new _9aForma();
            this.Hide();
            forma.Show();
        }

        //izdaj potvrdu
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _11aForma forma = new _11aForma();
            this.Hide();
            forma.Show();
        }

        //back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GlavnaForma forma = new GlavnaForma();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _1aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
