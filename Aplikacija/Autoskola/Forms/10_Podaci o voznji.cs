using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoskola
{
    public partial class _10frmPodaciOVoznji : Form
    {
        public _10frmPodaciOVoznji()
        {
            InitializeComponent();
            cbVozilo.Items.Clear();
            upisiVoziloUCombo();
        }

        //Gumb Pohrani
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Evidencija evidencija = new Evidencija();
            _09frmEvidencijaPol forma9 = new _09frmEvidencijaPol();
            Vozilo vozilo = new Vozilo();

            evidencija.OIBP = forma9.dgwEvidencijaPol.SelectedRows[0].Cells[0].Value.ToString(); //ZAŠTO OPET NE RADI?

            evidencija.datum = dtpDatum.Value;

            evidencija.vrijemeP = TimeSpan.Parse(txtPocetakVoznje.Text);
            evidencija.vrijemeK = TimeSpan.Parse(txtKrajVoznje.Text);
            
            //evidencija.voziloID = vozilo.voziloID; OTKUD IZVLAČIT voziloID kad ga nema nigdje?!

            string TrajanjeVoznje = txtTrajanjeVoznje.Text.ToString();
                
           // TrajanjeVoznje = TimeSpan.Parse(txtKrajVoznje.Text.ToString()) - TimeSpan.Parse(txtPocetakVoznje.Text.ToString()); //KAKO TIMESPAN ODUZETI?!

            if (evidencija.PohraniUnos() != 0)
            {
                evidencija.PohraniUnos();

                txtPocetakVoznje.Text = "";
                txtKrajVoznje.Text = "";
                txtTrajanjeVoznje.Text = "";

                MessageBox.Show("Uspješno dodani podaci o vožnji.");
            }

        }

        //Gumb Odustani
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _09frmEvidencijaPol forma = new _09frmEvidencijaPol();
            this.Hide();
            forma.Show();
        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _10aForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        public void upisiVoziloUCombo()
        {
            string upit = "SELECT * FROM vozilo;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(upit);

            while (dr.Read())
            {

                cbVozilo.Items.Add(dr[1].ToString());
            }
        }
        
    }
}
