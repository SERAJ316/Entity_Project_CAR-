using Entity_Project.Schema;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Entity_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var email = txtEmail.Text.Trim();
                var password = txtPassword.Text;

                var user = context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
                if (user != null)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();

                    if (user.IsAdmin)
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else
                    {
                        DashboardForm dashboardForm = new DashboardForm(user);
                        dashboardForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password.");
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                // Set PasswordChar to empty string, making password visible
                txtPassword.PasswordChar = '\0'; // Empty char makes password visible
            }
            else
            {
                // Set PasswordChar back to '*' to hide password
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
