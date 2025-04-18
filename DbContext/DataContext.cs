using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Solmile.Models;

namespace Solmile
{
    public class DataContext : DbContext
    {
        public DataContext(){}

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            //modelBuilder.Entity<User>()
            //    .ToTable("Users");
            //modelBuilder.Entity<Employee>()
            //    .ToTable("Employees");
            //modelBuilder.Entity<Employee>()
            //   .HasOne(e => e.User)
            //   .WithOne(u=>u.Employee)
            //   .HasForeignKey<User>(u => u.Id);
        }

        }
}
