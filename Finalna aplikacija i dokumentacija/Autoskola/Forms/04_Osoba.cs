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
using System.Data.SQLite;


namespace Autoskola
{
    public partial class _04frmOsobe : Form
    {
        public _04frmOsobe()
        {
            InitializeComponent();
            
            
        }

        //Gumb Dodaj novu osobu
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _02frmUnosNovihPZ forma = new _02frmUnosNovihPZ();
            this.Hide();
            forma.Show();
        }
        
        public static string oib;
        public static int roleID;
       
        //Gumb za ažuriranje podataka o osobi (popunjavanje sljedeće forme podacima iz tablica)
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _05frmUrediPZ forma = new _05frmUrediPZ();
            this.Hide();
            forma.cbKategorijaID.Items.Clear();
            oib = dgwOsobe.SelectedRows[0].Cells[0].Value.ToString();
            
            string upitOsobe = "SELECT * FROM osoba WHERE OIB = '" + oib + "';";
            DbDataReader drOsobe = DB.Instance.DohvatiDataReader(upitOsobe);
            drOsobe.Read();

            //Popunjavanje textBoxova podacima iz tablice Osoba
            forma.txtIme.Text = drOsobe[1].ToString();
            forma.txtPrezime.Text = drOsobe[2].ToString();
            forma.txtAdresa.Text = drOsobe[3].ToString();
            forma.txtTel.Text = drOsobe[4].ToString();

            string upitRole = "SELECT * FROM role WHERE OIB = '" + oib + "';";
            DbDataReader drRole = DB.Instance.DohvatiDataReader(upitRole);

            //Popunjavanje textBoxova podacima iz tablice Role
            forma.cbRoleID.SelectedIndex = int.Parse(drRole[3].ToString()) - 1;
            forma.txtKIme.Text = drRole[0].ToString();
            forma.txtLozinka.Text = drRole[1].ToString();
            roleID = int.Parse(drRole[3].ToString());

            string upit = "SELECT * FROM kategorija;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(upit);

            while (dr.Read())
            {

                forma.cbKategorijaID.Items.Add(dr[0].ToString());
            }

            string upit1 = "SELECT * from ugovor WHERE OIBP = '" + oib + "';";
            DbDataReader dr1 = DB.Instance.DohvatiDataReader(upit1);

            string staraKategorija = "";
            string instruktor = "";

            while (dr1.Read()) 
            {
                staraKategorija = dr1[4].ToString();
                instruktor = dr1[3].ToString();
            }

            forma.staraKategorija = staraKategorija;
            forma.instruktor = instruktor;
            
            forma.Show();
        }

        //Back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _00frmWelcomAdmin forma = new _00frmWelcomAdmin();
            this.Hide();
            forma.Show();
         }

        //Izvršava se automatsko popunjavanje dataGrida čim se loada forma
        private void _04_Osoba_Load(object sender, EventArgs e)
        {
            rbPolaznici.Checked = true;
        }
       
        //Odabran polaznik (roleID = 3)
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPolaznici.Checked)
            {
                popuniTablicu(3);
            }
        }

        //Odabran instruktor (roleID = 2)
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInstruktori.Checked)
            {
                popuniTablicu(2);
            }
        }

        //Odabran admin (roleID = 1)
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdmin.Checked) 
            {
                popuniTablicu(1);
            }
        }

        

        /// <summary>
        /// Metoda za popunjavanje dataGrida s podacima iz dviju tablica 
        /// </summary>
        /// <param name="role"></param>
        private void popuniTablicu(int role)
        {
            dgwOsobe.Rows.Clear();

            string upit = "SELECT * FROM role WHERE roleID='" + role +"';";

            DbDataReader dr = DB.Instance.DohvatiDataReader(upit);

            while (dr.Read())
            {
                string upit2 = "SELECT * FROM osoba WHERE OIB = '" + dr[2].ToString() + "'; ";

                DbDataReader dr2 = DB.Instance.DohvatiDataReader(upit2);

                dr2.Read();

                dgwOsobe.Rows.Add(dr2[0], dr2[1], dr2[2]);
            }

        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _04_Osoba_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



       
    }
}
