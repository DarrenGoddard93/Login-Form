using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void click_AddUser(object sender, EventArgs e)
        {
            if (ValidateNewUserEntry())
            {
                MessageBox.Show("Please enter detials in ALL fields");
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source = DESKTOP-EF0N0LL\\SQLEXPRESS;Initial Catalog=My_Database;Integrated Security=True";

                connection.Open();
                SqlCommand AddSQLUser = new SqlCommand("INSERT INTO tbl_Login (Username, Password, Name, Email) values(@username, @password, @name, @email)", connection);
                AddSQLUser.Parameters.AddWithValue("@username", text_NewUser.Text);
                AddSQLUser.Parameters.AddWithValue("@password", text_NewPassword.Text);
                AddSQLUser.Parameters.AddWithValue("@name", text_NewName.Text);
                AddSQLUser.Parameters.AddWithValue("@email", text_NewEmail.Text);

                AddSQLUser.ExecuteNonQuery();
                connection.Close();
                NewUser.ActiveForm.Close();
            }
        }

            public bool ValidateNewUserEntry()
            {
                if (text_NewUser.Text == "" || text_NewPassword.Text == "" || text_NewName.Text == "" || text_NewEmail.Text == "")
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        
    }
}
