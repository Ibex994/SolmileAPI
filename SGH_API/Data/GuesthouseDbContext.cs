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
using static System.Net.WebRequestMethods;

namespace SolmileGuesthouseAPI.Data
{
    public class GuesthouseDbContext : DbContext
    {
        public GuesthouseDbContext(DbContextOptions<GuesthouseDbContext> options) : base(options){}
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

        // Abdelas Branch Additional Tables
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Payroll> Payroll { get; set; }
        public DbSet<Tax> Taxs { get; set; }
        public DbSet<FeedBack> Feedback { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<PaymentMethod> paymentMethods { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<EmployeeAttendance> EmployeeAttendances { get; set; }
        public DbSet<YearlyRatingsSummary> yearlyRatingsSummaries { get; set; }
        public DbSet<MonthlyAttendanceSummary> monthlyAttendanceSummaries { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Role>Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<TaxBracket> TaxBrackets { get; set; }
        public DbSet<OTP> Otps { get; set; }



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

            // Payment and PaymentMethod relationship (1:*)
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.PaymentMethod)
                .WithMany(pm => pm.Payments)
                .HasForeignKey(p => p.MethodId)
                .OnDelete(DeleteBehavior.Restrict);
            // Payroll
            modelBuilder.Entity<Payroll>()
                .HasOne(p => p.Employee)
                .WithMany(e => e.Payrolls)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Payroll>(entity =>
            {
                entity.Property(p => p.BasicSalary).HasPrecision(18, 2);
                entity.Property(p => p.Allowances).HasPrecision(18, 2);
                entity.Property(p => p.Tax).HasPrecision(18, 2);
                entity.Property(p => p.Deductions).HasPrecision(18, 2);
                entity.Property(p => p.NetSalary).HasPrecision(18, 2);
            });
            //Tax
            modelBuilder.Entity<Tax>()
                 .HasOne(t => t.Employee)
                 .WithMany(e => e.Taxs)
                 .HasForeignKey(t => t.EmployeeId)
                 .OnDelete(DeleteBehavior.Cascade);

            // Feedback
            modelBuilder.Entity<FeedBack>()
                   .Property(f => f.Rating)
                   .HasColumnType("decimal(3, 1)");

            modelBuilder.Entity<FeedBack>()
                .HasOne(f => f.Customer)
                .WithMany(c => c.Feedbacks)
                .HasForeignKey(f => f.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FeedBack>()
                .HasOne(f => f.Reservation)
                .WithMany(r => r.Feedbacks)
                .HasForeignKey(f => f.ReservationId)
                .OnDelete(DeleteBehavior.Cascade);

            // Attendance → Employee
            modelBuilder.Entity<EmployeeAttendance>()
                .HasOne(ea => ea.Employee)
                .WithMany(e => e.EmployeeAttendances)
                .HasForeignKey(ea => ea.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeAttendance>()
                .HasOne(ea => ea.Attendance)
                .WithMany(a => a.EmployeeAttendances)
                .HasForeignKey(ea => ea.AttendanceId)
                .OnDelete(DeleteBehavior.Restrict);

            // MonthlyAttendanceSummary
            modelBuilder.Entity<MonthlyAttendanceSummary>()
                .HasOne(s => s.Employee)
                .WithMany(e => e.MonthlySummaries)
                .HasForeignKey(s => s.EmployeeId);

            // YearlyRatingsSummary
            modelBuilder.Entity<YearlyRatingsSummary>()
                .HasOne(y => y.Employee)
                .WithOne(e => e.YearlyRatingsSummary)
                .HasForeignKey<YearlyRatingsSummary>(y => y.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
            //Log
            modelBuilder.Entity<Log>()
                .Property(l => l.Level)
                .HasConversion<string>();

            modelBuilder.Entity<Log>()
                .HasOne(l => l.Performer)
                .WithMany(e => e.Logs)
                .HasForeignKey(l => l.PerformedBy)
                .OnDelete(DeleteBehavior.Cascade);

            // One Attendance has many EmployeeAttendances
            modelBuilder.Entity<Attendance>()
                .HasMany(a => a.EmployeeAttendances)
                .WithOne(ea => ea.Attendance)
                .HasForeignKey(ea => ea.AttendanceId);

            // Unique constraint: one entry per employee per date
            modelBuilder.Entity<EmployeeAttendance>()
                .HasIndex(ea => new { ea.EmployeeId, ea.AttendanceId })
                .IsUnique();

            // Attendance → EmployeeAttendances
            modelBuilder.Entity<Attendance>()
                .HasMany(a => a.EmployeeAttendances)
                .WithOne(ea => ea.Attendance)
                .HasForeignKey(ea => ea.AttendanceId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee → EmployeeAttendances
            modelBuilder.Entity<EmployeeAttendance>()
                .HasOne(ea => ea.Employee)
                .WithMany(e => e.EmployeeAttendances)
                .HasForeignKey(ea => ea.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
            //Reservation Payment
            modelBuilder.Entity<Reservation>()
                    .HasOne(r => r.Payment)
                    .WithOne(p => p.Reservation)
                    .HasForeignKey<Payment>(p => p.ReservationId)
                    .OnDelete(DeleteBehavior.Restrict);

            // Role And UserRole
            modelBuilder.Entity<UserRole>()
        .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);

        }
    }
}
