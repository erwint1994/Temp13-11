using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using paSSQL;

namespace WindowsFormsApp1
{
    public partial class Gebruiker : Form
    {
        string MyConnectionString2 = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        public new Gebruiker ParentForm { get; set; }
        public Gebruiker ParentForm2 { get; set; }
        // load
        public Gebruiker()
        {
            InitializeComponent();
        }
        public void AddMailUsers_Load(object sender, EventArgs e)
        {
            SelectUsers();
            SelectUsersWFApp();
        }
        // buttons mail van service
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            GebruikerToevoegen gebruikersToevoegen = new GebruikerToevoegen();
            gebruikersToevoegen.Show();
            gebruikersToevoegen.Location = new Point(100, 100);
            if (ParentForm2 != null)
                ParentForm2.Refresh();
            Close();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            SelectUsers();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            GetId();
            GebruikerBewerken gebruikerbewerken= new GebruikerBewerken();
            gebruikerbewerken.Show();
            if (ParentForm2 != null)
                ParentForm2.Refresh();
            Close();
        }
        private void BtnUnban_Click(object sender, EventArgs e)
        {
            UnBanAccountMail();
            SelectUsers();
        }
        private void BtnBan_Click(object sender, EventArgs e)
        {
            BanAccountMail();
            SelectUsers();
        }
        // query (mail service)
        public void SelectUsers()
        {
            dataGridView1.DataSource = SQL.GetSQLDataView("SELECT Id, Email, Voornaam, Tussenvoegsel, Achternaam, Banned FROM tbl_EmailAdress");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 240;
            dataGridView1.Columns[2].Width = 230;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 235;
            dataGridView1.Columns[5].Width = 60;
        }
        public void DeleteRecord()
        {
            using (SqlConnection connection2 = new SqlConnection(MyConnectionString2))
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());
                    string sql = "DELETE FROM tbl_EmailAdress WHERE id=@RowID";
                    SqlCommand deleteRecord = new SqlCommand
                    {
                        Connection = connection2,
                        CommandType = CommandType.Text,
                        CommandText = sql
                    };
                    SqlParameter RowParameter = new SqlParameter
                    {
                        ParameterName = "@RowID",
                        SqlDbType = SqlDbType.Int,
                        IsNullable = false,
                        Value = rowID
                    };
                    deleteRecord.Parameters.Add(RowParameter);
                    deleteRecord.Connection.Open();
                    deleteRecord.ExecuteNonQuery();
                    deleteRecord.Connection.Close();
                }
            }          
        }
        public void GetId()
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Rights.id = id;
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        public void BanAccountMail()
        {
            using (SqlConnection connection2 = new SqlConnection(MyConnectionString2))
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());
                    string sql = "UPDATE tbl_EmailAdress SET Banned=1 WHERE id=@RowID";
                    SqlCommand BanUser = new SqlCommand
                    {
                        Connection = connection2,
                        CommandType = CommandType.Text,
                        CommandText = sql
                    };
                    SqlParameter RowParameter = new SqlParameter
                    {
                        ParameterName = "@RowID",
                        SqlDbType = SqlDbType.Int,
                        IsNullable = false,
                        Value = rowID
                    };
                    BanUser.Parameters.Add(RowParameter);
                    BanUser.Connection.Open();
                    BanUser.ExecuteNonQuery();
                    BanUser.Connection.Close();
                }
            }
                
        }
        public void UnBanAccountMail()
        {
            using (SqlConnection connection2 = new SqlConnection(MyConnectionString2))
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());
                    string sql = "UPDATE tbl_EmailAdress SET Banned=0 WHERE id=@RowID";
                    SqlCommand UnbanUser = new SqlCommand
                    {
                        Connection = connection2,
                        CommandType = CommandType.Text,
                        CommandText = sql
                    };
                    SqlParameter RowParameter = new SqlParameter
                    {
                        ParameterName = "@RowID",
                        SqlDbType = SqlDbType.Int,
                        IsNullable = false,
                        Value = rowID
                    };
                    UnbanUser.Parameters.Add(RowParameter);
                    UnbanUser.Connection.Open();
                    UnbanUser.ExecuteNonQuery();
                    UnbanUser.Connection.Close();
                }
            }
                
        }

        // query (mail wfapp)
        public void DeleteRecordWFApp()
        {
            using (SqlConnection connection2 = new SqlConnection(MyConnectionString2))
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView2.SelectedRows[0].Index;
                    int rowID = int.Parse(dataGridView2[0, selectedIndex].Value.ToString());
                    string sql = "DELETE FROM tbl_EmailAdressWFapp WHERE id=@RowID";
                    SqlCommand deleteRecord = new SqlCommand
                    {
                        Connection = connection2,
                        CommandType = CommandType.Text,
                        CommandText = sql
                    };
                    SqlParameter RowParameter = new SqlParameter
                    {
                        ParameterName = "@RowID",
                        SqlDbType = SqlDbType.Int,
                        IsNullable = false,
                        Value = rowID
                    };
                    deleteRecord.Parameters.Add(RowParameter);
                    deleteRecord.Connection.Open();
                    deleteRecord.ExecuteNonQuery();
                    deleteRecord.Connection.Close();
                }
            }              
        }
        public void SelectUsersWFApp()
        {
            dataGridView2.DataSource = SQL.GetSQLDataView("SELECT Id, Email, Voornaam, Tussenvoegsel, Achternaam, Banned FROM tbl_EmailAdressWFapp");
            this.dataGridView2.Columns[1].ReadOnly = true;
            this.dataGridView2.Columns[2].ReadOnly = true;
            this.dataGridView2.Columns[3].ReadOnly = true;
            this.dataGridView2.Columns[4].ReadOnly = true;
            this.dataGridView2.Columns[5].ReadOnly = true;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Width = 240;
            dataGridView2.Columns[2].Width = 230;
            dataGridView2.Columns[3].Width = 100;
            dataGridView2.Columns[4].Width = 235;
            dataGridView2.Columns[5].Width = 60;
        }
        public void BanAccountMailWFApp()
        {
            using (SqlConnection connection2 = new SqlConnection(MyConnectionString2))
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView2.SelectedRows[0].Index;
                    int rowID = int.Parse(dataGridView2[0, selectedIndex].Value.ToString());
                    string sql = "UPDATE tbl_EmailAdressWFapp SET Banned=1 WHERE id=@RowID";
                    SqlCommand BanUser = new SqlCommand
                    {
                        Connection = connection2,
                        CommandType = CommandType.Text,
                        CommandText = sql
                    };
                    SqlParameter RowParameter = new SqlParameter
                    {
                        ParameterName = "@RowID",
                        SqlDbType = SqlDbType.Int,
                        IsNullable = false,
                        Value = rowID
                    };
                    BanUser.Parameters.Add(RowParameter);
                    BanUser.Connection.Open();
                    BanUser.ExecuteNonQuery();
                    BanUser.Connection.Close();
                }
            }

        }
        public void UnBanAccountMailWFApp()
        {
            using (SqlConnection connection2 = new SqlConnection(MyConnectionString2))
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView2.SelectedRows[0].Index;
                    int rowID = int.Parse(dataGridView2[0, selectedIndex].Value.ToString());
                    string sql = "UPDATE tbl_EmailAdressWFapp SET Banned=0 WHERE id=@RowID";
                    SqlCommand UnbanUser = new SqlCommand
                    {
                        Connection = connection2,
                        CommandType = CommandType.Text,
                        CommandText = sql
                    };
                    SqlParameter RowParameter = new SqlParameter
                    {
                        ParameterName = "@RowID",
                        SqlDbType = SqlDbType.Int,
                        IsNullable = false,
                        Value = rowID
                    };
                    UnbanUser.Parameters.Add(RowParameter);
                    UnbanUser.Connection.Open();
                    UnbanUser.ExecuteNonQuery();
                    UnbanUser.Connection.Close();
                }
            }

        }
        public void GetIdWFApp()
        {
            try
            {
                int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                Rights.id = id;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        // buttons mail wfapp
        private void BtnAdd2_Click(object sender, EventArgs e)
        {
            GebruikerWFToevoegen gebruikerwfToevoegen = new GebruikerWFToevoegen();
            gebruikerwfToevoegen.Show();
            gebruikerwfToevoegen.Location = new Point(100, 100);
            if (ParentForm2 != null)
                ParentForm2.Refresh();
            Close();
        }
        private void BtnEdit2_Click(object sender, EventArgs e)
        {
            GetIdWFApp();
            GebruikersWFBewerken gebruikerwfbewerken = new GebruikersWFBewerken();
            gebruikerwfbewerken.Show();
            if (ParentForm2 != null)
                ParentForm2.Refresh();
            Close();
        }
        private void BtnDelete2_Click(object sender, EventArgs e)
        {
            DeleteRecordWFApp();
            SelectUsersWFApp();
        }
        private void BtnBan2_Click(object sender, EventArgs e)
        {
            BanAccountMailWFApp();
            SelectUsersWFApp();
        }
        private void BtnUnban2_Click(object sender, EventArgs e)
        {
            UnBanAccountMailWFApp();
            SelectUsersWFApp();
        }
    }
}