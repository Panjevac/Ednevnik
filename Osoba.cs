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
    public partial class Osoba : Form
    {
        int broj_sloga = 0;
        DataTable tabela;

        public Osoba()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            SqlConnection veza = Konekcija.Povezivanje();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from osoba", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }
        private void Txt_load()
        {
            if (tabela.Rows.Count == 0)
            {
                txt_id.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_jmbg.Text = "";
                txt_adresa.Text = "";
                txt_uloga.Text = "";
                txt_email.Text = "";
                txt_password.Text = "";
                btn_obrisi.Enabled = false;
            }
            else
            {
                txt_id.Text = tabela.Rows[broj_sloga]["id"].ToString();
                txt_ime.Text = tabela.Rows[broj_sloga]["ime"].ToString();
                txt_prezime.Text = tabela.Rows[broj_sloga]["prezime"].ToString();
                txt_jmbg.Text = tabela.Rows[broj_sloga]["jmbg"].ToString();
                txt_adresa.Text = tabela.Rows[broj_sloga]["adresa"].ToString();
                txt_uloga.Text = tabela.Rows[broj_sloga]["uloga"].ToString();
                txt_email.Text = tabela.Rows[broj_sloga]["email"].ToString();
                txt_password.Text = tabela.Rows[broj_sloga]["password"].ToString();
                btn_obrisi.Enabled = true;
            }
            if(broj_sloga==0)
            {
                btn_previous.Enabled = false;
                btn_first.Enabled = false;
            }
            else
            {
                btn_previous.Enabled = true;
                btn_first.Enabled = true;
            }

            if (broj_sloga == tabela.Rows.Count-1)
            {
                btn_next.Enabled = false;
                btn_last.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
                btn_last.Enabled = true;
            }
        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            Load_Data();
            Txt_load();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Txt_load();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            broj_sloga --;
            Txt_load();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            broj_sloga ++;
            Txt_load();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            broj_sloga = tabela.Rows.Count-1;
            Txt_load();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("Insert into osoba(ime, prezime, jmbg, adresa, uloga, email, password) values ('");
            Naredba.Append(txt_ime.Text + "','");
            Naredba.Append(txt_prezime.Text + "','");
            Naredba.Append(txt_jmbg.Text + "','");
            Naredba.Append(txt_adresa.Text + "','");
            Naredba.Append(txt_uloga.Text + "','");
            Naredba.Append(txt_email.Text + "','");
            Naredba.Append(txt_password.Text + "')");
            SqlConnection veza = Konekcija.Povezivanje();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            Load_Data();
            broj_sloga = tabela.Rows.Count - 1;
            Txt_load();
        }

        private void btn_izmeni_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("Update osoba set ");
            Naredba.Append("ime = '"+txt_ime.Text + "', ");
            Naredba.Append("prezime = '" + txt_prezime.Text + "', ");
            Naredba.Append("jmbg = '" + txt_jmbg.Text + "', ");
            Naredba.Append("adresa = '" + txt_adresa.Text + "', ");
            Naredba.Append("uloga = '" + txt_uloga.Text + "', ");
            Naredba.Append("email = '" + txt_email.Text + "', ");
            Naredba.Append("password = '" + txt_password.Text + "' ");
            Naredba.Append("where id = " + txt_id.Text);

            SqlConnection veza = Konekcija.Povezivanje();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            Load_Data();
            broj_sloga = tabela.Rows.Count - 1;
            Txt_load();
        }

        private void btn_obrisi_Click(object sender, EventArgs e)
        {
            string Naredba = "delete from osoba where id = " + txt_id.Text;
            SqlConnection veza = Konekcija.Povezivanje();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            Boolean obrisano = false;
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
                obrisano = true;
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            if (obrisano)
            {
                Load_Data();
                if (broj_sloga > 0) broj_sloga--;
                Txt_load();
            }
        }
    }
}
