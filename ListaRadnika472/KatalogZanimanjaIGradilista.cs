using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListaRadnika
{
    public partial class KatalogZanimanjaIGradilista : Form
    {
        readonly string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        readonly SqlConnection con;        
        readonly DodajRadnika dodajRadnika = new DodajRadnika();
        
        public KatalogZanimanjaIGradilista()
        {
            InitializeComponent();
            con = new SqlConnection(conStr);
        }

        private void DataRecord(string nazivTabele, string nazivKolone, TextBox txt, string nazivKataloga)
        {
            if(txt.Text.Length == 0)
            {
                MessageBox.Show($"Molimo popunite polje 'Unesi naziv {nazivKataloga}'");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"INSERT INTO {nazivTabele}({nazivKolone}) VALUES ('"+txt.Text+"')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Podatak je snimljen u Katalog {nazivKataloga}!");
                    con.Close();
                    ClearForm(txt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Problem u metodu DataRecord!");
                    con.Close();
                }
            }
        }

        private void ClearForm(TextBox txt)
        {
            txt.Text = "";
        }

        private void BtnSnimiZanimanje_Click(object sender, EventArgs e)
        {
            DataRecord("Zanimanja_katalog", "Naziv_zanimanja", txtZanimanje, "zanimanja");            
        }

        private void BtnSnimiGradiliste_Click(object sender, EventArgs e)
        {
            DataRecord("Gradilišta_katalog", "Naziv_gradilišta", txtGradiliste, "gradilišta");
        }
        private void BtnIdiNaIzbOp_Click(object sender, EventArgs e)
        {
            Hide();
            IzborOperacije io = new IzborOperacije ();
            io.Closed += (s, args) => Close();
            io.Show();
        }
        private void btnIdiNaIzmjenuPodataka_Click(object sender, EventArgs e)
        {
            Hide();
            IzmjenaPodataka ip = new IzmjenaPodataka();
            ip.Closed += (s, args) => Close();
            ip.Show();
        }
        public void FieldFocus(string fieldName)
        {
            if(fieldName == "zanimanje")
            {
                txtZanimanje.Focus();
            }
            else if(fieldName == "gradilište")
            {
                txtGradiliste.Focus();
            }
        }
    }
}
