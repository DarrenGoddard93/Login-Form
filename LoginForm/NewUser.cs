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
using System.Security.Cryptography;
using LoginForm;

namespace LoginApplication
{
    public partial class NewUser : Form
    {  
        public NewUser()
        {
            InitializeComponent();
        }

       
        private void click_AddUser(object sender, EventArgs e)
        {
            string userPassword = text_NewPassword.Text;
     
            if (ValidateNewUserEntry())
            {
                MessageBox.Show("Please enter detials in ALL fields");
            }
            else
            {
                MyDBEntities mde = new MyDBEntities();
                tbl_Login account = new tbl_Login()
                {
                    Username = text_NewUser.Text,
                    Password = BCrypt.Net.BCrypt.HashPassword(userPassword),
                    Name = text_NewName.Text,
                    Email = text_NewEmail.Text
                };
                mde.tbl_Login.Add(account);
                mde.SaveChanges();
                MessageBox.Show("Successful");
              
                NewUser.ActiveForm.Close();
                
            }

        }

        public bool ValidateNewUserEntry()
        {
            if (text_NewUser.Text == "" || text_NewPassword.Text == "" || text_NewName.Text == "")
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

