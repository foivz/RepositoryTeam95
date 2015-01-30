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
    public partial class _04_Osoba : Form
    {
        public _04_Osoba()
        {
            InitializeComponent();
        }

        //Gumb Dodaj novu osobu
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _2aForma forma = new _2aForma();
            this.Hide();
            forma.Show();
        }

        //Gumb za ažuriranje podataka o osobi
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _5aForma forma = new _5aForma();
            this.Hide();

            string oib = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            
            string upitOsobe = "SELECT * FROM osoba WHERE OIB = '" + oib + "';";
            DbDataReader drOsobe = DB.Instance.DohvatiDataReader(upitOsobe);
            drOsobe.Read();

            //Popunjavanje textBoxova podacima iz tablice Osoba
            forma.tbIme.Text = drOsobe[1].ToString();
            forma.tbPrezime.Text = drOsobe[2].ToString();
            forma.tbAdresa.Text = drOsobe[3].ToString();
            forma.tbTel.Text = drOsobe[4].ToString();

            string upitRole = "SELECT * FROM role WHERE OIB = '" + oib + "';";
            DbDataReader drRole = DB.Instance.DohvatiDataReader(upitRole);

            //Popunjavanje textBoxova podacima iz tablice Role
            forma.cbRoleID.SelectedIndex = int.Parse(drRole[3].ToString())-1;
            forma.tbKIme.Text = drRole[0].ToString();
            forma.tbLoz.Text = drRole[1].ToString();


            forma.Show();
        }

        //Back button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _0taForma forma = new _0taForma();
            this.Hide();
            forma.Show();
         }

        //Izvršava se automatsko popunjavanje dataGrida čim se loada forma
        private void _04_Osoba_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
       
        //Odabran polaznik (roleID = 3)
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                popuniTablicu(3);
            }
        }

        //Odabran instruktor (roleID = 2)
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                popuniTablicu(2);
            }
        }

        //Odabran admin (roleID = 1)
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) 
            {
                popuniTablicu(1);
            }
        }

        /// <summary>
        /// Metoda za popunjavanje tablice s podacima
        /// </summary>
        /// <param name="role"></param>
        private void popuniTablicu(int role)
        {
            dataGridView1.Rows.Clear();

            string upit = "SELECT * FROM role WHERE roleID='" + role +"';";

            DbDataReader dr = DB.Instance.DohvatiDataReader(upit);

            while (dr.Read())
            {
                string upit2 = "SELECT * FROM osoba WHERE OIB = '" + dr[2].ToString() + "'; ";

                DbDataReader dr2 = DB.Instance.DohvatiDataReader(upit2);

                dr2.Read();

                dataGridView1.Rows.Add(dr2[0], dr2[1], dr2[2]);
            }

        }

        //Za gašenje aplikacije ako se klikne baš X gumbić na prozoru
        private void _04_Osoba_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
