using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

using System.Text.Json;
using System.Text.Json.Serialization;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SolmileGuesthouseAPI.Data.Models;
using System.Text.Json;

namespace SolmileGuesthouseAPI.Data
{
    public class GuesthouseDbContext : DbContext
    {
        public GuesthouseDbContext(DbContextOptions<GuesthouseDbContext> options) : base(options)
        {
        }

     
        public DbSet<Branch> Branches { get; set; }
        public DbSet<ContactDetails> ContactDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomNumberAssignment> RoomNumberAssignments { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships and constraints

            // Configure RoomType's TypeId to not be auto-generated
            modelBuilder.Entity<RoomType>()
                .Property(r => r.TypeId)
                .ValueGeneratedNever(); // This disables identity/auto-increment
         // Configure ServiceType's ServiceTypeId to not be auto-generated
            modelBuilder.Entity<ServiceType>()
                .Property(r => r.ServiceTypeId)
                .ValueGeneratedNever(); // This disables identity/auto-increment

            // Add this configuration for unique Username
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();


            // Configure the inheritance
            modelBuilder.Entity<Employee>()
                .HasBaseType<User>()
                .HasOne(e => e.Branch)
                .WithMany(b => b.Employees)
                .HasForeignKey(e => e.BranchId);

            // Branch to ContactDetails (one-to-one)
            modelBuilder.Entity<Branch>()
                .HasOne(b => b.ContactDetails)
                .WithOne()
                .HasForeignKey<Branch>(b => b.ContactId);
                
            // Branch to RoomNumberAssignments (one-to-many)
            modelBuilder.Entity<Branch>()
                .HasMany(b => b.RoomNumberAssignments)
                .WithOne(r => r.Branch)
                .HasForeignKey(r => r.BranchId);
                
            // Branch to Employees (one-to-many)
            modelBuilder.Entity<Branch>()
                .HasMany(b => b.Employees)
                .WithOne(e => e.Branch)
                .HasForeignKey(e => e.BranchId);
                
            // RoomNumberAssignment to Rooms (one-to-many)
            modelBuilder.Entity<RoomNumberAssignment>()
                .HasMany(r => r.Rooms)
                .WithOne(r => r.RoomNumberAssignment)
                .HasForeignKey(r => r.RoomNumberAssignmentId);
                
            // RoomType to Rooms (one-to-many)
            modelBuilder.Entity<RoomType>()
                .HasMany(rt => rt.Rooms)
                .WithOne(r => r.RoomType)
                .HasForeignKey(r => r.TypeId);
                
            // Customer to Reservations (one-to-many)
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Reservations)
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.CustomerId);


            modelBuilder.Entity<ServiceRequest>()
    .HasOne(sr => sr.Reservation)
    .WithMany(c => c.ServiceRequests)
    .HasForeignKey(sr => sr.ReservationId)
    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ServiceRequest>()
                .HasOne(sr => sr.Employee)
                .WithMany(e => e.ServiceRequests)
                .HasForeignKey(sr => sr.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Room to Reservations (one-to-many)
            modelBuilder.Entity<Room>()
                .HasMany(r => r.Reservations)
                .WithOne(res => res.Room)
                .HasForeignKey(res => res.RoomId);
                
                
            // ServiceType to ServiceRequests (one-to-many)
            modelBuilder.Entity<ServiceType>()
                .HasMany(st => st.ServiceRequests)
                .WithOne(sr => sr.ServiceType)
                .HasForeignKey(sr => sr.ServiceTypeId);
                
            // ServiceRequest to Tasks (one-to-many)
            modelBuilder.Entity<ServiceRequest>()
                .HasMany(sr => sr.Tasks)
                .WithOne(t => t.ServiceRequest)
                .HasForeignKey(t => t.RequestId);
                
            // ServiceRequest to Rating (one-to-one)
            modelBuilder.Entity<ServiceRequest>()
                .HasOne(sr => sr.Rating)
                .WithOne(r => r.ServiceRequest)
                .HasForeignKey<Rating>(r => r.ServiceRequestId);
                
            // Employee to Tasks (one-to-many)
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Tasks)
                .WithOne(t => t.Employee)
                .HasForeignKey(t => t.EmployeeId);
                
            // Employee to Ratings (one-to-many)
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.RatingsReceived)
                .WithOne(r => r.Employee)
                .HasForeignKey(r => r.EmployeeId);

            //// Configure DateOnly properties (requires EF Core 6.0+)
            //modelBuilder.Entity<Customer>()
            //    .Property(c => c.DateOfBirth)
            //    .HasConversion<DateOnlyConverter, DateOnlyComparer>();

            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.DateOfBirth)
            //    .HasConversion<DateOnlyConverter, DateOnlyComparer>();

            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.HireDate)
            //    .HasConversion<DateOnlyConverter, DateOnlyComparer>();

            //modelBuilder.Entity<Reservation>()
            //    .Property(r => r.CheckInDate)
            //    .HasConversion<DateOnlyConverter, DateOnlyComparer>();

            //modelBuilder.Entity<Reservation>()
            //    .Property(r => r.CheckOutDate)
            //    .HasConversion<DateOnlyConverter, DateOnlyComparer>();

            //modelBuilder.Entity<Rating>()
            //    .Property(r => r.RatingDate)
            //    .HasConversion<DateOnlyConverter, DateOnlyComparer>();

        }
    }

    //public class DateOnlyJsonConverter : JsonConverter<DateOnly>
    //{
    //    private const string Format = "yyyy-MM-dd";

    //    public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    //    {
    //        return DateOnly.Parse(reader.GetString());
    //    }

    //    public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
    //    {
    //        writer.WriteStringValue(value.ToString(Format));
    //    }
    //}

    //public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    //{
    //    public DateOnlyConverter() : base(
    //        dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue),
    //        dateTime => DateOnly.FromDateTime(dateTime))
    //    { }
    //}

    //public class DateOnlyComparer : ValueComparer<DateOnly>
    //{
    //    public DateOnlyComparer() : base(
    //        (d1, d2) => d1 == d2 && d1.DayNumber == d2.DayNumber,
    //        d => d.GetHashCode())
    //    { }
    //}

}
