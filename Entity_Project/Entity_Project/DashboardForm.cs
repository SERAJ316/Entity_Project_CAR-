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
    public partial class DashboardForm : Form
    {
        private User currentUser;
        public DashboardForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblWelcome.Text = "Welcome, " + currentUser.FullName;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ShowProfileForm profileForm = new ShowProfileForm(currentUser);
            profileForm.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnForm returnForm = new ReturnForm(currentUser);
            returnForm.Show();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowseItems browseItemsForm = new BrowseItems(currentUser);
            browseItemsForm.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(currentUser);
            historyForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginForm = new login();
            loginForm.Show();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
