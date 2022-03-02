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
    public partial class IzborOperacije : Form
    {
        readonly string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        readonly SqlConnection con;
        readonly HelperMethods helperMethods = new HelperMethods();
        readonly string allDataQuery = "SELECT *, DATEDIFF(DAY, Na_gradilištu_od, GETDATE())" +
            " as Vrijeme_provedeno_na_gradilištu, DATEDIFF(DAY, GETDATE(), Datum_isteka_vize)" +
            " as Dana_do_isteka_vize FROM Evidencija_radnika";
       
        public IzborOperacije()
        {
            InitializeComponent();            
            con = new SqlConnection(conStr);
            
        }

        private void IzborOperacije_Load(object sender, EventArgs e)
        {
            helperMethods.DisplayDataInDataGridView(con, allDataQuery, dgvPrikazPodatakaORadnicima);            
        }

        private void DgvPrikazPodatakaORadnicima_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            helperMethods.InsertSerialNumbers(dgvPrikazPodatakaORadnicima);
        }

        private void btnDodajRadnika_Click(object sender, EventArgs e)
        {            
            Hide();
            DodajRadnika dr = new DodajRadnika();
            dr.Closed += (s, args) => Close();
            dr.Show();
        }

        private void btnIzbrisiRadnika_Click(object sender, EventArgs e)
        {
            Hide();
            BrisanjePodataka bp = new BrisanjePodataka();
            bp.Closed += (s, args) => Close();
            bp.Show();
        }

        private void btnIspraviPogresanUnos_Click(object sender, EventArgs e)
        {
            Hide();
            IzmjenaPodataka ipu = new IzmjenaPodataka();
            ipu.Closed += (s, args) => Close();
            ipu.Show();
        }
        private void BtnPretraziSortirajPodatke_Click(object sender, EventArgs e)
        {
            Hide();
            SortiranjePretragaPodataka spp = new SortiranjePretragaPodataka();
            spp.Closed += (s, args) => Close();
            spp.Show();
        }

        private void btnKatalozi_Click(object sender, EventArgs e)
        {
            Hide();
            KatalogZanimanjaIGradilista kat = new KatalogZanimanjaIGradilista();
            kat.Closed += (s, args) => Close();
            kat.Show();
        }

        private void BtnPojedinacniPregled_Click(object sender, EventArgs e)
        {
            this.Hide();
            PojedinacniPregled pp = new PojedinacniPregled();
            pp.Closed += (s, args) => this.Close();
            pp.Show();
        }

        private void btnOtvoriTabeluUExcelu_Click(object sender, EventArgs e)
        {
            helperMethods.OpenTableInExcel(dgvPrikazPodatakaORadnicima);
        }        
    }
}
