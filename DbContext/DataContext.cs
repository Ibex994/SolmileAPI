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
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomTypes> RoomTypes { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<RoomAssignment> RoomAssignments { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<EmployeeTask> EmployeeTasks { get; set; }
        public DbSet<Payroll> Payroll { get; set; }
        public DbSet<Tax> Taxs { get; set; }
        public DbSet<FeedBack> Feedback { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<EmployeeAttendance> EmployeeAttendances { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<YearlyRatingsSummary> yearlyRatingsSummaries { get; set; }
        public DbSet<MonthlyAttendanceSummary> monthlyAttendanceSummaries { get; set; }
        public DbSet<Log> Logs { get; set; }


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
            .HasOne(r => r.Customer)
            .WithMany(c => c.Reservations)
            .HasForeignKey(r => r.CustomerId);

            //Ensuring customer and reservation link with 1:1
            modelBuilder.Entity<Reservation>()
            .HasOne(r => r.Room)
            .WithOne(room => room.Reservation)
            .HasForeignKey<Reservation>(r => r.RoomId)
            .OnDelete(DeleteBehavior.Restrict);

            // PaymentMethod and Payment relationship (1:1)
            modelBuilder.Entity<PaymentMethod>()
            .HasOne(pm => pm.Payment)
            .WithOne(p => p.PaymentMethod)
            .HasForeignKey<Payment>(p => p.MethodId);

            modelBuilder.Entity<Room>()
            .HasOne(r => r.RoomTypes)
           .WithMany()
           .HasForeignKey(r => r.RoomTypeId)
           .OnDelete(DeleteBehavior.Restrict);

            // Room Assignment
            modelBuilder.Entity<RoomAssignment>()
            .HasOne(ra => ra.Room)
            .WithMany(r => r.RoomAssignments)
            .HasForeignKey(ra => ra.RoomID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RoomAssignment>()
            .HasOne(ra => ra.Branch)
            .WithMany(b => b.RoomAssignments)
            .HasForeignKey(ra => ra.BranchId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RoomAssignment>()
                .HasOne(ra => ra.RoomType)
                .WithMany(rt => rt.RoomAssignments)
                .HasForeignKey(ra => ra.RoomTypeId)
                .OnDelete(DeleteBehavior.Restrict);
            //branch 
            modelBuilder.Entity<Branch>()
             .HasMany(b => b.ContactDetails)
             .WithOne(cd => cd.Branch)
             .HasForeignKey(cd => cd.BranchId)
             .OnDelete(DeleteBehavior.SetNull);
            // Task
            modelBuilder.Entity<EmployeeTask>()
                    .HasOne(t => t.Employees)
                    .WithMany(e => e.EmployeeTasks)
                    .HasForeignKey(t => t.EmployeeId)
                    .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ServiceRequest>()
            .HasOne(sr => sr.EmployeeTask)
            .WithMany(t => t.ServiceRequests)
            .HasForeignKey(sr => sr.TaskId)
            .OnDelete(DeleteBehavior.SetNull);

            // Payroll
            modelBuilder.Entity<Payroll>()
                .HasOne(p => p.Employee)
                .WithMany(e => e.Payrolls)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
            //Tax
            modelBuilder.Entity<Tax>()
                 .HasOne(t => t.Employee)
                 .WithMany(e => e.Taxs)
                 .HasForeignKey(t => t.EmployeeId)
                 .OnDelete(DeleteBehavior.Cascade);

            // Feedback
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

            // Attendance
            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Employee)
                .WithMany(e => e.Attendances)
                .HasForeignKey(a => a.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // MonthlyAttendanceSummary
            modelBuilder.Entity<MonthlyAttendanceSummary>()
                .HasOne(m => m.Employee)
                .WithOne(e => e.MonthlyAttendanceSummary)
                .HasForeignKey<MonthlyAttendanceSummary>(m => m.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Rating
            modelBuilder.Entity<Ratings>()
                .HasOne(r => r.Employee)
                .WithMany(e => e.Ratings)
                .HasForeignKey(r => r.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

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

            modelBuilder.Entity<Attendance>()
                 .HasMany(a => a.EmployeeAttendances)
                 .WithOne(ea => ea.Attendance)
                 .HasForeignKey(ea => ea.AttendanceId)
                 .OnDelete(DeleteBehavior.Cascade);
            // Employee Attendance
            // Configure Employee ↔ EmployeeAttendance relationship
            modelBuilder.Entity<EmployeeAttendance>()
                .HasOne(ea => ea.Employee)
                .WithMany(e => e.EmployeeAttendances)
                .HasForeignKey(ea => ea.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
