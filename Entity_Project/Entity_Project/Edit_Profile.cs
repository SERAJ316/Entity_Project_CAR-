using Entity_Project.Schema;
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
    public partial class Edit_Profile : Form
    {
        private User currentUser;
        private ShowProfileForm showProfileForm;

        public Edit_Profile(User user, ShowProfileForm profileForm)
        {
            InitializeComponent();
            currentUser = user;
            showProfileForm = profileForm; // Store the reference to ShowProfileForm

            txtFullName.Text = currentUser.FullName;
            txtEmail.Text = currentUser.Email;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == currentUser.Id);
                if (user != null)
                {
                    // Update profile details (FullName, Email, etc.)
                    user.FullName = txtFullName.Text;
                    user.Email = txtEmail.Text;

                    // Check if password change is requested
                    if (!string.IsNullOrEmpty(txtOldPassword.Text) ||
                        !string.IsNullOrEmpty(txtNewPassword.Text) ||
                        !string.IsNullOrEmpty(txtConfirm.Text))
                    {
                        // Validate old password
                        if (user.Password != txtOldPassword.Text)
                        {
                            MessageBox.Show("Old password is incorrect.");
                            return;
                        }

                        // Validate new password and confirm password match
                        if (txtNewPassword.Text != txtConfirm.Text)
                        {
                            MessageBox.Show("New password and confirm password do not match.");
                            return;
                        }

                        // Validate new password strength (optional)
                        if (txtNewPassword.Text.Length < 6) // Example: Minimum 6 characters
                        {
                            MessageBox.Show("New password must be at least 6 characters long.");
                            return;
                        }

                        // Update password
                        user.Password = txtNewPassword.Text;
                    }

                    // Save changes to the database
                    context.SaveChanges();

                    // After saving the changes, refresh the profile on the ShowProfileForm
                    if (showProfileForm != null)
                    {
                        showProfileForm.RefreshProfile();
                    }

                    // Optionally close the form or provide feedback
                    MessageBox.Show("Profile updated successfully.");
                    this.Hide();
                    showProfileForm.Show();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowProfileForm profileForm = new ShowProfileForm(currentUser);
            profileForm.Show();
        }

        private void Edit_Profile_Load(object sender, EventArgs e)
        {

        }

        private void lblOldPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
