using finalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Data
{
    public class finalProjectContext: DbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Reservation> Reservation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLOCALDB;Database=Reservations;Trusted_Connection=True;");
        }
    }
}
