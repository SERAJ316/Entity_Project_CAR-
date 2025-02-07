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
    public partial class HistoryForm : Form
    {
        private User currentUser;
        public HistoryForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadRentalHistory();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
        
        }
        private void LoadRentalHistory()
        {
            using (var context = new AppDbContext())
            {
                var history = context.RentalTransactions
                                     .Where(t => t.UserId == currentUser.Id)
                                     .Select(t => new
                                     {
                                         t.Id,
                                         ItemName = t.RentalItem.Name,
                                         t.RentDate,
                                         t.ReturnDate,
                                         t.TotalPrice
                                     })
                                     .ToList();
                dgvHistory.DataSource = history;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
