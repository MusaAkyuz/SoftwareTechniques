using ChooseDbContextGeneric.Models.VehicleModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDbContextGeneric.Contexts
{
    internal class VehicleContext : DbContext
    {
        public VehicleContext()
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-LL28F6L;Database=VehicleDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Bycycle> Bycycle { get; set; }
    }
}
