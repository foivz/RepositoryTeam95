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
    public partial class _12frmPodaciOPol : Form
    {
        public _12frmPodaciOPol()
        {
            InitializeComponent();
        }

        //Back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _09frmEvidencijaPol forma = new _09frmEvidencijaPol();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _12aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
