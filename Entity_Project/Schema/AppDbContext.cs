using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Project.Schema
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<RentalItem> RentalItems { get; set; }
        public DbSet<RentalTransaction> RentalTransactions { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SPT5GG8\SQLEXPRESS;Database=RentalDB;Trusted_Connection=True;trust server certificate=true");
        }
    }
}
