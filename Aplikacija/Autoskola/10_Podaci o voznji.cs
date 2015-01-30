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
    public partial class _10aForma : Form
    {
        public _10aForma()
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
            _9aForma forma = new _9aForma();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _10aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        
    }
}
