using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaRadnika
{
    public partial class IzmjenaPodataka : Form
    {
        readonly string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        readonly SqlConnection con;
        int id;
        readonly string sviPodaciQuery = "SELECT * FROM Evidencija_radnika";
        
        string pathPreviewSlike, pathOldSlika;
        string pathPreviewPasosa, pathOldPasos;
        string pathPreviewVize, pathOldViza;
        string pathPreviewRadneDozvole, pathOldRadnaDozvola;
        HelperMethods helperMethods = new HelperMethods();

        public IzmjenaPodataka()
        {
            InitializeComponent();
            con = new SqlConnection(conStr);
        }
        private void IzmjenaPodataka_Load(object sender, EventArgs e)
        {
            helperMethods.DisplayDataInDataGridView(con, sviPodaciQuery, dgvIzmjenaPodataka);
            helperMethods.DisableControls(pnlPodaciORadniku);
        }
        private void DgvIzmjenaPodataka_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (Control ctrl in pnlPodaciORadniku.Controls)
                {
                    ctrl.Enabled = true;

                    if (ctrl is NumericUpDown nud)
                    {
                        nud.ForeColor = Color.Black;
                    }
                    else if (ctrl is DateTimePicker dtp)
                    {
                        dtp.CustomFormat = "yyyy-MM-dd";
                    }
                    else if(ctrl is ComboBox cb)
                    {
                        cb.ForeColor = Color.Black;
                    }
                }

                id = int.Parse(dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[0].Value.ToString());

                txtIme.Text = dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrezime.Text = dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpDatumRodenja.Value = ((DateTime)dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[3].Value);
                rbtnMusko.Checked = dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[4].Value.ToString() == "Muško" ? true : false;
                rbtnZensko.Checked = dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[4].Value.ToString() == "Žensko" ? true : false;
                txtMjestoBoravka.Text = dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtBrojPasosa.Text = dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[6].Value.ToString();
                dtpDatumIstekaVize.Value = ((DateTime)dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[7].Value);                
                cbZanimanje.Text = dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[8].Value.ToString();
                cbGradiliste.Text = dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[9].Value.ToString();
                dtpNaGradilistuOd.Value = ((DateTime)dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[10].Value);                              
                nudPlata.Value = decimal.Parse(dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[11].Value.ToString());
                rbtnDa.Checked = dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[12].Value.ToString() == "Da" ? true : false;
                rbtnNe.Checked = dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[12].Value.ToString() == "Ne" ? true : false;
                pathOldSlika = pathPreviewSlike = dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[13].Value.ToString();
                pathOldPasos = pathPreviewPasosa = dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[14].Value.ToString();
                pathOldViza = pathPreviewVize = dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[15].Value.ToString();
                pathOldRadnaDozvola = pathPreviewRadneDozvole = dgvIzmjenaPodataka.Rows[e.RowIndex].Cells[16].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u metodu DgvIspravkaPogresnogUnosa_CellClick");
            }
        }
        private void BtnPogledajSliku_Click(object sender, EventArgs e)
        {
            helperMethods.PreviewItem(pathPreviewSlike);
        }
        private void BtnPogledajPasos_Click(object sender, EventArgs e)
        {
            helperMethods.PreviewItem(pathPreviewPasosa);
        }

        private void BtnPogledajVizu_Click(object sender, EventArgs e)
        {
            helperMethods.PreviewItem(pathPreviewVize);
        }

        private void BtnPogledajRadnuDozvolu_Click(object sender, EventArgs e)
        {
            helperMethods.PreviewItem(pathPreviewRadneDozvole);
        }

        private void BtnZamijeniSliku_Click(object sender, EventArgs e)
        {
            helperMethods.ChooseFile(txtZamijeniSliku);
            pathPreviewSlike = txtZamijeniSliku.Text;
        }

        private void BtnZamijeniPasos_Click(object sender, EventArgs e)
        {
            helperMethods.ChooseFile(txtZamijeniPasos);
            pathPreviewPasosa = txtZamijeniPasos.Text;
        }

        private void BtnZamijeniVizu_Click(object sender, EventArgs e)
        {
            helperMethods.ChooseFile(txtZamijeniVizu);
            pathPreviewVize = txtZamijeniVizu.Text;
        }

        private void BtnVratiSeNaIO_Click(object sender, EventArgs e)
        {
            Hide();
            IzborOperacije io = new IzborOperacije();
            io.Closed += (s, args) => Close();
            io.Show();
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

        private void BtnZamijeniRadnuDozvolu_Click(object sender, EventArgs e)
        {
            helperMethods.ChooseFile(txtZamijeniRadnuDozvolu);
            pathPreviewRadneDozvole = txtZamijeniRadnuDozvolu.Text;
        }

        private void BtnSnimiIzmjene_Click(object sender, EventArgs e)
        {
            DataRecord();
            helperMethods.ClearForm(pnlPodaciORadniku);
            helperMethods.DisableControls(pnlPodaciORadniku);
            foreach (Control ctrl in pnlPodaciZaPretragu.Controls)
            {
                if (ctrl is TextBox tb)
                {
                    tb.Text = "";
                }                
            }
        }

        public void DataRecord()
        {
            string spol = rbtnMusko.Checked ? "Muško" : rbtnZensko.Checked ? "Žensko" : "";
            string aktivanDaNe = rbtnDa.Checked ? "Da" : rbtnNe.Checked ? "Ne" : "";


            if (txtIme.Text == "" || txtPrezime.Text == "" || spol == "" || 
                txtMjestoBoravka.Text == "" || txtBrojPasosa.Text == "" || 
                cbZanimanje.Text == "" || cbGradiliste.Text == ""  || nudPlata.Value == 0 ||
                aktivanDaNe == "")
            {
                MessageBox.Show("Molim popunite sva polja!");
            }
            else
            {
                try
                {
                    string commonPath = $"{ AppDomain.CurrentDomain.BaseDirectory}SkeniraniDokumenti\\";

                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Evidencija_radnika SET " +
                        "Ime = '" + txtIme.Text + "', " +
                        "Prezime = '" + txtPrezime.Text + "' ," +
                        "Datum_rođenja = '" + dtpDatumRodenja.Value.Date.ToString("yyyy-MM-dd") + "'," +
                        "Spol = '" + spol + "', " +
                        "Mjesto_boravka = '" + txtMjestoBoravka.Text + "' , " +
                        "Broj_pasoša = '" + txtBrojPasosa.Text + "'," +
                        "Datum_isteka_vize = '" + dtpDatumIstekaVize.Value.Date.ToString("yyyy-MM-dd") + "' , " +
                        "Zanimanje = '" + cbZanimanje.Text + "' ," +
                        "Gradilište = '" + cbGradiliste.Text + "' ," +
                        "Na_gradilištu_od = '" + dtpNaGradilistuOd.Value.Date.ToString("yyyy-MM-dd") + "' ," +                        
                        "Plata = '" + nudPlata.Value + "', " +
                        "Aktivan = '" + aktivanDaNe + "' " +
                        "WHERE Id_radnika = '" + id + "' ", con);
                    cmd.ExecuteNonQuery();

                    if (txtZamijeniSliku.Text.Length > 0)
                    {
                        string documentFolderName = "Slike\\";
                        string columnHeaderName = "Lokacija_slike";
                        string lokacijaNovogDokumenta = helperMethods.LokacijaDokumenta(commonPath, documentFolderName, txtZamijeniSliku.Text);
                        string sqlCommandString = helperMethods.StringForSqlCommand(columnHeaderName, lokacijaNovogDokumenta, id);
                        SqlCommand cmdSlika = new SqlCommand(sqlCommandString, con);
                        cmdSlika.ExecuteNonQuery();
                        helperMethods.SaveItemToFile(txtZamijeniSliku, lokacijaNovogDokumenta);
                        File.Delete(pathOldSlika);
                    }
                    
                    if (txtZamijeniPasos.Text.Length > 0)
                    {
                        string documentFolderName = "Pasosi\\";
                        string columnHeaderName = "Lokacija_pasoša";
                        string lokacijaNovogDokumenta = helperMethods.LokacijaDokumenta(commonPath, documentFolderName, txtZamijeniPasos.Text);
                        string sqlCommandString = helperMethods.StringForSqlCommand(columnHeaderName, lokacijaNovogDokumenta, id);
                        SqlCommand cmdPasos = new SqlCommand(sqlCommandString, con);
                        cmdPasos.ExecuteNonQuery();
                        helperMethods.SaveItemToFile(txtZamijeniPasos, lokacijaNovogDokumenta);
                        File.Delete(pathOldPasos);
                    }
                    if (txtZamijeniVizu.Text.Length > 0)
                    {
                        string documentFolderName = "Vize\\";
                        string columnHeaderName = "Lokacija_vize";
                        string lokacijaNovogDokumenta = helperMethods.LokacijaDokumenta(commonPath, documentFolderName, txtZamijeniVizu.Text);
                        string sqlCommandString = helperMethods.StringForSqlCommand(columnHeaderName, lokacijaNovogDokumenta, id);
                        SqlCommand cmdViza = new SqlCommand(sqlCommandString, con);
                        cmdViza.ExecuteNonQuery();
                        helperMethods.SaveItemToFile(txtZamijeniVizu, lokacijaNovogDokumenta);
                        File.Delete(pathOldViza);
                    }
                    if (txtZamijeniRadnuDozvolu.Text.Length > 0)
                    {
                        string documentFolderName = "RadneDozvole\\";
                        string columnHeaderName = "Lokacija_radne_dozvole";
                        string lokacijaNovogDokumenta = helperMethods.LokacijaDokumenta(commonPath, documentFolderName, txtZamijeniRadnuDozvolu.Text);
                        string sqlCommandString = helperMethods.StringForSqlCommand(columnHeaderName, lokacijaNovogDokumenta, id);
                        SqlCommand cmdRadnaDozvola = new SqlCommand(sqlCommandString, con);
                        cmdRadnaDozvola.ExecuteNonQuery();
                        helperMethods.SaveItemToFile(txtZamijeniRadnuDozvolu, lokacijaNovogDokumenta);
                        File.Delete(pathOldRadnaDozvola);
                    }                    
                    con.Close();
                    MessageBox.Show("Podaci su uneseni u bazu podataka.");
                    helperMethods.DisplayDataInDataGridView(con, sviPodaciQuery, dgvIzmjenaPodataka);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void TxtPodaciZaPretragu_TextChanged(object sender, EventArgs e)
        {
            string ime = txtImeZaPretragu.Text.ToString();
            string prezime = txtPrezimeZaPretragu.Text.ToString();
            try
            {
                string adapterQuery = helperMethods.TableSearch(ime, prezime);
                helperMethods.DisplayDataInDataGridView(con, adapterQuery, dgvIzmjenaPodataka);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u metodu TxtPodaciZaPretragu_TextChanged");                
            }
        }        
    }
}