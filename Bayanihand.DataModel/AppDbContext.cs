using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.DataModel
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Almirol
                optionsBuilder.UseSqlServer("server=GYALAPTOP\\SQLEXPRESS; " +
                    "database=almirol_entprog; uid=eisensy_student; " +
                    "pwd=Benilde@2020; integrated security=sspi; " +
                    "trustservercertificate=true");

                // Gamoras
                //optionsBuilder.UseSqlServer("server=LAPTOP-FRGK3TF6\\SQLEXPRESS; " +
                //    "database=ENTPROG-Finals; Integrated Security=true; " +
                //    "trustservercertificate=true");

                // Hacinas
                //optionsBuilder.UseSqlServer(
                //"Server=DESKTOP-5FF6P8K\\SQLEXPRESS;" +
                //"Database=ENTPROG-Finals; Integrated Security=SSPI;" +
                //"TrustServerCertificate=true");

                // Lab
                //optionsBuilder.UseSqlServer("server=DESKTOP-EDG1IN1\\SQLEXPRESS; " +
                //    "database=eisensy_csbentprog; uid=eisensy_student; " +
                //    "pwd=Benilde@2020; integrated security=sspi; " +
                //    "trustservercertificate=true");
            }
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
            // Customer can have many forum post
            modelBuilder.Entity<ForumINV>().HasOne(p => p.Customer)
                .WithMany(p => p.ForumPost).HasForeignKey(p => p.CustomerID).OnDelete(DeleteBehavior.Restrict);
            // Forum post can have many handyman recommended
            modelBuilder.Entity<HandymanINV>().HasOne(p => p.ForumPost)
                .WithMany(p => p.Handyman).HasForeignKey(p => p.HandymanID).OnDelete(DeleteBehavior.Restrict);
            // Forum post can have many applications submitted
            modelBuilder.Entity<HandymanINV>().HasOne(p => p.ForumPost)
                .WithMany(p => p.Handyman).HasForeignKey(p => p.HandymanID).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InquiryINV>().Property(s => s.DateInquired).HasColumnType("datetime2(7)");

            modelBuilder.Entity<PaymentProofINV>().Property(s => s.DatePaid).HasColumnType("datetime2(7)");

            modelBuilder.Entity<ReferralINV>().Property(s => s.DateReferred).HasColumnType("datetime2(7)");
            modelBuilder.Entity<ReferralINV>().Property(s => s.DateEdited).HasColumnType("datetime2(7)");
            // Handyman can have many referrals
            modelBuilder.Entity<ScheduleINV>().HasOne(p => p.Handyman)
                .WithMany(p => p.Schedule).HasForeignKey(p => p.HandymanID).OnDelete(DeleteBehavior.Restrict);
            // Customer can post many referrals
            modelBuilder.Entity<ScheduleINV>().HasOne(p => p.Customer)
                .WithMany(p => p.Schedule).HasForeignKey(p => p.CustomerID).OnDelete(DeleteBehavior.Restrict);
            // Forum post can only have one referral posted
            modelBuilder.Entity<ForumINV>().HasOne(p => p.Referral)
                .WithOne(p => p.ForumPost).HasForeignKey<ReferralINV>(p => p.ReferralID).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ScheduleINV>().Property(s => s.DateBooked).HasColumnType("datetime2(7)");
            modelBuilder.Entity<ScheduleINV>().Property(s => s.StartTime).HasColumnType("datetime2(7)").IsRequired(false);
            modelBuilder.Entity<ScheduleINV>().Property(s => s.EndTime).HasColumnType("datetime2(7)").IsRequired(false);
            // Forum post can have many schedule
            modelBuilder.Entity<ScheduleINV>().HasOne(p => p.ForumPost)
                .WithMany(p => p.Schedule).HasForeignKey(p => p.ForumPostID).OnDelete(DeleteBehavior.Restrict);
            // Handyman can have many schedule
            modelBuilder.Entity<ScheduleINV>().HasOne(p => p.Handyman)
                .WithMany(p => p.Schedule).HasForeignKey(p => p.HandymanID).OnDelete(DeleteBehavior.Restrict);
            // Customer can have many schedule
            modelBuilder.Entity<ScheduleINV>().HasOne(p => p.Customer)
                .WithMany(p => p.Schedule).HasForeignKey(p => p.CustomerID).OnDelete(DeleteBehavior.Restrict);
            // Schedule can only have one check-in
            modelBuilder.Entity<CheckInINV>().HasOne(p => p.Schedule)
                .WithOne(p => p.CheckIn).HasForeignKey<CheckInINV>(p => p.ScheduleID).OnDelete(DeleteBehavior.Restrict);

            // Handyman can have many job classes
            modelBuilder.Entity<JobClassINV>().HasOne(p => p.Handyman)
                .WithMany(p => p.JobClass).HasForeignKey(p => p.HandymanID).OnDelete(DeleteBehavior.Restrict);
            // Forum post can have many job classes
            modelBuilder.Entity<JobClassINV>().HasOne(p => p.ForumPost)
                .WithMany(p => p.JobClass).HasForeignKey(p => p.ForumPostID).OnDelete(DeleteBehavior.Restrict);

            // Handyman can have many applications
            modelBuilder.Entity<ApplicationINV>().HasOne(p => p.Handyman)
                .WithMany(p => p.Application).HasForeignKey(p => p.HandymanID).OnDelete(DeleteBehavior.Restrict);

            // Handyman can have many inquiries
            modelBuilder.Entity<InquiryINV>().HasOne(p => p.Handyman)
                .WithMany(p => p.Inquiry).HasForeignKey(p => p.HandymanID).OnDelete(DeleteBehavior.Restrict);

            // Customer can have many inquiries
            modelBuilder.Entity<InquiryINV>().HasOne(p => p.Customer)
                .WithMany(p => p.Inquiry).HasForeignKey(p => p.CustomerID).OnDelete(DeleteBehavior.Restrict);

            // Handyman can have many payments earned
            modelBuilder.Entity<PaymentProofINV>().HasOne(p => p.Handyman)
                .WithMany(p => p.Payment).HasForeignKey(p => p.HandymanID).OnDelete(DeleteBehavior.Restrict);

            // Customer can have many payments made
            modelBuilder.Entity<PaymentProofINV>().HasOne(p => p.Customer)
                .WithMany(p => p.Payment).HasForeignKey(p => p.CustomerID).OnDelete(DeleteBehavior.Restrict);

            // Payment can correspond to many check ins
            modelBuilder.Entity<CheckInINV>().HasOne(p => p.Payment)
                .WithMany(p => p.CheckIn).HasForeignKey(p => p.PaymentID).OnDelete(DeleteBehavior.Restrict);

            // Forum post corresponds to only one payment 
            modelBuilder.Entity<PaymentProofINV>().HasOne(p => p.ForumPost)
                .WithOne(p => p.Payment).HasForeignKey<ForumINV>(p => p.ForumPostID).OnDelete(DeleteBehavior.Restrict);
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
