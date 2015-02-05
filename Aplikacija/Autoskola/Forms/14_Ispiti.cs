﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SQLite;

namespace Autoskola
{
    public partial class _14frmIspiti : Form
    {
        public _14frmIspiti()
        {
            InitializeComponent();
            cbIspiti.Items.Clear();
            cbIspiti.Items.Add("PPSP - Prometni propisi i sigurnosna pravila");
            cbIspiti.Items.Add("PPP - Pružanje prve pomoći");
            cbIspiti.Items.Add("UV - Upravljanje vozilom");
        }

        //Gumb Pohrani
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ispiti ispiti = new Ispiti();
            _04frmOsobe osoba = new _04frmOsobe();

            ispiti.OIBP = osoba.dgwOsobe.SelectedRows[0].Cells[0].Value.ToString();
            
            ispiti.datum = dtpDatum.Value;

            string upit = "SELECT * FROM ispiti;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(upit);
            dr.Read();

            cbIspiti.SelectedIndex = int.Parse(dr[0].ToString());

            //uvjeti za upis podataka o pristupljenom ispitu i prolazu
            if (cbIspiti.SelectedIndex == 1 && rbDA.Checked)
            { 
                ispiti.ispitID = 1;
                ispiti.prolaz = true;
            }
            else if (cbIspiti.SelectedIndex == 1 && rbNE.Checked)
            {
                ispiti.ispitID = 1;
                ispiti.prolaz = false;
            }
            else if (cbIspiti.SelectedIndex == 2 && rbDA.Checked)
            {
                ispiti.ispitID = 2;
                ispiti.prolaz = true;
            }
            else if (cbIspiti.SelectedIndex == 2 && rbNE.Checked)
            {
                ispiti.ispitID = 2;
                ispiti.prolaz = false;
            }
            else if (cbIspiti.SelectedIndex == 3 && rbDA.Checked)
            {
                ispiti.ispitID = 3;
                ispiti.prolaz = true;

            }
            else 
            {
                ispiti.ispitID = 3;
                ispiti.prolaz = false;
            }


            ispiti.napomena = txtNapomena.Text;

            
            if (ispiti.PohraniPolaganjeIspita() != 0)
            {
                
                MessageBox.Show("Uspješno dodana evidencija ispita.");
            }

        }

        //Gumb Odustani
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _05frmUrediPZ forma = new _05frmUrediPZ();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _14_Ispiti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void _14frmIspiti_Load(object sender, EventArgs e)
        {
            rbDA.Checked = true;
            
        }

        
    }
}
