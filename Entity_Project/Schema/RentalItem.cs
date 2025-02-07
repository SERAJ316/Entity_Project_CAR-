using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project.Schema
{
    public class RentalItem
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string Category { get; set; }
        public decimal PricePerDay { get; set; }
        public bool IsAvailable { get; set; }
    }
}
