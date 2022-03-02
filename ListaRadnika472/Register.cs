using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ListaRadnika
{
    public partial class Register : Form
    {
        readonly string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        readonly SqlConnection con;
        readonly RegisterLoginHelper regLogHelper = new RegisterLoginHelper();
        public Register()
        {
            InitializeComponent();
            con = new SqlConnection(conStr);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.Length == 0 || txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Molimo unesute 'Username' i 'Password'!");
            }
            else
            {
                try
                {
                    con.Open();
                    DataTable dtr = new DataTable();
                    SqlDataAdapter sdar = new SqlDataAdapter("SELECT Username FROM RegisterLogin", con);
                    sdar.Fill(dtr);
                    con.Close();

                    List<string> usernamesR = new List<string>();
                    foreach (DataRow dr in dtr.Rows)
                    {
                        usernamesR.Add(dr[0].ToString());
                    }

                    if (usernamesR.Contains(txtUsername.Text))
                    {
                        MessageBox.Show($"Username '{txtUsername.Text}' već postoji. Molimo izaberite drugi username.!");
                    }
                    else
                    {
                        byte[] salt = regLogHelper.CreateSalt();
                        string hashedPassword = regLogHelper.GenerateHash(txtPassword.Text, salt);
                        string saltForDb = Convert.ToBase64String(salt);

                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO RegisterLogin (Username, Password, Salt)" +
                            " VALUES('" + txtUsername.Text + "', '" + hashedPassword + "', '" + saltForDb + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Registracija uspješno izvršena!");

                        Hide();
                        Login log = new Login();                         
                        log.Closed += (s, args) => Close();
                        log.Show();                        
                    }               
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }                      
        }
    }
}
