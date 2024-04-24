using Microsoft.EntityFrameworkCore;
using OrmTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmTask.DAL
{
    internal class DataContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HPCK2O7;Database=Car;Trusted_Connection=true;TrustServerCertificate=True");
        }
    }
}
