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
           
        }
        
        //Gumb Pohrani
        public static TimeSpan razlika;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Evidencija evidencija = new Evidencija();

            string OIBP = _09frmEvidencijaPol.OIBP;

            evidencija.datum = dtpDatum.Value;

            evidencija.vrijemeP = TimeSpan.Parse(txtPocetakVoznje.Text);
            evidencija.vrijemeK = TimeSpan.Parse(txtKrajVoznje.Text);
            
            evidencija.OIBI = DB.Instance.prijavljenaOsoba.OIB;

            razlika = evidencija.vrijemeK.Subtract(evidencija.vrijemeP);

            txtTrajanjeVoznje.Text = razlika.ToString();
                
            evidencija.PohraniUnos(OIBP);

            MessageBox.Show("Uspješno dodani podaci o vožnji.");
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

    }
}
