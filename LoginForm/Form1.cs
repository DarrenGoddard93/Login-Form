using LoginApplication;
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
using DevOne.Security.Cryptography.BCrypt;


namespace LoginForm
{
    public partial class Form1 : Form
    {
        NewUser newUser = new NewUser();

        private MyDBEntities DBEntities = new MyDBEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void click_Login(object sender, EventArgs e)
        {
            var login = Log(text_username.Text, text_password.Text);

            if(login == null)
            {
                MessageBox.Show("Failed");
            }
            else
            {
                MessageBox.Show("Successful");
            }
        }

        private tbl_Login Log(string username, string passw)
        {
            var login = DBEntities.tbl_Login.SingleOrDefault(a => a.Username.Equals(username));

            if(login != null)
            {
                if (BCrypt.Net.BCrypt.Verify(passw, login.Password))
                {
                    return login;
                }
            }
            return null;
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
