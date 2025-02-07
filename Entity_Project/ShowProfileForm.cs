using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Entity_Project.Schema;
using System;
namespace Entity_Project
{
    public partial class ShowProfileForm : Form
    {
        private Entity_Project.Schema.User currentUser;
        public ShowProfileForm(Entity_Project.Schema.User user)
        {
            InitializeComponent();
            currentUser = user;
            lblDisplayName.Text = currentUser.FullName;
            lblDisplayEmail.Text = currentUser.Email;
        }

        private void ShowProfileForm_Load(object sender, EventArgs e)
        {
            lblDisplayName.Text = currentUser.FullName;
            lblDisplayEmail.Text = currentUser.Email;
        }
        public void RefreshProfile()
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == currentUser.Id);
                if (user != null)
                {
                    lblDisplayName.Text = user.FullName;
                    lblDisplayEmail.Text = user.Email;
                }
            }
        }


        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            Edit_Profile editProfileForm = new Edit_Profile(currentUser, this); // Pass reference of ShowProfileForm (this)
            editProfileForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(currentUser);
            dashboardForm.Show();
        }
    }
}
