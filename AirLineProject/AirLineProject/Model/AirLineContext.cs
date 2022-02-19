using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject
{
    public class AirLineContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=AirLineProject2;user=root;password=24434123Ayomide");
        }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<AirCraft> AirCrafts { get; set; }
        public DbSet<Booking> Bookings { get; set; }

    }
}
