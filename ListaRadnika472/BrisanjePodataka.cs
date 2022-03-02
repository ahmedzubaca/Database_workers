using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ListaRadnika
{
    public partial class BrisanjePodataka : Form
    {
        readonly string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;        
        readonly SqlConnection con;
        int id;
        readonly string allDataQery = "SELECT * FROM Evidencija_radnika";
        string lokacijaSlike;
        string lokacijaPasosa;
        string lokacijaVize;
        string lokacijaRadneDozvole;
        HelperMethods helperMethods = new HelperMethods();
        public BrisanjePodataka()
        {
            InitializeComponent();
            con = new SqlConnection(conStr);            
        }

        private void BrisanjePodataka_Load(object sender, EventArgs e)
        {
            helperMethods.DisplayDataInDataGridView(con, allDataQery, dgvBrisanjeRadnika);
            helperMethods.DisableControls(pnlPodaciORadniku);
        }
        private void DgvBrisanjeRadnika_CellClick(object sender, DataGridViewCellEventArgs e)
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
                }

                id = int.Parse(dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtIme.Text = dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrezime.Text = dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpDatumRodenja.Value = ((DateTime)dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[3].Value);
                rbtnMusko.Checked = dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[4].Value.ToString() == "Muško" ? true : false;
                rbtnZensko.Checked = dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[4].Value.ToString() == "Žensko" ? true : false;
                txtMjestoBoravka.Text = dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtBrojPasosa.Text = dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[6].Value.ToString();
                dtpDatumIstekaVize.Value = ((DateTime)dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[7].Value);                
                txtZanimanje.Text = dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtGradiliste.Text = dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[9].Value.ToString();
                dtpNaGradilistuOd.Value = ((DateTime)dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[10].Value);                
                nudPlata.Value = decimal.Parse(dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[11].Value.ToString());
                rbtnDa.Checked = dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[12].Value.ToString() == "Da" ? true : false;
                rbtnNe.Checked = dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[12].Value.ToString() == "Ne" ? true : false;
                lokacijaSlike = dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[13].Value.ToString();
                lokacijaPasosa = dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[14].Value.ToString();
                lokacijaVize = dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[15].Value.ToString();
                lokacijaRadneDozvole = dgvBrisanjeRadnika.Rows[e.RowIndex].Cells[16].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u metodu DgvBrisanjeRadnika_CellClick");
            }
        }

        private void BtnPogledajSliku_Click(object sender, EventArgs e)
        {
            helperMethods.PreviewItem(lokacijaSlike);
        }
        private void BtnPogledajPasos_Click(object sender, EventArgs e)
        {
            helperMethods.PreviewItem(lokacijaPasosa);
        }

        private void BtnPogledajVizu_Click(object sender, EventArgs e)
        {
            helperMethods.PreviewItem(lokacijaVize);
        }

        private void BtnPogledajRadnuDozvolu_Click(object sender, EventArgs e)
        {
            helperMethods.PreviewItem(lokacijaRadneDozvole);
        }

        private void BtnIzbrisiPodatke_Click(object sender, EventArgs e)
        {
            DeleteData();
            helperMethods.ClearForm(pnlPodaciORadniku);
            helperMethods.DisableControls(pnlPodaciORadniku);
        }        
        public void DeleteData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                "delete from Evidencija_radnika where Id_radnika = '" + id + "' ", con);                
                File.Delete(lokacijaSlike);
                File.Delete(lokacijaPasosa);
                File.Delete(lokacijaVize);
                File.Delete(lokacijaRadneDozvole);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Podaci su izbrisani iz baze podataka.");
                helperMethods.DisplayDataInDataGridView(con, allDataQery, dgvBrisanjeRadnika);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "problem u metodu DeleteData ");
                con.Close();
            }            
        }

        private void TxtPodaciZaPretragu_TextChanged(object sender, EventArgs e)
        {
            string ime = txtImeZaPretragu.Text.ToString();
            string prezime = txtPrezimeZaPretragu.Text.ToString();
            try
            {
                string adapterQuery = helperMethods.TableSearch(ime, prezime);
                helperMethods.DisplayDataInDataGridView(con, adapterQuery, dgvBrisanjeRadnika);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u metodu TxtPodaciZaPretragu_TextChanged");                
            }
        }

        private void BtnVratiSeNaIO_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new IzborOperacije();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }
    }
}