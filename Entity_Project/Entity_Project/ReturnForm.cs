using Entity_Project.Schema;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public partial class ReturnForm : Form
    {
        private User currentUser;

        public ReturnForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRentalId.Text, out int rentalId))
            {
                using (var context = new AppDbContext())
                {
                    var transaction = context.RentalTransactions
                                             .Include(t => t.RentalItem)  // Ensure the RentalItem is loaded
                                             .FirstOrDefault(t => t.Id == rentalId && t.UserId == currentUser.Id);

                    if (transaction != null && transaction.ReturnDate == null)
                    {
                        transaction.ReturnDate = DateTime.Now;

                        if (transaction.RentalItem != null) // Ensure RentalItem is not null
                        {
                            transaction.RentalItem.IsAvailable = true;
                        }

                        context.SaveChanges();
                        MessageBox.Show("Item returned successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Rental ID or item already returned.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Rental ID.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {

        }
    }
}
