﻿// <auto-generated />
using System;
using Bayanihand.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bayanihand.DataModel.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bayanihand.DataModel.ApplicationINV", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationID"));

                    b.Property<string>("CV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateApplied")
                        .HasColumnType("datetime2(7)");

                    b.Property<int>("ForumPostID")
                        .HasColumnType("int");

                    b.Property<int>("HandymanID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationID");

                    b.HasIndex("ForumPostID");

                    b.HasIndex("HandymanID");

                    b.ToTable("ApplicationINV");
                });

            modelBuilder.Entity("Bayanihand.DataModel.CheckInINV", b =>
                {
                    b.Property<int>("CheckInID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CheckInID"));

                    b.Property<DateTime>("DateCheckedIn")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime?>("DateCheckedOut")
                        .HasColumnType("datetime2(7)");

                    b.Property<int>("PaymentID")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleID")
                        .HasColumnType("int");

                    b.Property<bool>("hasCheckedIn")
                        .HasColumnType("bit");

                    b.HasKey("CheckInID");

                    b.HasIndex("PaymentID");

                    b.HasIndex("ScheduleID")
                        .IsUnique();

                    b.ToTable("CheckInINV");
                });

            modelBuilder.Entity("Bayanihand.DataModel.CustomerINV", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BarangayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BarangayNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerESign")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GovID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePhoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZIPCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isVerified")
                        .HasColumnType("bit");

                    b.HasKey("CustomerID");

                    b.ToTable("CustomerINV");
                });

            modelBuilder.Entity("Bayanihand.DataModel.ForumINV", b =>
                {
                    b.Property<int>("ForumPostID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("DateCheckedOut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateEdited")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentID")
                        .HasColumnType("int");

                    b.Property<int>("ReferralID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ForumPostID");

                    b.HasIndex("CustomerID");

                    b.ToTable("ForumINV");
                });

            modelBuilder.Entity("Bayanihand.DataModel.HandymanINV", b =>
                {
                    b.Property<int>("HandymanID")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BarangayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BarangayNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ForumPostID")
                        .HasColumnType("int");

                    b.Property<string>("GovID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HandymanESign")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePhoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SalaryRange")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("YearsOfExperience")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ZIPCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isVerified")
                        .HasColumnType("bit");

                    b.HasKey("HandymanID");

                    b.ToTable("HandymanINV");
                });

            modelBuilder.Entity("Bayanihand.DataModel.InquiryINV", b =>
                {
                    b.Property<int>("InquiryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InquiryID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateInquired")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HandymanID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InquiryID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("HandymanID");

                    b.ToTable("InquiryINV");
                });

            modelBuilder.Entity("Bayanihand.DataModel.JobClassINV", b =>
                {
                    b.Property<int>("JobClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobClassID"));

                    b.Property<int>("ForumPostID")
                        .HasColumnType("int");

                    b.Property<int>("HandymanID")
                        .HasColumnType("int");

                    b.Property<string>("JobExperience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobField")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobClassID");

                    b.HasIndex("ForumPostID");

                    b.HasIndex("HandymanID");

                    b.ToTable("JobClassINV");
                });

            modelBuilder.Entity("Bayanihand.DataModel.PaymentProofINV", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"));

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePaid")
                        .HasColumnType("datetime2(7)");

                    b.Property<int>("ForumPostID")
                        .HasColumnType("int");

                    b.Property<int>("HandymanID")
                        .HasColumnType("int");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("hasPaid")
                        .HasColumnType("bit");

                    b.HasKey("PaymentID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("HandymanID");

                    b.ToTable("PaymentProofINV");
                });

            modelBuilder.Entity("Bayanihand.DataModel.ReferralINV", b =>
                {
                    b.Property<int>("ReferralID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateEdited")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("DateReferred")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ForumPostID")
                        .HasColumnType("int");

                    b.Property<int>("HandymanID")
                        .HasColumnType("int");

                    b.Property<int>("ReferralVote")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReferralID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("HandymanID");

                    b.ToTable("ReferralINV");
                });

            modelBuilder.Entity("Bayanihand.DataModel.ScheduleINV", b =>
                {
                    b.Property<int>("ScheduleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleID"));

                    b.Property<int>("CheckInID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateBooked")
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<int>("ForumPostID")
                        .HasColumnType("int");

                    b.Property<int>("HandymanID")
                        .HasColumnType("int");

                    b.Property<string>("ScheduleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<bool>("hasEnded")
                        .HasColumnType("bit");

                    b.Property<bool>("hasStarted")
                        .HasColumnType("bit");

                    b.HasKey("ScheduleID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ForumPostID");

                    b.HasIndex("HandymanID");

                    b.ToTable("ScheduleINV");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Bayanihand.DataModel.ApplicationINV", b =>
                {
                    b.HasOne("Bayanihand.DataModel.ForumINV", "ForumPost")
                        .WithMany("Application")
                        .HasForeignKey("ForumPostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bayanihand.DataModel.HandymanINV", "Handyman")
                        .WithMany("Application")
                        .HasForeignKey("HandymanID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ForumPost");

                    b.Navigation("Handyman");
                });

            modelBuilder.Entity("Bayanihand.DataModel.CheckInINV", b =>
                {
                    b.HasOne("Bayanihand.DataModel.PaymentProofINV", "Payment")
                        .WithMany("CheckIn")
                        .HasForeignKey("PaymentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bayanihand.DataModel.ScheduleINV", "Schedule")
                        .WithOne("CheckIn")
                        .HasForeignKey("Bayanihand.DataModel.CheckInINV", "ScheduleID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Payment");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("Bayanihand.DataModel.ForumINV", b =>
                {
                    b.HasOne("Bayanihand.DataModel.CustomerINV", "Customer")
                        .WithMany("ForumPost")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bayanihand.DataModel.PaymentProofINV", "Payment")
                        .WithOne("ForumPost")
                        .HasForeignKey("Bayanihand.DataModel.ForumINV", "ForumPostID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("Bayanihand.DataModel.HandymanINV", b =>
                {
                    b.HasOne("Bayanihand.DataModel.ForumINV", "ForumPost")
                        .WithMany("Handyman")
                        .HasForeignKey("HandymanID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ForumPost");
                });

            modelBuilder.Entity("Bayanihand.DataModel.InquiryINV", b =>
                {
                    b.HasOne("Bayanihand.DataModel.CustomerINV", "Customer")
                        .WithMany("Inquiry")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bayanihand.DataModel.HandymanINV", "Handyman")
                        .WithMany("Inquiry")
                        .HasForeignKey("HandymanID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Handyman");
                });

            modelBuilder.Entity("Bayanihand.DataModel.JobClassINV", b =>
                {
                    b.HasOne("Bayanihand.DataModel.ForumINV", "ForumPost")
                        .WithMany("JobClass")
                        .HasForeignKey("ForumPostID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bayanihand.DataModel.HandymanINV", "Handyman")
                        .WithMany("JobClass")
                        .HasForeignKey("HandymanID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ForumPost");

                    b.Navigation("Handyman");
                });

            modelBuilder.Entity("Bayanihand.DataModel.PaymentProofINV", b =>
                {
                    b.HasOne("Bayanihand.DataModel.CustomerINV", "Customer")
                        .WithMany("Payment")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bayanihand.DataModel.HandymanINV", "Handyman")
                        .WithMany("Payment")
                        .HasForeignKey("HandymanID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Handyman");
                });

            modelBuilder.Entity("Bayanihand.DataModel.ReferralINV", b =>
                {
                    b.HasOne("Bayanihand.DataModel.CustomerINV", "Customer")
                        .WithMany("Referral")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bayanihand.DataModel.HandymanINV", "Handyman")
                        .WithMany("Referral")
                        .HasForeignKey("HandymanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bayanihand.DataModel.ForumINV", "ForumPost")
                        .WithOne("Referral")
                        .HasForeignKey("Bayanihand.DataModel.ReferralINV", "ReferralID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("ForumPost");

                    b.Navigation("Handyman");
                });

            modelBuilder.Entity("Bayanihand.DataModel.ScheduleINV", b =>
                {
                    b.HasOne("Bayanihand.DataModel.CustomerINV", "Customer")
                        .WithMany("Schedule")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bayanihand.DataModel.ForumINV", "ForumPost")
                        .WithMany("Schedule")
                        .HasForeignKey("ForumPostID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bayanihand.DataModel.HandymanINV", "Handyman")
                        .WithMany("Schedule")
                        .HasForeignKey("HandymanID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("ForumPost");

                    b.Navigation("Handyman");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bayanihand.DataModel.CustomerINV", b =>
                {
                    b.Navigation("ForumPost");

                    b.Navigation("Inquiry");

                    b.Navigation("Payment");

                    b.Navigation("Referral");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("Bayanihand.DataModel.ForumINV", b =>
                {
                    b.Navigation("Application");

                    b.Navigation("Handyman");

                    b.Navigation("JobClass");

                    b.Navigation("Referral")
                        .IsRequired();

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("Bayanihand.DataModel.HandymanINV", b =>
                {
                    b.Navigation("Application");

                    b.Navigation("Inquiry");

                    b.Navigation("JobClass");

                    b.Navigation("Payment");

                    b.Navigation("Referral");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("Bayanihand.DataModel.PaymentProofINV", b =>
                {
                    b.Navigation("CheckIn");

                    b.Navigation("ForumPost")
                        .IsRequired();
                });

            modelBuilder.Entity("Bayanihand.DataModel.ScheduleINV", b =>
                {
                    b.Navigation("CheckIn")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
