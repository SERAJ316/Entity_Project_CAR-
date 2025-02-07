﻿using Entity_Project.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Project
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var fullName = txtFullName.Text.Trim();
                var email = txtEmail.Text.Trim();
                var password = txtPassword.Text;

                if (context.Users.Any(u => u.Email == email))
                {
                    MessageBox.Show("Email is already registered!");
                    return;
                }

                var user = new User { FullName = fullName, Email = email, Password = password, IsAdmin = false };
                context.Users.Add(user);
                context.SaveChanges();

                MessageBox.Show("Registration Successful!");
                this.Hide();
                login loginForm = new login();
                loginForm.Show();
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
           login loginForm = new login();
            loginForm.Show();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
