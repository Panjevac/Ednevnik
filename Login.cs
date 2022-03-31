using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EDnevnik
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_email.Text=="" || txt_password.Text == "")
            {
                MessageBox.Show("Uneti email i password :)");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.Povezivanje();
                    SqlCommand Komanda = new SqlCommand("select * from osoba where email=@username", veza);
                    Komanda.Parameters.AddWithValue("@username", txt_email.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(Komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int brojac=tabela.Rows.Count;
                    if(brojac == 1)
                    {
                        if(string.Compare(tabela.Rows[0]["password"].ToString(),txt_password.Text)==1)
                        {
                            MessageBox.Show("Uspesno logovanje :)");
                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();
                            Program.user_uloga = tabela.Rows[0]["uloga"].ToString();
                            this.Hide();
                            Glavna frm_glavna = new Glavna();
                            frm_glavna.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nije dobar password :)");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nema takvog emaila");
                    }
                }
                catch(Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
