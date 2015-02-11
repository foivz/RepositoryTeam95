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
    public partial class _01frmWelcomeInstruktor : Form
    {
        public _01frmWelcomeInstruktor()
        {
            InitializeComponent();
        }

        //evidencija aktivnosti polaznika
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _09frmEvidencijaPol forma = new _09frmEvidencijaPol();
            this.Hide();
            forma.Show();
        }

        //izdaj potvrdu
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _11frmIzdavanjePotvrde forma = new _11frmIzdavanjePotvrde();
            this.Hide();
            forma.Show();
        }

        //back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _0frmGlavnaForma forma = new _0frmGlavnaForma();
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
