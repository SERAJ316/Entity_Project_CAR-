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
    public partial class ManageUsersForm : Form
    {
        private AppDbContext context;

        public ManageUsersForm()
        {
            InitializeComponent();
            context = new AppDbContext();
            LoadUsers();
        }
        private void LoadUsers()
        {
            dgvUsers.DataSource = context.Users.Select(u => new
            {
                u.Id,
                u.FullName,
                u.Email,
                u.IsAdmin
            }).ToList();
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var newUser = new User
            {
                FullName = txtFullName.Text.Trim(),
                Email = textEmail.Text.Trim(),
                Password = textPassword.Text,
                IsAdmin = chkIsAdmin.Checked
            };

            context.Users.Add(newUser);
            context.SaveChanges();
            MessageBox.Show("User Added Successfully!");
            LoadUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["Id"].Value);
                var user = context.Users.Find(userId);

                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                    MessageBox.Show("User Deleted Successfully!");
                    LoadUsers();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["Id"].Value);
                var user = context.Users.Find(userId);

                if (user != null)
                {
                    user.FullName = txtFullName.Text.Trim();
                    user.Email = textEmail.Text.Trim();
                    user.Password = textPassword.Text;
                    user.IsAdmin = chkIsAdmin.Checked;

                    context.SaveChanges();
                    MessageBox.Show("User Updated Successfully!");
                    LoadUsers();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtFullName.Text = dgvUsers.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                textEmail.Text = dgvUsers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                chkIsAdmin.Checked = (bool)dgvUsers.Rows[e.RowIndex].Cells["IsAdmin"].Value;
            }
        }
    }
}
