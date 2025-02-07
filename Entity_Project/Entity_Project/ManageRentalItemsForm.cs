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
using Microsoft.Data.SqlClient;
using Dapper;

namespace Entity_Project
{
    public partial class ManageRentalItemsForm : Form
    {
        private string connectionString = "Server=DESKTOP-SPT5GG8\\SQLEXPRESS;Database=RentalDB;Trusted_Connection=True;trust server certificate=true";
        public ManageRentalItemsForm()
        {
            InitializeComponent();
            LoadRentalItems();
        }
        private void LoadRentalItems()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM RentalItems";
                var items = connection.Query<RentalItem>(query).ToList();
                dgvRentalItems.DataSource = items;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvRentalItems.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(dgvRentalItems.SelectedRows[0].Cells["Id"].Value);

                using (var connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM RentalItems WHERE Id = @Id";
                    connection.Execute(query, new { Id = itemId });

                    MessageBox.Show("Item Deleted Successfully!");
                    LoadRentalItems();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO RentalItems (Name, Category, PricePerDay, IsAvailable) VALUES (@Name, @Category, @PricePerDay, @IsAvailable)";
                connection.Execute(query, new
                {
                    Name = txtItemName.Text,
                    Category = txtCategory.Text,
                    PricePerDay = decimal.Parse(txtPrice.Text),
                    IsAvailable = chkIsAvailable.Checked
                });

                MessageBox.Show("Item Added Successfully!");
                LoadRentalItems();
                ClearFields();
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (dgvRentalItems.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(dgvRentalItems.SelectedRows[0].Cells["Id"].Value);

                using (var connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE RentalItems SET Name = @Name, Category = @Category, PricePerDay = @PricePerDay, IsAvailable = @IsAvailable WHERE Id = @Id";
                    connection.Execute(query, new
                    {
                        Id = itemId,
                        Name = txtItemName.Text,
                        Category = txtCategory.Text,
                        PricePerDay = decimal.Parse(txtPrice.Text),
                        IsAvailable = chkIsAvailable.Checked
                    });

                    MessageBox.Show("Item Updated Successfully!");
                    LoadRentalItems();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to update.");
            }
        }

        private void ClearFields()
        {
            txtItemName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            chkIsAvailable.Checked = false;
        }
        private void ManageRentalItemsForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvRentalItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRentalItems.Rows[e.RowIndex];
                txtItemName.Text = row.Cells["Name"].Value.ToString();
                txtCategory.Text = row.Cells["Category"].Value.ToString();
                txtPrice.Text = row.Cells["PricePerDay"].Value.ToString();
                chkIsAvailable.Checked = Convert.ToBoolean(row.Cells["IsAvailable"].Value);
            }
        }
    }
}
