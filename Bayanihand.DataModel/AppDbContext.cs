using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Almirol
            optionsBuilder.UseSqlServer("server=GYALAPTOP\\SQLEXPRESS; " +
                "database=almirol_entprog; uid=eisensy_student; " +
                "pwd=Benilde@2020; integrated security=sspi; " +
                "trustservercertificate=true");

            // Gamoras

            // Hacinas

            // Lab
            //optionsBuilder.UseSqlServer("server=DESKTOP-EDG1IN1\\SQLEXPRESS; " +
            //    "database=eisensy_csbentprog; uid=eisensy_student; " +
            //    "pwd=Benilde@2020; integrated security=sspi; " +
            //    "trustservercertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationINV>().Property(s => s.DateApplied).HasColumnType("datetime2(7)");

            modelBuilder.Entity<CheckInINV>().HasKey(c => c.CheckInID);
            modelBuilder.Entity<CheckInINV>().Property(s => s.DateCheckedIn).HasColumnType("datetime2(7)");
            modelBuilder.Entity<CheckInINV>().Property(s => s.DateCheckedOut).HasColumnType("datetime2(7)").IsRequired(false);

            modelBuilder.Entity<ForumINV>().Property(s => s.DatePosted).HasColumnType("datetime2(7)");
            modelBuilder.Entity<ForumINV>().Property(s => s.DateEdited).HasColumnType("datetime2(7)").IsRequired(false);

            modelBuilder.Entity<InquiryINV>().Property(s => s.DateInquired).HasColumnType("datetime2(7)");

            modelBuilder.Entity<PaymentProofINV>().Property(s => s.DatePaid).HasColumnType("datetime2(7)");

            modelBuilder.Entity<ReferralINV>().Property(s => s.DateReferred).HasColumnType("datetime2(7)");
            modelBuilder.Entity<ReferralINV>().Property(s => s.DateEdited).HasColumnType("datetime2(7)");

            modelBuilder.Entity<ScheduleINV>().Property(s => s.DateBooked).HasColumnType("datetime2(7)");
            modelBuilder.Entity<ScheduleINV>().Property(s => s.StartTime).HasColumnType("datetime2(7)").IsRequired(false);
            modelBuilder.Entity<ScheduleINV>().Property(s => s.EndTime).HasColumnType("datetime2(7)").IsRequired(false);

        }
        public DbSet<HandymanINV> HandymanINV { get; set; }
        public DbSet<CustomerINV> CustomerINV { get; set; }

        public DbSet<ForumINV> ForumINV { get; set; }
        public DbSet<ApplicationINV> ApplicationINV { get; set; }
        public DbSet<CheckInINV> CheckInINV { get; set; }
        public DbSet<ScheduleINV> ScheduleINV { get; set; }
        public DbSet<JobClassINV> JobClassINV { get; set; }
        public DbSet<ReferralINV> ReferralINV { get; set; }
        public DbSet<InquiryINV> InquiryINV { get; set; }
        public DbSet<PaymentProofINV> PaymentProofINV { get; set; }
    }
}
