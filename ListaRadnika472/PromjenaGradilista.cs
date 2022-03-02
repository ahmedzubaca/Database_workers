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
    public partial class PromjenaGradilista : Form
    {
        readonly string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        readonly SqlConnection con;
        int id;
        readonly string sviPodaciQuery = "SELECT * FROM Evidencija_radnika";        
        HelperMethods helperMethods = new HelperMethods();

        public PromjenaGradilista()
        {
            InitializeComponent();
            con = new SqlConnection(conStr);
        }
        private void PromjenaGradilista_Load(object sender, EventArgs e)
        {
            helperMethods.DisplayDataInDataGridView(con, sviPodaciQuery, DgvPromjenaGradilista);
            foreach (Control ctrl in PnlPodaciORadniku.Controls)
            {
                ctrl.Enabled = false;
            }
        }
        private void DgvPromjenaGradilista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (Control ctrl in PnlPodaciORadniku.Controls)
                {
                    ctrl.Enabled = true;
                    
                    if (ctrl is DateTimePicker dtp)
                    {
                        dtp.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        dtp.CustomFormat = "yyyy-MM-dd";
                    }
                }

                id = int.Parse(DgvPromjenaGradilista.Rows[e.RowIndex].Cells[0].Value.ToString());
                
                txtStaroGradiliste.Text = DgvPromjenaGradilista.Rows[e.RowIndex].Cells[9].Value.ToString();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u metodu DgvPromjenaGradilista_CellClick");
            }
        }

        private void btnVratiSeNaIzOp_Click(object sender, EventArgs e)
        {
            Hide();
            IzborOperacije io = new IzborOperacije();
            io.Closed += (s, args) => Close();
            io.Show();
        }
        private void BtnSnimiIzmjene_Click(object sender, EventArgs e)
        {
            DataRecord();
            helperMethods.ClearForm(PnlPodaciORadniku);
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
            if (txtNovoGradiliste.Text == "" || dtpDatumZavrsetkaStaGra.Value == null || dtpDatumPocetkaNoGra.Value == null)
                
            {
                MessageBox.Show("Molim popunite sva polja!");
            }
            else
            {
                try
                {                    
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Gradilišta_i_datumi" +
                        "Naziv_gradilišta = '" + txtNovoGradiliste.Text + "', " +                        
                        "Početak_rada = '" + dtpDatumPocetkaNoGra.Value.Date.ToString("yyyy-MM-dd") + "'," +
                        "Završetak_rada = '" + dtpDatumZavrsetkaStaGra.Value.Date.ToString("yyyy-mm-dd") +
                        "WHERE Id = '" + id + "' ", con);
                    cmd.ExecuteNonQuery();

                    if (dtpDatumZavrsetkaStaGra.Value != null)
                    {                        
                        SqlCommand cmd1 = new SqlCommand("UPDATE Gradilišta_i_datumi SET" +
                        "Završetak_rada = '" + dtpDatumZavrsetkaStaGra.Value.Date.ToString("yyyy-mm-dd") +
                        "WHERE Naziv_gradilišta = '" +txtStaroGradiliste+ "' ", con);
                        cmd.ExecuteNonQuery();
                    }                    
                    con.Close();
                    MessageBox.Show("Podaci su uneseni u bazu podataka.");
                    helperMethods.DisplayDataInDataGridView(con, sviPodaciQuery, DgvPromjenaGradilista);
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
                helperMethods.DisplayDataInDataGridView(con, adapterQuery, DgvPromjenaGradilista);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u metodu TxtPodaciZaPretragu_TextChanged");
            }
        }
    }
}