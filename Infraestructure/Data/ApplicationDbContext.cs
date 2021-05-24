using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    // public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //the way to set multiple Primary Key (Key annotation)
            modelBuilder.Entity<CustomerCustomerDemo>().HasKey(r => new { r.CustomerID, r.CustomerTypeID });
            modelBuilder.Entity<EmployeeTerritories>().HasKey(r => new { r.EmployeeID, r.TerritoryID });
            modelBuilder.Entity<OrderDetails>().HasKey(r => new { r.OrderID, r.ProductID });
        }


        //Tables
        public DbSet<Categories> Categories { get; set; }
        public DbSet<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }
        public DbSet<CustomerDemographics> CustomerDemographics { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<EmployeeTerritories> EmployeeTerritories { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Shippers> Shippers { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Territories> Territories { get; set; }



    }
}
