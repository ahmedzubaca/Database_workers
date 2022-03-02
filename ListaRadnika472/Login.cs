using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ListaRadnika
{
    public partial class Login : Form
    {
        readonly string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        readonly SqlConnection con;
        RegisterLoginHelper regLogHelper = new RegisterLoginHelper();        

        int attemptsNumber = 0;
        public Login()
        {
            InitializeComponent();
            con = new SqlConnection(conStr);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0 || txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Potrebno je da unesete 'Username' i 'Password'!");
            }
            else
            {
                try
                {
                    con.Open();
                    DataTable dtk = new DataTable();
                    SqlDataAdapter sdak = new SqlDataAdapter("SELECT Username FROM RegisterLogin", con);
                    sdak.Fill(dtk);
                    con.Close();

                    List<string> usernamesK = new List<string>();
                    foreach (DataRow dr in dtk.Rows)
                    {
                        usernamesK.Add(dr[0].ToString());
                    }

                    if (!usernamesK.Contains(txtUsername.Text))
                    {
                        if (attemptsNumber < 3)
                        {
                            MessageBox.Show("Neispravan 'Username' i//ili 'Password'. Pokušajte ponovo!");
                            attemptsNumber++;
                        }
                        else
                        {
                            MessageBox.Show("Neispravan 'Username' i/ili 'Password. Imali ste tri neuspiješna pokušaja, molimo pokušajte kasnije!");
                            Application.Exit();
                        }
                    }
                    else
                    {
                        DataTable dtKo = new DataTable();
                        con.Open();
                        SqlDataAdapter sdaKo = new SqlDataAdapter("SELECT * FROM RegisterLogin WHERE Username = '" + txtUsername.Text + "' ", con);
                        sdaKo.Fill(dtKo);
                        con.Close();

                        string storedPassword = dtKo.Rows[0]["Password"].ToString();
                        string storedSalt = dtKo.Rows[0]["Salt"].ToString();

                        if (VerifyPassword(txtPassword.Text, storedPassword, storedSalt))
                        {
                            if (dtKo.Rows[0]["Category"].ToString() == "administrator")
                            {                                
                                Hide();
                                IzborOperacije io = new IzborOperacije();
                                io.Closed += (s, args) => Close();
                                io.Show();
                            }
                            else if (dtKo.Rows[0]["Category"].ToString() == "korisnik")
                            {                                
                                Hide();
                                SortiranjePretragaPodataka spp = new SortiranjePretragaPodataka();
                                spp.Closed += (s, args) => Close();
                                spp.Show();
                                spp.DisableButtonIdiNaIzbOp();
                            }
                        }
                        else
                        {
                            if (attemptsNumber < 3)
                            {
                                MessageBox.Show("Neispravan 'Username' i//ili 'Password'. Pokušajte ponovo!");
                                attemptsNumber++;
                            }
                            else
                            {
                                MessageBox.Show("Neispravan 'Username' i/ili 'Password. Imali ste tri neuspiješna pokušaja, molimo pokušajte kasnije!");
                                Application.Exit();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnRegistrujNovogKorisnika_Click(object sender, EventArgs e)
        {
            Hide();
            Register re = new Register();
            re.Closed += (s, args) => Close();
            re.Show();
        }

        private void BtnPromijeniPassword_Click(object sender, EventArgs e)
        {
            Size = new Size(530, 650);
            pnlPromjenaPassworda.Visible = true;
        }

        private void BtnSnimiNoviPassword_Click(object sender, EventArgs e)
        {
            if (txtUsernamePP.Text.Length == 0 || txtStariPassword.Text.Length == 0
                || txtNoviPassword.Text.Length == 0)
            {
                MessageBox.Show("Potrebno je da popunite sva polja!");
            }
            else
            {
                try
                {
                    con.Open();
                    DataTable dtk = new DataTable();
                    SqlDataAdapter sdak = new SqlDataAdapter("SELECT Username FROM RegisterLogin", con);
                    sdak.Fill(dtk);
                    con.Close();

                    List<string> usernamesK = new List<string>();
                    foreach (DataRow dr in dtk.Rows)
                    {
                        usernamesK.Add(dr[0].ToString());
                    }

                    if (!usernamesK.Contains(txtUsernamePP.Text))
                    {
                        if (attemptsNumber < 3)
                        {
                            MessageBox.Show("Neispravan 'Username' i/ili 'Password'. Pokušajte ponovo!");
                            attemptsNumber++;
                        }
                        else
                        {
                            MessageBox.Show("Neispravan 'Username' i/ili 'Password. Imali ste tri neuspiješna pokušaja, molimo pokušajte kasnije!");
                            Application.Exit();
                        }
                    }
                    else
                    {
                        DataTable dtKo = new DataTable();
                        con.Open();
                        SqlDataAdapter sdaKo = new SqlDataAdapter("SELECT * FROM RegisterLogin WHERE Username = '" + txtUsernamePP.Text + "' ", con);
                        sdaKo.Fill(dtKo);
                        con.Close();

                        string storedPassword = dtKo.Rows[0]["Password"].ToString();
                        string storedSalt = dtKo.Rows[0]["Salt"].ToString();

                        if (VerifyPassword(txtStariPassword.Text, storedPassword, storedSalt))
                        {
                            if (txtNoviPassword.Text.Equals(txtPotvrdiNoviPassword.Text))
                            {
                                byte[] salt = regLogHelper.CreateSalt();
                                string hashedPassword = regLogHelper.GenerateHash(txtNoviPassword.Text, salt);
                                string saltForDb = Convert.ToBase64String(salt);

                                con.Open();
                                SqlCommand cmd = new SqlCommand("UPDATE RegisterLogin SET Password = '" + hashedPassword + "'," +
                                    " Salt = '" + saltForDb + "' WHERE Username = '" + txtUsernamePP.Text + "'", con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Uspješno ste zamijenili password");
                                txtUsernamePP.Text = ""; txtStariPassword.Text = ""; txtNoviPassword.Text = "";
                                txtPotvrdiNoviPassword.Text = "";
                                Size = new Size(530, 350);
                                pnlPromjenaPassworda.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Niste tačno potvrdili novi password, pokušajte ponovo");
                            }
                        }
                        else
                        {
                            if (attemptsNumber < 3)
                            {
                                MessageBox.Show("Neispravan 'Username' i/ili 'Password' i /ili 'Kategorija korisnika'. Pokušajte ponovo!");
                                attemptsNumber++;
                            }
                            else
                            {
                                MessageBox.Show("Imali ste tri neuspiješna pokušaja, molimo pokušajte kasnije!");
                                Application.Exit();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private static bool VerifyPassword(string loggedPassword, string storedHash, string storedSalt)
        {
            var saltBytes = Convert.FromBase64String(storedSalt);
            //var some = new Rfc2898DeriveBytes(loggedPassword, saltBytes, 10000);
            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                   password: loggedPassword,
                   salt: saltBytes,
                   prf: KeyDerivationPrf.HMACSHA256,
                   iterationCount: 100000,
                   numBytesRequested: 256 / 8));

            return hashedPassword.Equals(storedHash);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}