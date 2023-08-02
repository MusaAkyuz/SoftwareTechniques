using CodeFirst_Migrations.Models.SchoolDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Migrations.Context
{
    internal class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=desktop-ll28f6l;Database=School;Trusted_Connection=True;TrustServerCertificate=True;");
        }


        DbSet<Student> Student { get; set; }
        DbSet<Grade> Grade { get; set; }
    }
}
