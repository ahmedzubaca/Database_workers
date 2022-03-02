using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ListaRadnika
{
    public partial class DodajRadnika : Form
    {
        readonly string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        readonly SqlConnection con;
        readonly HelperMethods helperMethods = new HelperMethods();

        public DodajRadnika()
        {
            InitializeComponent();
            con = new SqlConnection(conStr);            
        }

        private void DodajRadnika_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlUnosPodataka.Controls)
            {
                if (ctrl is DateTimePicker dtp)
                {
                    dtp.CustomFormat = " ";
                    dtp.Format = DateTimePickerFormat.Custom;
                }
            }
        }

        private void DtpDatumRodenja_ValueChanged(object sender, EventArgs e)
        {
            DateChanged(dtpDatumRodenja);
        }
        private void DtpDatumIstekaVize_ValueChanged(object sender, EventArgs e)
        {
            DateChanged(dtpDatumIstekaVize);
        }
        private void DtpNaGradilistuOd_ValueChanged(object sender, EventArgs e)
        {
            DateChanged(dtpNaGradilistuOd);
        }
        private void NudPlata_ValueChanged(object sender, EventArgs e)
        {
            nudPlata.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            nudPlata.ForeColor = Color.Black;
        }
        private void CbZanimanje_DropDown(object sender, EventArgs e)
        {
            cbZanimanje.Items.Clear();
            cbZanimanje.ForeColor = Color.Black;            
            helperMethods.PopulateCombobox(con, cbZanimanje, "Zanimanja_katalog", "Naziv_zanimanja", "zanimanje");
        }
        private void CbGradiliste_DropDown(object sender, EventArgs e)
        {
            cbGradiliste.Items.Clear();
            cbGradiliste.ForeColor = Color.Black;
            helperMethods.PopulateCombobox(con, cbGradiliste, "Gradilišta_katalog", "Naziv_gradilišta", "gradilište");
        }
        private void BtnIzaberiSliku_Click(object sender, EventArgs e)
        {
            helperMethods.ChooseFile(txtLokacijaSlike);
        }
        private void BtnPregledajSliku_Click(object sender, EventArgs e)
        {
            helperMethods.PreviewItem(txtLokacijaSlike.Text);
        }
        private void BtnIzaberiPasos_Click(object sender, EventArgs e)
        {
            helperMethods.ChooseFile(txtLokacijaPasosa);
        }
        private void BtnPregledajPasos_Click(object sender, EventArgs e)
        {
            helperMethods.PreviewItem(txtLokacijaPasosa.Text);
        }
        private void BtnIzaberiVizu_Click(object sender, EventArgs e)
        {
            helperMethods.ChooseFile(txtLokacijaVize);
        }
        private void BtnPregledajVizu_Click(object sender, EventArgs e)
        {
            helperMethods.PreviewItem(txtLokacijaVize.Text);
        }
        private void BtnIzaberiRadnuDozvolu_Click(object sender, EventArgs e)
        {
            helperMethods.ChooseFile(txtLokacijaRadneDozvole);
        }
        private void BtnPregledajRadnuDozvolu_Click(object sender, EventArgs e)
        {
            helperMethods.PreviewItem(txtLokacijaRadneDozvole.Text);
        }
        private void BtnSnimiPodatke_Click(object sender, EventArgs e)
        {
            RecordDataToDatabase();
        }
        private void BtnVratiSeNaIzOp_Click(object sender, EventArgs e)
        {
            Hide();
            IzborOperacije io = new IzborOperacije();
            io.Closed += (s, args) => Close();
            io.Show();
        }

        public void RecordDataToDatabase()
        {
            string spol = rbtnMusko.Checked ? "Muško" : rbtnZensko.Checked ? "Žensko" : "";
            string aktivan = rbtnDa.Checked ? "Da" : rbtnNe.Checked ? "Ne" : "";


            if (txtIme.Text == "" || txtPrezime.Text == "" || dtpDatumRodenja.Tag.ToString() == "0" ||
                spol == "" || txtMjestoBoravka.Text == "" || txtBrojPasosa.Text == "" ||
                dtpDatumIstekaVize.Tag.ToString() == "0" || cbZanimanje.Text == "" ||
                cbGradiliste.Text == "" || dtpNaGradilistuOd.Tag.ToString() == "0" ||
                nudPlata.Value == 0 || aktivan == "" || txtLokacijaSlike.Text == "" ||
                txtLokacijaPasosa.Text == "" || txtLokacijaVize.Text == "" ||
                txtLokacijaRadneDozvole.Text == "")
            {
                MessageBox.Show("Molim popunite sva polja!");
            }
            else
            {
                try
                {                    
                    string commonPath = $"{ AppDomain.CurrentDomain.BaseDirectory}SkeniraniDokumenti\\";
                    string lokacijaSlike = Path.Combine(commonPath + "Slike\\", DateTime.Now.ToString("yyyyMMddHHmmssffff") + "-" +
                                           Path.GetFileName(txtLokacijaSlike.Text));
                    string lokacijaPasosa = Path.Combine(commonPath + "Pasosi\\", DateTime.Now.ToString("yyyyMMddHHmmssffff") + "-" +
                                           Path.GetFileName(txtLokacijaPasosa.Text));
                    string lokacijaVize = Path.Combine(commonPath + "Vize\\", DateTime.Now.ToString("yyyyMMddHHmmssffff") + "-" +
                                           Path.GetFileName(txtLokacijaVize.Text));
                    string lokacijaRadneDozvole = Path.Combine(commonPath + "RadneDozvole\\", DateTime.Now.ToString("yyyyMMddHHmmssffff") + "-" +
                                           Path.GetFileName(txtLokacijaRadneDozvole.Text));

                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "insert into Evidencija_radnika(Ime, Prezime, Datum_rođenja, Spol, Mjesto_boravka, Broj_pasoša, Datum_isteka_vize, Zanimanje," +
                        " Gradilište, Na_gradilištu_od, Plata, Aktivan, Lokacija_slike, Lokacija_pasoša, Lokacija_vize, Lokacija_radne_dozvole ) values" +
                                                    "('" + txtIme.Text + "', '" + txtPrezime.Text + "','" + dtpDatumRodenja.Value.Date.ToString("yyyy-MM-dd") + "','" + spol + "'," +
                                                    "'" + txtMjestoBoravka.Text + "','" + txtBrojPasosa.Text + "','" + dtpDatumIstekaVize.Value.Date.ToString("yyyy-MM-dd") + "'," +
                                                    "'" + cbZanimanje.Text + "','" + cbGradiliste.Text + "'," +
                                                    "'" + dtpNaGradilistuOd.Value.Date.ToString("yyyy-MM-dd") + "'," +
                                                    "'" + nudPlata.Value + "','" + aktivan + "','" + lokacijaSlike + "','" + lokacijaPasosa + "'," +
                                                    "'" + lokacijaVize + "','" + lokacijaRadneDozvole + "')", con);
                    
                    helperMethods.SaveItemToFile(txtLokacijaSlike, lokacijaSlike);
                    helperMethods.SaveItemToFile(txtLokacijaPasosa, lokacijaPasosa);
                    helperMethods.SaveItemToFile(txtLokacijaVize, lokacijaVize);
                    helperMethods.SaveItemToFile(txtLokacijaRadneDozvole, lokacijaRadneDozvole);
                    MessageBox.Show("Podaci su uneseni u bazu podataka.");                    
                    cmd.ExecuteNonQuery();
                    con.Close();
                    helperMethods.ClearForm(pnlUnosPodataka);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Problem u metodu RecordDataToDatabase");
                    con.Close();
                }
            }
        }

        public void DateChanged(DateTimePicker dtp)
        {
            dtp.CustomFormat = "yyyy-MM-dd";
            dtp.Tag = 1;
            dtp.Font = new Font("Segoe UI", 11, FontStyle.Regular);
        }
        private void CbZanimanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbZanimanje.SelectedItem.ToString() == "Dodaj novo zanimanje")
            {                
                KatalogZanimanjaIGradilista kzg = new KatalogZanimanjaIGradilista();               
                kzg.Show();
                kzg.FieldFocus("zanimanje");
            }
        }

        private void CbGradiliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGradiliste.SelectedItem.ToString() == "Dodaj novo gradilište")
            {                
                KatalogZanimanjaIGradilista kzg = new KatalogZanimanjaIGradilista();                
                kzg.Show();
                kzg.FieldFocus("gradilište");
            }
        }        
    }
}
