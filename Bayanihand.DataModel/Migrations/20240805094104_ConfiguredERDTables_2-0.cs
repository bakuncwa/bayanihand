﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bayanihand.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class ConfiguredERDTables_20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerINV",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GovID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isVerified = table.Column<bool>(type: "bit", nullable: false),
                    ProfilePhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerESign = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarangayNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarangayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZIPCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerINV", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationINV",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateApplied = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    Title = table.Column<int>(type: "int", nullable: false),
                    CV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ForumPostID = table.Column<int>(type: "int", nullable: false),
                    HandymanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationINV", x => x.ApplicationID);
                });

            migrationBuilder.CreateTable(
                name: "CheckInINV",
                columns: table => new
                {
                    CheckInID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCheckedIn = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    DateCheckedOut = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    hasCheckedIn = table.Column<bool>(type: "bit", nullable: false),
                    ScheduleID = table.Column<int>(type: "int", nullable: false),
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckInINV", x => x.CheckInID);
                });

            migrationBuilder.CreateTable(
                name: "ForumINV",
                columns: table => new
                {
                    ForumPostID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCheckedOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatePosted = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    DateEdited = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    ReferralID = table.Column<int>(type: "int", nullable: false),
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumINV", x => x.ForumPostID);
                    table.ForeignKey(
                        name: "FK_ForumINV_CustomerINV_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "CustomerINV",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HandymanINV",
                columns: table => new
                {
                    HandymanID = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GovID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isVerified = table.Column<bool>(type: "bit", nullable: false),
                    ProfilePhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HandymanESign = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarangayNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarangayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZIPCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalaryRange = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ForumPostID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandymanINV", x => x.HandymanID);
                    table.ForeignKey(
                        name: "FK_HandymanINV_ForumINV_HandymanID",
                        column: x => x.HandymanID,
                        principalTable: "ForumINV",
                        principalColumn: "ForumPostID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InquiryINV",
                columns: table => new
                {
                    InquiryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateInquired = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HandymanID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InquiryINV", x => x.InquiryID);
                    table.ForeignKey(
                        name: "FK_InquiryINV_CustomerINV_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "CustomerINV",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InquiryINV_HandymanINV_HandymanID",
                        column: x => x.HandymanID,
                        principalTable: "HandymanINV",
                        principalColumn: "HandymanID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobClassINV",
                columns: table => new
                {
                    JobClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobExperience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobField = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HandymanID = table.Column<int>(type: "int", nullable: false),
                    ForumPostID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobClassINV", x => x.JobClassID);
                    table.ForeignKey(
                        name: "FK_JobClassINV_ForumINV_ForumPostID",
                        column: x => x.ForumPostID,
                        principalTable: "ForumINV",
                        principalColumn: "ForumPostID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobClassINV_HandymanINV_HandymanID",
                        column: x => x.HandymanID,
                        principalTable: "HandymanINV",
                        principalColumn: "HandymanID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentProofINV",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePaid = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    hasPaid = table.Column<bool>(type: "bit", nullable: false),
                    HandymanID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    ForumPostID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentProofINV", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_PaymentProofINV_CustomerINV_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "CustomerINV",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentProofINV_HandymanINV_HandymanID",
                        column: x => x.HandymanID,
                        principalTable: "HandymanINV",
                        principalColumn: "HandymanID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReferralINV",
                columns: table => new
                {
                    ReferralID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateReferred = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    DateEdited = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    ReferralVote = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    HandymanID = table.Column<int>(type: "int", nullable: false),
                    ForumPostID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralINV", x => x.ReferralID);
                    table.ForeignKey(
                        name: "FK_ReferralINV_CustomerINV_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "CustomerINV",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReferralINV_ForumINV_ReferralID",
                        column: x => x.ReferralID,
                        principalTable: "ForumINV",
                        principalColumn: "ForumPostID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReferralINV_HandymanINV_HandymanID",
                        column: x => x.HandymanID,
                        principalTable: "HandymanINV",
                        principalColumn: "HandymanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleINV",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateBooked = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    hasStarted = table.Column<bool>(type: "bit", nullable: false),
                    hasEnded = table.Column<bool>(type: "bit", nullable: false),
                    ForumPostID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    HandymanID = table.Column<int>(type: "int", nullable: false),
                    CheckInID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleINV", x => x.ScheduleID);
                    table.ForeignKey(
                        name: "FK_ScheduleINV_CustomerINV_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "CustomerINV",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScheduleINV_ForumINV_ForumPostID",
                        column: x => x.ForumPostID,
                        principalTable: "ForumINV",
                        principalColumn: "ForumPostID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScheduleINV_HandymanINV_HandymanID",
                        column: x => x.HandymanID,
                        principalTable: "HandymanINV",
                        principalColumn: "HandymanID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationINV_ForumPostID",
                table: "ApplicationINV",
                column: "ForumPostID");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationINV_HandymanID",
                table: "ApplicationINV",
                column: "HandymanID");

            migrationBuilder.CreateIndex(
                name: "IX_CheckInINV_PaymentID",
                table: "CheckInINV",
                column: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_CheckInINV_ScheduleID",
                table: "CheckInINV",
                column: "ScheduleID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ForumINV_CustomerID",
                table: "ForumINV",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_InquiryINV_CustomerID",
                table: "InquiryINV",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_InquiryINV_HandymanID",
                table: "InquiryINV",
                column: "HandymanID");

            migrationBuilder.CreateIndex(
                name: "IX_JobClassINV_ForumPostID",
                table: "JobClassINV",
                column: "ForumPostID");

            migrationBuilder.CreateIndex(
                name: "IX_JobClassINV_HandymanID",
                table: "JobClassINV",
                column: "HandymanID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentProofINV_CustomerID",
                table: "PaymentProofINV",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentProofINV_HandymanID",
                table: "PaymentProofINV",
                column: "HandymanID");

            migrationBuilder.CreateIndex(
                name: "IX_ReferralINV_CustomerID",
                table: "ReferralINV",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ReferralINV_HandymanID",
                table: "ReferralINV",
                column: "HandymanID");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleINV_CustomerID",
                table: "ScheduleINV",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleINV_ForumPostID",
                table: "ScheduleINV",
                column: "ForumPostID");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleINV_HandymanID",
                table: "ScheduleINV",
                column: "HandymanID");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationINV_ForumINV_ForumPostID",
                table: "ApplicationINV",
                column: "ForumPostID",
                principalTable: "ForumINV",
                principalColumn: "ForumPostID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationINV_HandymanINV_HandymanID",
                table: "ApplicationINV",
                column: "HandymanID",
                principalTable: "HandymanINV",
                principalColumn: "HandymanID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckInINV_PaymentProofINV_PaymentID",
                table: "CheckInINV",
                column: "PaymentID",
                principalTable: "PaymentProofINV",
                principalColumn: "PaymentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckInINV_ScheduleINV_ScheduleID",
                table: "CheckInINV",
                column: "ScheduleID",
                principalTable: "ScheduleINV",
                principalColumn: "ScheduleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumINV_PaymentProofINV_ForumPostID",
                table: "ForumINV",
                column: "ForumPostID",
                principalTable: "PaymentProofINV",
                principalColumn: "PaymentID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandymanINV_ForumINV_HandymanID",
                table: "HandymanINV");

            migrationBuilder.DropTable(
                name: "ApplicationINV");

            migrationBuilder.DropTable(
                name: "CheckInINV");

            migrationBuilder.DropTable(
                name: "InquiryINV");

            migrationBuilder.DropTable(
                name: "JobClassINV");

            migrationBuilder.DropTable(
                name: "ReferralINV");

            migrationBuilder.DropTable(
                name: "ScheduleINV");

            migrationBuilder.DropTable(
                name: "ForumINV");

            migrationBuilder.DropTable(
                name: "PaymentProofINV");

            migrationBuilder.DropTable(
                name: "CustomerINV");

            migrationBuilder.DropTable(
                name: "HandymanINV");
        }
    }
}