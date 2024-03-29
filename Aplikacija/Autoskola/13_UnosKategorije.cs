﻿using System;
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
    public partial class _13aForma : Form
    {
        public _13aForma()
        {
            InitializeComponent();
        }

        //Gumb Pohrani
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Kategorija kategorija = new Kategorija();
            kategorija.kategorijaID = textBox1.Text;
            if (kategorija.PohraniUnos() != 0)
            {
                textBox1.Text = "";
                MessageBox.Show("Uspješno dodana nova kategorija " + kategorija.kategorijaID);
            }
            
        }

        //Gumb Odustani
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _6aForma forma = new _6aForma();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _13aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
