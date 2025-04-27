using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Solmile.Models;
using SolmileAPI.Models;

namespace Solmile
{
    public class DataContext : DbContext
    {
        public DataContext(){}

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<Room> Room { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Employee>().ToTable("Employees");

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.User)
                .WithOne(u => u.Employee)
                .HasForeignKey<Employee>(e => e.Id)
                .OnDelete(DeleteBehavior.Restrict);

                modelBuilder.Entity<Customer>()
               .HasMany(c => c.Complaints)
               .WithOne(c => c.Customer)
               .HasForeignKey(c => c.CustomerId);

                modelBuilder.Entity<Customer>()
                    .HasMany(c => c.Reservations)
                    .WithOne(r => r.Customer)
                    .HasForeignKey(r => r.CustomerId);

            modelBuilder.Entity<Customer>()
                    .HasMany(c => c.ServiceRequests)
                    .WithOne(s => s.Requestor) 
                    .HasForeignKey(s => s.RequestorId);

                modelBuilder.Entity<ServiceRequest>()
                    .HasOne(sr => sr.ServiceType)
                    .WithMany(st => st.ServiceRequests)
                    .HasForeignKey(sr => sr.ServiceTypeId);

                modelBuilder.Entity<Complaint>()
                   .HasOne(c => c.Employee)
                   .WithMany(e => e.Complaints)
                   .HasForeignKey(c => c.EmployeeId)
                   .OnDelete(DeleteBehavior.SetNull);

                modelBuilder.Entity<Reservation>()
                    .HasOne(r => r.Payment) 
                    .WithOne(p => p.Reservation)  
                    .HasForeignKey<Reservation>(r => r.PaymentId)  
                    .OnDelete(DeleteBehavior.Restrict);
            
                    modelBuilder.Entity<Reservation>()
                    .HasOne(r => r.Customer) // A reservation is associated with one customer
                    .WithMany(c => c.Reservations) // A customer can have many reservations
                    .HasForeignKey(r => r.CustomerId);

            //Ensuring customer and reservation link with 1:1
                    modelBuilder.Entity<Reservation>()
                    .HasOne(r => r.Room)
                    .WithOne(room => room.Reservation) 
                    .HasForeignKey<Reservation>(r => r.RoomId)  
                    .OnDelete(DeleteBehavior.Restrict);

            // PaymentMethod and Payment relationship (1:1)
                    modelBuilder.Entity<PaymentMethod>()
                    .HasOne(pm => pm.Payment) // One PaymentMethod has one Payment
                    .WithOne(p => p.PaymentMethod) // One Payment has one PaymentMethod
                    .HasForeignKey<Payment>(p => p.MethodId); // Foreign key in Payment

                    modelBuilder.Entity<Room>()
                    .HasOne(r => r.RoomTypes)  // Room has one RoomType
                   .WithMany()                // RoomType does not have a navigation property back to Room
                   .HasForeignKey(r => r.RoomTypeId) // Foreign key to RoomType
                   .OnDelete(DeleteBehavior.Restrict);

        }

    }
}
