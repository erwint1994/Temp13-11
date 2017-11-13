using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GebruikerToevoegen : Form
    {
        string MyConnectionString2 = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public GebruikerToevoegen()
        {
            InitializeComponent();
        }
        public void BtnVerzenden_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbVoornaam.Text))
            {
                MessageBox.Show("Voornaam niet ingevuld.");
            }
            else if (String.IsNullOrEmpty(TxbAchternaam.Text))
            {
                MessageBox.Show("Achternaam is niet ingevuld.");
            }
            else if (String.IsNullOrEmpty(TxbEmail.Text) || Regex.IsMatch(TxbEmail.Text.Trim(), "^[a-zA-Z]*@") && TxbEmail.Text == ".")
            {
                MessageBox.Show("Geen geldig email adres.");
            }
            else
            {
                SqlConnection connection = new SqlConnection(MyConnectionString2);
                SqlCommand cmd;
                connection.Open();
                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = ("INSERT INTO tbl_EmailAdress (Email, Voornaam, Achternaam, Tussenvoegsel, Banned) VALUES (@email,@voornaam,@achternaam, @tussenvoegsel, @banned);");
                    cmd.Parameters.AddWithValue("@banned", 0);
                    cmd.Parameters.AddWithValue("@email", TxbEmail.Text);
                    cmd.Parameters.AddWithValue("@voornaam", txbVoornaam.Text);
                    cmd.Parameters.AddWithValue("@achternaam", TxbAchternaam.Text);
                    cmd.Parameters.AddWithValue("@tussenvoegsel", TxbTussenvoegsel.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                connection.Close();
                this.Close();
            }          
        }

        private void GebruikerToevoegen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Gebruiker form2 = new Gebruiker();
            form2.Show();
        }
    }
}
