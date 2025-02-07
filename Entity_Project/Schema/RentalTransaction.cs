using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project.Schema
{
    public class RentalTransaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RentalItemId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal TotalPrice { get; set; }

        public User User { get; set; }
        public RentalItem RentalItem { get; set; }
    }
}
