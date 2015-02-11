using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;

namespace Autoskola
{
    public partial class _0frmGlavnaForma : Form
    {
        public _0frmGlavnaForma()
        {
           
            InitializeComponent();
        }


        //Gumb za prijavu u aplikaciju
        private void button1_Click(object sender, EventArgs e)
        {
            
           if (txtKIme.Text != "" & txtLozinka.Text != "")
            {

                string queryText = "SELECT roleID, kIme, lozinka FROM role WHERE kIme = '" + txtKIme.Text + "' AND lozinka = '" + txtLozinka.Text + "';";

                DbDataReader reader = DB.Instance.DohvatiDataReader(queryText);
               
                if (reader.HasRows)
                {
                    reader.Read();
                   
                    long varijabla = (long)reader[0];

                    //MessageBox.Show("Uspješna prijava!"); 
                    //1 = admin sučenje
                    if (varijabla == 1)
                    {
                        DB.Instance.prijava(txtKIme.Text, txtLozinka.Text);

                        _00frmWelcomAdmin forma = new _00frmWelcomAdmin();
                        this.Hide();
                        forma.Show();
                    }
                    //2= instruktor sučelje
                    else if (varijabla == 2)
                    {
                        DB.Instance.prijava(txtKIme.Text, txtLozinka.Text);

                        _01frmWelcomeInstruktor forma = new _01frmWelcomeInstruktor();
                        this.Hide();
                        forma.Show();
                    }
                    else
                    {
                        MessageBox.Show("Pogrešan unos! Pokušajte ponovno!");
                    }

                }
                else
                {
                    MessageBox.Show("Nepostojeći korisnik!");
                }

            }
            else
            {
                MessageBox.Show("Upiši podatke za prijavu!");
            }
            txtKIme.Clear();
            txtLozinka.Clear();
           
           
        }
        
        //Gumb za izlaz iz aplikacije
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        //da se prijava može i s enter tipkom izvršiti
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                button1_Click(null, null);
            }
        }

        
    }
}
