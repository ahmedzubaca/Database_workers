using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ListaRadnika
{
    internal class HelperMethods
    {
        readonly string allDataQuery = "SELECT *, DATEDIFF(DAY, Na_gradilištu_od, GETDATE()) as Vrijeme_provedeno_na_gradilištu," +
            " DATEDIFF(DAY, Datum_isteka_vize, GETDATE()) as Dana_do_isteka_vize FROM Evidencija_radnika";

        public void ChooseFile(TextBox tb)
        {
            try
            {
                tb.ReadOnly = false;
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;
                    tb.Text = imageLocation;
                    tb.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u klasi HelperMethods u metodu ChooseFile!");
                throw;
            }
        }

        public void PreviewItem(string path)
        {
            try
            {
                Process.Start("explorer.exe", path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u klasi HelperMethods u metodu PreviewItem!");
                throw;
            }
        }
        public void SaveItemToFile(TextBox tb, string path)
        {
            try
            {
                File.Copy(tb.Text, path);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u HelperMethod clasi u metodu SaveItemToFile!");
                throw;
            }            
        }
        public int DateSubtraction(DateTime date1, DateTime date2)
        {
            try
            {
                TimeSpan difference = date1 - date2;
                return difference.Days;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u HelperMethod clasi u metodu DateSubtraction!");
                throw;               
            }            
        }
        public void ClearForm(Panel pnl)
        {
            try
            {
                foreach (Control ctrl in pnl.Controls)
                {
                    if (ctrl is TextBox tb)
                    {
                        tb.Text = "";
                    }
                    else if(ctrl is ComboBox cb)
                    {
                        cb.ForeColor = Color.Silver;
                        cb.ResetText();

                        if(cb.Name == "cbZanimanje")
                        {
                            cb.Text = "Izaberi zanimanje";
                        }
                        else if(cb.Name == "cbGradiliste")
                        {
                            cb.Text = "Izaberi gradilište";
                        }
                    }
                    else if (ctrl is DateTimePicker dtp)
                    {
                        dtp.Tag = 0;
                        dtp.CustomFormat = " ";                       
                    }
                    else if (ctrl is NumericUpDown nud)
                    {
                        nud.Value = 0.00M;
                        nud.ForeColor = Color.Silver;
                    }
                    else if (ctrl.HasChildren)
                    {
                        foreach (Control ct in ctrl.Controls)
                        {
                            if (ct is RadioButton rb)
                            {
                                rb.Checked = false;
                            }
                        }
                    }
                    else if(ctrl.Name == "btnVratiSeNaIO")
                    {
                        ctrl.Enabled = true;
                    }
                    else if (pnl.Name == "pnlUnosPodataka")
                    {
                        ctrl.Enabled = true;
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u klasi HelperMethods u metodu ClearForm!");
                throw;
            }

        }

        public void DisableControls(Panel pnl)
        {
            foreach (Control ctrl in pnl.Controls)
            {
                ctrl.Enabled = false;                

                if (ctrl is DateTimePicker dtp)
                {
                    dtp.CustomFormat = " ";
                    dtp.Format = DateTimePickerFormat.Custom;
                    ctrl.Enabled = false;
                }
                else if (ctrl.Name == "btnVratiSeNaIO")
                {
                    ctrl.Enabled = true;
                }                
            }        
        }    

        public string TableSearch (string ime, string prezime)
        {
            string adapterQuery = allDataQuery;
            
            try
            {
                if (ime.Length == 0 && prezime.Length == 0)
                {
                    adapterQuery = allDataQuery;
                }
                else if (ime.Length > 0 && prezime.Length == 0)
                {
                    adapterQuery = $"{allDataQuery} WHERE Ime LIKE '%" + ime + "%'";
                }
                else if (ime.Length == 0 && prezime.Length > 0)
                {
                    adapterQuery = $"{allDataQuery} WHERE Prezime LIKE '%" + prezime + "%'";
                }
                else if (ime.Length > 0 && prezime.Length > 0)
                {
                    adapterQuery = $"{allDataQuery} WHERE Ime LIKE '%" + ime + "%'" +
                        "AND Prezime LIKE '%" + prezime + "%'";
                }

                return adapterQuery;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u metodu TableSearch!");
                throw;
            }
        }

        public void DisplayDataInDataGridView(SqlConnection con, string query, DataGridView dgv)
        {
            try
            {
                SqlDataAdapter sdaPodaci;
                DataTable dt = new DataTable();
                con.Open();
                sdaPodaci = new SqlDataAdapter(query, con);
                sdaPodaci.Fill(dt);
                dgv.AutoGenerateColumns = false;
                dgv.Columns["Datum_rođenja"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgv.Columns["Datum_isteka_vize"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgv.Columns["Na_gradilištu_od"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgv.DataSource = dt;                              
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u klasi HelperMethods u metodu DisplayDataInDataGridView!");
                con.Close();
                throw;
            }
        }

        public string LokacijaDokumenta(string commonPath, string document, string firstLocationOfDocument)
        {
            try
            {
                string lokacijaDokumenta = Path.Combine(commonPath + document, DateTime.Now.ToString("yyyyMMddHHmmssffff") + "-" +
                                           Path.GetFileName(firstLocationOfDocument));

                return lokacijaDokumenta;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u klasi HelperMethods u metodu LokacijaDokumenta!");
                throw;
            }
            
        }

        public string StringForSqlCommand( string columnHeaderName, string lokacijaDokumenta, int id)
        {
            try
            {
                string sqlCommandString = $"UPDATE Evidencija_radnika SET {columnHeaderName} = '"+ lokacijaDokumenta + "' " + " " +
                $"WHERE Id_radnika = {id} ";

                return sqlCommandString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u klasi HelperMethods u metodu StringForSqlCommand!");
                throw;
            }
        }
        public void InsertSerialNumbers (DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }
        public void PopulateCombobox(SqlConnection con,  ComboBox cb, string nazivTabele, string nazivKolone, string nazivKataloga = null)
        {
            try
            {
                SqlDataReader sdr;
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * from {nazivTabele}", con);
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    cb.Items.Add(sdr[nazivKolone]);
                }
                if(!string.IsNullOrEmpty(nazivKataloga))
                {
                    cb.Items.Add($"Dodaj novo {nazivKataloga}");
                }                                
                con.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem u metodu PopulateCombobox!");
                con.Close();
            }
        }

        public void OpenTableInExcel(DataGridView dgv)
        {
            try
            {
                dgv.SelectAll();
                DataObject copyData = dgv.GetClipboardContent();
                if (copyData != null)
                {
                    Clipboard.SetDataObject(copyData);

                }
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlApp.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook xlWbook;
                Microsoft.Office.Interop.Excel.Worksheet xlSheet;
                object missedData = System.Reflection.Missing.Value;
                xlWbook = xlApp.Workbooks.Add(missedData);

                xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range xlRange = (Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[1, 1];
                xlRange.Select();

                xlSheet.PasteSpecial(xlRange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}