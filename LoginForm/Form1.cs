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
    public partial class Form1 : Form
    {
        NewUser newUser = new NewUser();

        public Form1()
        {
            InitializeComponent();
        }

        private void click_Login(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = DESKTOP-EF0N0LL\\SQLEXPRESS;Initial Catalog=My_Database;Integrated Security=True";

            SqlCommand CheckDB = new SqlCommand("Select * from tbl_Login where Username = @username and Password = @password", connection);

            CheckDB.Parameters.AddWithValue("@username", text_username.Text);
            CheckDB.Parameters.AddWithValue("@password", text_password.Text);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(CheckDB);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            connection.Open();

            int count = dataSet.Tables[0].Rows.Count;

            connection.Close();

            if (count == 1)
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Login Not Successful. Try Again");
            }

        }

        private void toggle_ShowPassword(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
            {
                text_password.UseSystemPasswordChar = false;
            }
            else if (ShowPasswordCheckBox.Checked == false)
            {
                text_password.UseSystemPasswordChar = true;
            }

        }

        private void click_SignUp(object sender, EventArgs e)
        {
            newUser.Show();
        }
    }
}
