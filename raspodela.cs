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
    public partial class Raspodela : Form
    {
        DataTable raspodela;
        int broj_sloga = 0;
        public Raspodela()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Load_data()
        {
            SqlConnection veza = Konekcija.Povezivanje();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from raspodela", veza);
            raspodela = new DataTable();
            adapter.Fill(raspodela);
            
        }

        private void raspodela_Load(object sender, EventArgs e)
        {
            Load_data();

        }
        private void Combo_fill()
        {
            SqlConnection veza = Konekcija.Povezivanje();
            
            DataTable nastavnik;
            DataTable predmet;
            DataTable godina;
            DataTable odeljenje;

            SqlDataAdapter adapter = new SqlDataAdapter("Select * from skolska_godina",veza);
            godina = new DataTable();
            adapter.Fill(godina);

            adapter = new SqlDataAdapter("Select id, ime+prezime as naziv from osoba where uloga=2", veza);
            nastavnik = new DataTable();
            adapter.Fill(nastavnik);

            adapter = new SqlDataAdapter("Select id, naziv from predmet", veza);
            predmet = new DataTable();
            adapter.Fill(predmet);

            adapter = new SqlDataAdapter("Select id, str(razred) + indeks as naziv from odeljenje", veza);
            odeljenje = new DataTable();
            adapter.Fill(odeljenje);

            cmb_godina.DataSource = godina;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";
           

            cmb_nastavnik.DataSource = nastavnik;
            cmb_nastavnik.ValueMember = "id";
            cmb_nastavnik.DisplayMember = "naziv";
            

            cmb_predmet.ValueMember = "id";
            cmb_predmet.DisplayMember = "naziv";
            cmb_predmet.DataSource = predmet;
            

            cmb_odeljenje.DataSource = odeljenje;
            cmb_odeljenje.ValueMember = "id";
            cmb_odeljenje.DisplayMember = "naziv";
            

            txt_id.Text = raspodela.Rows[broj_sloga]["id"].ToString();

            if(raspodela.Rows.Count==0)
            {
                cmb_godina.SelectedValue = raspodela.Rows[broj_sloga]["godina_id"]=-1;
                cmb_nastavnik.SelectedValue = raspodela.Rows[broj_sloga]["nastavnik_id"]=-1;
                cmb_predmet.SelectedValue = raspodela.Rows[broj_sloga]["predmet_id"]=-1;
                cmb_odeljenje.SelectedValue = raspodela.Rows[broj_sloga]["odeljenje_id"]=-1;
            }
            else
            {
                cmb_godina.SelectedValue = raspodela.Rows[broj_sloga]["godina_id"];
                cmb_nastavnik.SelectedValue = raspodela.Rows[broj_sloga]["nastavnik_id"] ;
                cmb_predmet.SelectedValue = raspodela.Rows[broj_sloga]["predmet_id"];
                cmb_odeljenje.SelectedValue = raspodela.Rows[broj_sloga]["odeljenje_id"];
            }

            if(broj_sloga==0)
            {
                btn_first.Enabled = false;
                btn_prev.Enabled = false;
            }
            else
            {
                btn_first.Enabled = true;
                btn_prev.Enabled = true;
            }
            if (broj_sloga ==raspodela.Rows.Count-1)
            {
                btn_last.Enabled = false;
                btn_next.Enabled = false;
            }
            else
            {
                btn_last.Enabled = true;
                btn_next.Enabled = true;
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Combo_fill();

        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            Combo_fill();

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            Combo_fill();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            broj_sloga=raspodela.Rows.Count-1;
            Combo_fill();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string Naredba = "delete from raspodela where id = " + txt_id.Text;
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
                Load_data();
                if (broj_sloga > 0) broj_sloga--;
                Combo_fill();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("Insert into raspodela(godina_id, predmet_id, nastavnik_id, odeljenje_id) values ('");
            Naredba.Append(cmb_godina  + "','");
            Naredba.Append(cmb_predmet + "','");
            Naredba.Append(cmb_nastavnik+ "','");
            Naredba.Append(cmb_odeljenje+ "')");
            
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
            Load_data();
            broj_sloga = raspodela.Rows.Count - 1;
            Combo_fill();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("Update raspodela set ");
            Naredba.Append("nastavnik_id = '" + cmb_nastavnik.SelectedValue + "', ");
            Naredba.Append("godina_id = '" + cmb_godina.SelectedValue + "', ");
            Naredba.Append("predmet_id = '" + cmb_predmet.SelectedValue + "', ");
            Naredba.Append("odeljenje_id = '" + cmb_odeljenje.SelectedValue + "' ");
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
            Load_data();
            broj_sloga = raspodela.Rows.Count - 1;
            Combo_fill();
        }
    }
    }

