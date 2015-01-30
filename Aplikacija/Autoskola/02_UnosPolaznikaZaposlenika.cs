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
    public partial class _2aForma : Form
    {
        public _2aForma()
        {
            InitializeComponent();
        }

        //Gumb za pohranu
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }


        //Gumb odustani
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _0taForma forma = new _0taForma();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _2aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
