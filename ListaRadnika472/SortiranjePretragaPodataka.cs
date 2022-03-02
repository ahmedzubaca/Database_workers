using System;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace ListaRadnika
{
    public partial class SortiranjePretragaPodataka : Form
    {
        readonly string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        readonly SqlConnection con;
        
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;
        int totalrecord = 0;

        readonly HelperMethods helperMethods = new HelperMethods();
        readonly string allDataQuery = "SELECT *, DATEDIFF(DAY, Na_gradilištu_od, GETDATE())" +
            " as Vrijeme_provedeno_na_gradilištu, DATEDIFF(DAY, GETDATE(), Datum_isteka_vize)" +
            " as Dana_do_isteka_vize FROM Evidencija_radnika";
        public SortiranjePretragaPodataka()
        {
            InitializeComponent();
            con = new SqlConnection(conStr);
        }

        private void SortiranjePretraga_Load(object sender, EventArgs e)
        {
            helperMethods.DisplayDataInDataGridView(con, allDataQuery, dgvSortiranjePretragaPodataka);
            helperMethods.PopulateCombobox(con, cbZanimanje, "Zanimanja_katalog", "Naziv_zanimanja", "");
            helperMethods.PopulateCombobox(con, cbGradiliste, "Gradilišta_katalog", "Naziv_gradilišta", "");
            cbManjeViseGradiliste.Items.Add("<=");
            cbManjeViseGradiliste.Items.Add(">=");
            cbManjeViseViza.Items.Add("<=");
            cbManjeViseViza.Items.Add(">=");
        }
        private void DgvSortiranjePretragaPodataka_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {            
            for (int i = 0; i < dgvSortiranjePretragaPodataka.Rows.Count; i++)
            {
                dgvSortiranjePretragaPodataka.Rows[i].Cells["RedniBroj"].Value = (i + 1).ToString();
            }            
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.DefaultPageSettings.Landscape = true;
                dgvSortiranjePretragaPodataka.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument1;
                printDialog.UseEXDialog = true;
                if (DialogResult.OK == printDialog.ShowDialog())
                {
                    printDocument1.DocumentName = "Test Page Print";
                    printDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrintDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;
                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dgvSortiranjePretragaPodataka.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            try
            {                
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dgvSortiranjePretragaPodataka.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                        (double)iTotalWidth * (double)iTotalWidth *
                                        ((double)e.MarginBounds.Width / (double)iTotalWidth))));
                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                                            GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= dgvSortiranjePretragaPodataka.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dgvSortiranjePretragaPodataka.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    double totalcount = Convert.ToDouble(iRow) % Convert.ToDouble(20);
                    if (totalcount == 0 && iRow != 0 && totalrecord == 0)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        totalrecord = 1;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            e.Graphics.DrawString("Lista radnika", new Font(dgvSortiranjePretragaPodataka.Font, FontStyle.Bold),
                                                                Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                                                e.Graphics.MeasureString("Lista radnika", new Font(dgvSortiranjePretragaPodataka.Font,
                                                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            e.Graphics.DrawString(strDate, new Font("Microsoft Sans Serif", 9, FontStyle.Regular),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font("Microsoft Sans Serif", 9, FontStyle.Regular),
                                    e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Lista radnika", new Font("Microsoft Sans Serif", 9, FontStyle.Regular),
                                    e.MarginBounds.Width).Height - 13);
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dgvSortiranjePretragaPodataka.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular),
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                var type = Cel.Value.GetType();
                                if(type.Equals(typeof(DateTime)))
                                {
                                    e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular),
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                                }
                                else
                                {
                                    e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular),
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                                }                                
                            }
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }

                    iRow++;
                    iTopMargin += iCellHeight;
                    totalrecord = 0;
                }
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvSortiranjePretragaPodataka.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;            
        }
        
        private void BtnExportToExcel_Click(object sender, EventArgs e)
        {
            helperMethods.OpenTableInExcel(dgvSortiranjePretragaPodataka);
        }

        private void BtnIdiNaIzborOperacije_Click(object sender, EventArgs e)
        {
            IzborOperacije io = new IzborOperacije();
            io.Show();
            this.Hide();
        }

        public void DisableButtonIdiNaIzbOp()
        {
            btnIdiNaIzborOperacije.Visible = false;            
        }

        private void BtnPretraziTabelu_Click(object sender, EventArgs e)           
        {
            try
            {
                string poTrajanjuVize = PretragaPoTrajanju("Datum_isteka_vize", cbManjeViseViza, txtDanaDoIstekaVize.Text);
                string poDanimaNaGradilistu = PretragaPoTrajanju("Na_gradilištu_od", cbManjeViseGradiliste, txtDanaNaGradilistu.Text);
                string aktivanDa = rbtnDa.Checked ? "Da" : "";
                string aktivanNe = rbtnNe.Checked ? "Ne" : "";

                string query = $"SELECT *,DATEDIFF(DAY, Na_gradilištu_od, GETDATE())" +
                                " as Vrijeme_provedeno_na_gradilištu, DATEDIFF(DAY, GETDATE(), Datum_isteka_vize)" +
                                $" as Dana_do_isteka_vize FROM Evidencija_radnika " +
                    "WHERE ( '" + cbZanimanje.Text + "' = 'Izaberi naziv zanimanja' OR Zanimanje ='" + cbZanimanje.Text + "') " +
                    "AND ( '" + cbGradiliste.Text + "' = 'Izaberi naziv gradilišta' OR Gradilište = '" + cbGradiliste.Text + "') " +
                    "AND ('" + txtIme.Text.Length + "' = 0 OR Ime LIKE '%" + txtIme.Text + "%') " +
                    "AND ('" + txtPrezime.Text.Length + "' = 0 OR Prezime LIKE '%" + txtPrezime.Text + "%') " +
                    $" {poTrajanjuVize}" +
                    $" {poDanimaNaGradilistu}" + 
                    "AND('"+aktivanDa.Length+"' = 0 OR Aktivan = '"+aktivanDa+"')" +
                    "AND('"+aktivanNe.Length+"' = 0 OR Aktivan = '"+aktivanNe+"')";                

                helperMethods.DisplayDataInDataGridView(con, query, dgvSortiranjePretragaPodataka);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string PretragaPoTrajanju (string nazivKolone, ComboBox manjeVise, string danaUnos)
        {
            try
            {
                string poTrajanju = "";

                if (manjeVise.Text == "Izaberi uslov" || String.IsNullOrEmpty(danaUnos))
                {
                    poTrajanju = "";
                }
                else if (manjeVise.Text != "Izaberi uslov" && !String.IsNullOrEmpty(danaUnos))
                {
                    if (int.TryParse(danaUnos, out int dana))
                    {
                        if (manjeVise.Name == "cbManjeViseViza")
                        {
                            poTrajanju = $"AND DATEDIFF(day,GETDATE(), {nazivKolone}) {manjeVise.Text} {dana}";
                        }
                        else if(manjeVise.Name == "cbManjeViseGradiliste")
                        {
                            poTrajanju = $"AND DATEDIFF(day,{nazivKolone},GETDATE()) {manjeVise.Text} {dana}";
                        }                        
                    }
                    else
                    {
                        if (manjeVise.Name == "cbManjeViseViza")
                        {
                            txtDanaDoIstekaVize.BackColor = Color.Red;
                        }
                        else if (manjeVise.Name == "cbManjeViseGradiliste")
                        {
                            txtDanaNaGradilistu.BackColor = Color.Red;
                        }
                        MessageBox.Show("U polje broj dana unesite broj!");
                    }
                }
                return poTrajanju;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        private void TxtDanaDoIstekaVize_Enter(object sender, EventArgs e)
        {
            txtDanaDoIstekaVize.BackColor = Color.White;
        }

        private void TxtDanaNaGradilistu_Enter(object sender, EventArgs e)
        {
            txtDanaNaGradilistu.BackColor = Color.White;
        }

        private void BtnResetujFiltere_Click(object sender, EventArgs e)
        {
            cbZanimanje.Text = "Izaberi naziv zanimanja";
            cbGradiliste.Text = "Izaberi naziv gradilišta";
            txtIme.Text = "";
            txtPrezime.Text = "";
            cbManjeViseViza.Text = "Izaberi uslov";
            cbManjeViseGradiliste.Text = "Izaberi uslov";
            txtDanaDoIstekaVize.Text = "";
            txtDanaNaGradilistu.Text = "";
            rbtnDa.Checked = false;
            rbtnNe.Checked = false;

            helperMethods.DisplayDataInDataGridView(con, allDataQuery, dgvSortiranjePretragaPodataka);
        }
               
        private void BtnIdiNapojedinacniPregled_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnIdiNaIzborOperacije.Visible == false)
                {
                    PojedinacniPregled pp = new PojedinacniPregled();
                    pp.Show();
                    pp.HideIdiNaIzborOperacije();
                } 
                else
                {
                    this.Hide();
                    PojedinacniPregled pp = new PojedinacniPregled();
                    pp.Closed += (s, args) => this.Close();
                    pp.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}