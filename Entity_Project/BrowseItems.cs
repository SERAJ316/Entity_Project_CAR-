using Entity_Project.Schema;
using Microsoft.VisualBasic.Logging;
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
    public partial class BrowseItems : Form
    {
        private User currentUser;
        private List<RentalItem> rentalItems;
        public BrowseItems(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadAvailableItems();
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAvailableItems()
        {
            using (var context = new AppDbContext())
            {
                rentalItems = context.RentalItems.Where(item => item.IsAvailable).ToList();
                dgvItems.DataSource = rentalItems;
            }
        }

        private void BrowseItems_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(dgvItems.SelectedRows[0].Cells["Id"].Value);
                RentalItem rentalItem = rentalItems.FirstOrDefault(r => r.Id == itemId);

                if (rentalItem != null)
                {
                    RentForm rentForm = new RentForm(currentUser, rentalItem);
                    rentForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Rental item not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to rent.");
            }
        }
        //private RentalItem GetRentalItemById(int id)
        //{
        //    // Get the RentalItem by ID from the list
        //    return rentalItems.FirstOrDefault(r => r.Id == id);
        //}

        //private List<RentalItem> GetAvailableRentalItems()
        //{
        //    using (var context = new AppDbContext())
        //    {
        //        // Fetch available rental items
        //        return context.RentalItems
        //                       .Where(item => item.IsAvailable)
        //                       .ToList(); // Convert to List<RentalItem>
        //    }
        //}

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
