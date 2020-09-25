namespace LoginApplication
{
    partial class NewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.text_NewUser = new System.Windows.Forms.TextBox();
            this.text_NewPassword = new System.Windows.Forms.TextBox();
            this.text_NewName = new System.Windows.Forms.TextBox();
            this.text_NewEmail = new System.Windows.Forms.TextBox();
            this.label_NewUserTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(412, 260);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(75, 23);
            this.btn_AddUser.TabIndex = 0;
            this.btn_AddUser.Text = "Add User";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.click_AddUser);
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(227, 154);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(91, 20);
            this.label_Username.TabIndex = 1;
            this.label_Username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(232, 180);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(86, 20);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(263, 206);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(55, 20);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Name";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(263, 234);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(53, 20);
            this.label_Email.TabIndex = 4;
            this.label_Email.Text = "Email";
            // 
            // text_NewUser
            // 
            this.text_NewUser.Location = new System.Drawing.Point(324, 154);
            this.text_NewUser.Name = "text_NewUser";
            this.text_NewUser.Size = new System.Drawing.Size(163, 20);
            this.text_NewUser.TabIndex = 5;
            // 
            // text_NewPassword
            // 
            this.text_NewPassword.Location = new System.Drawing.Point(324, 180);
            this.text_NewPassword.Name = "text_NewPassword";
            this.text_NewPassword.Size = new System.Drawing.Size(163, 20);
            this.text_NewPassword.TabIndex = 6;
            // 
            // text_NewName
            // 
            this.text_NewName.Location = new System.Drawing.Point(324, 208);
            this.text_NewName.Name = "text_NewName";
            this.text_NewName.Size = new System.Drawing.Size(163, 20);
            this.text_NewName.TabIndex = 7;
            // 
            // text_NewEmail
            // 
            this.text_NewEmail.Location = new System.Drawing.Point(324, 234);
            this.text_NewEmail.Name = "text_NewEmail";
            this.text_NewEmail.Size = new System.Drawing.Size(163, 20);
            this.text_NewEmail.TabIndex = 8;
            // 
            // label_NewUserTitle
            // 
            this.label_NewUserTitle.AutoSize = true;
            this.label_NewUserTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewUserTitle.Location = new System.Drawing.Point(163, 54);
            this.label_NewUserTitle.Name = "label_NewUserTitle";
            this.label_NewUserTitle.Size = new System.Drawing.Size(409, 55);
            this.label_NewUserTitle.TabIndex = 9;
            this.label_NewUserTitle.Text = "Create New User";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.label_NewUserTitle);
            this.Controls.Add(this.text_NewEmail);
            this.Controls.Add(this.text_NewName);
            this.Controls.Add(this.text_NewPassword);
            this.Controls.Add(this.text_NewUser);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.btn_AddUser);
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox text_NewUser;
        private System.Windows.Forms.TextBox text_NewPassword;
        private System.Windows.Forms.TextBox text_NewName;
        private System.Windows.Forms.TextBox text_NewEmail;
        private System.Windows.Forms.Label label_NewUserTitle;
    }
}