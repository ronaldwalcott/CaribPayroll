using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaribPayroll.Data.Migrations
{
    public partial class CreateEmployeeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(maxLength: 1, nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeductionCalculationType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(maxLength: 1, nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CalculationType = table.Column<string>(maxLength: 1, nullable: false),
                    Description = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeductionCalculationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeductionType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(maxLength: 1, nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Mandatory = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeductionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    GLCode = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(maxLength: 1, nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EarningType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(maxLength: 1, nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Description = table.Column<string>(maxLength: 25, nullable: false),
                    ActivityType = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EarningType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(maxLength: 1, nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    JobType = table.Column<string>(maxLength: 1, nullable: false),
                    Description = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parish",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(maxLength: 1, nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parish", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentPeriod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(maxLength: 1, nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    PaymentCode = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPeriod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeductionDescription",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(maxLength: 1, nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    GLCode = table.Column<string>(maxLength: 25, nullable: true),
                    DeductionTypeId = table.Column<int>(nullable: false),
                    DeductionCalculationTypeId = table.Column<int>(nullable: false),
                    SubCategoriesExist = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeductionDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeductionDescription_DeductionCalculationType_DeductionCalculationTypeId",
                        column: x => x.DeductionCalculationTypeId,
                        principalTable: "DeductionCalculationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeductionDescription_DeductionType_DeductionTypeId",
                        column: x => x.DeductionTypeId,
                        principalTable: "DeductionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EarningDescription",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(maxLength: 1, nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    GLCode = table.Column<string>(maxLength: 25, nullable: true),
                    EarningTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EarningDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EarningDescription_EarningType_EarningTypeId",
                        column: x => x.EarningTypeId,
                        principalTable: "EarningType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(maxLength: 1, nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(maxLength: 100, nullable: false),
                    ParishId = table.Column<int>(nullable: false),
                    DistrictId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_Parish_ParishId",
                        column: x => x.ParishId,
                        principalTable: "Parish",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(maxLength: 1, nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    EmployeeNo = table.Column<string>(maxLength: 25, nullable: false),
                    Surname = table.Column<string>(maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 100, nullable: false),
                    NationalRegistrationNo = table.Column<string>(maxLength: 25, nullable: false),
                    PaymentPeriodId = table.Column<int>(nullable: false),
                    EmployeeAddressId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeAddress_EmployeeAddressId",
                        column: x => x.EmployeeAddressId,
                        principalTable: "EmployeeAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_PaymentPeriod_PaymentPeriodId",
                        column: x => x.PaymentPeriodId,
                        principalTable: "PaymentPeriod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDeduction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    DeductionDescriptionId = table.Column<int>(nullable: false),
                    DeductionAmount = table.Column<double>(nullable: false),
                    DeductionBalance = table.Column<double>(nullable: false),
                    DateStartEffective = table.Column<DateTime>(nullable: true),
                    DateEndEffective = table.Column<DateTime>(nullable: true),
                    BankId = table.Column<int>(nullable: false),
                    BranchCode = table.Column<string>(maxLength: 25, nullable: false),
                    BankAccountNo = table.Column<string>(maxLength: 25, nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDeduction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDeduction_Bank_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeDeduction_DeductionDescription_DeductionDescriptionId",
                        column: x => x.DeductionDescriptionId,
                        principalTable: "DeductionDescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeDeduction_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDeductionReferenceNo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(maxLength: 1, nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    DeductionDescriptionId = table.Column<int>(nullable: false),
                    DeductionReferenceNo = table.Column<string>(maxLength: 25, nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDeductionReferenceNo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDeductionReferenceNo_DeductionDescription_DeductionDescriptionId",
                        column: x => x.DeductionDescriptionId,
                        principalTable: "DeductionDescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeDeductionReferenceNo_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeEarning",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(maxLength: 1, nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EarningDescriptionId = table.Column<int>(nullable: false),
                    JobId = table.Column<int>(nullable: false),
                    EarningAmount = table.Column<double>(nullable: false),
                    DateStartEffective = table.Column<DateTime>(nullable: true),
                    DateEndEffective = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEarning", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeEarning_EarningDescription_EarningDescriptionId",
                        column: x => x.EarningDescriptionId,
                        principalTable: "EarningDescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeEarning_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeEarning_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DeductionCalculationType",
                columns: new[] { "Id", "Action", "CalculationType", "CreatedBy", "CreatedDate", "Description", "ModifiedBy", "ModifiedDate" },
                values: new object[] { 1, "A", "F", null, new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 415, DateTimeKind.Unspecified).AddTicks(3579), new TimeSpan(0, -4, 0, 0, 0)), "Fixed", null, new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "DeductionCalculationType",
                columns: new[] { "Id", "Action", "CalculationType", "CreatedBy", "CreatedDate", "Description", "ModifiedBy", "ModifiedDate" },
                values: new object[] { 2, "A", "P", null, new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2194), new TimeSpan(0, -4, 0, 0, 0)), "Fixed", null, new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2212), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "DeductionCalculationType",
                columns: new[] { "Id", "Action", "CalculationType", "CreatedBy", "CreatedDate", "Description", "ModifiedBy", "ModifiedDate" },
                values: new object[] { 3, "A", "R", null, new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2227), new TimeSpan(0, -4, 0, 0, 0)), "Range", null, new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2228), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "DeductionCalculationType",
                columns: new[] { "Id", "Action", "CalculationType", "CreatedBy", "CreatedDate", "Description", "ModifiedBy", "ModifiedDate" },
                values: new object[] { 4, "A", "S", null, new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2231), new TimeSpan(0, -4, 0, 0, 0)), "Scale", null, new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2232), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "DeductionCalculationType",
                columns: new[] { "Id", "Action", "CalculationType", "CreatedBy", "CreatedDate", "Description", "ModifiedBy", "ModifiedDate" },
                values: new object[] { 5, "A", "B", null, new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2234), new TimeSpan(0, -4, 0, 0, 0)), "Reducing Balance", null, new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2236), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Bank_Description",
                table: "Bank",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeductionCalculationType_CalculationType",
                table: "DeductionCalculationType",
                column: "CalculationType",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeductionDescription_DeductionCalculationTypeId",
                table: "DeductionDescription",
                column: "DeductionCalculationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DeductionDescription_DeductionTypeId",
                table: "DeductionDescription",
                column: "DeductionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DeductionDescription_Description",
                table: "DeductionDescription",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeductionType_Description",
                table: "DeductionType",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_Description",
                table: "Department",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_District_Description",
                table: "District",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EarningDescription_Description",
                table: "EarningDescription",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EarningDescription_EarningTypeId",
                table: "EarningDescription",
                column: "EarningTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EarningType_Description",
                table: "EarningType",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeAddressId",
                table: "Employee",
                column: "EmployeeAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PaymentPeriodId",
                table: "Employee",
                column: "PaymentPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Surname_FirstName_MiddleName",
                table: "Employee",
                columns: new[] { "Surname", "FirstName", "MiddleName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_DistrictId",
                table: "EmployeeAddress",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_ParishId",
                table: "EmployeeAddress",
                column: "ParishId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDeduction_BankId",
                table: "EmployeeDeduction",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDeduction_DeductionDescriptionId",
                table: "EmployeeDeduction",
                column: "DeductionDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDeduction_EmployeeId",
                table: "EmployeeDeduction",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDeductionReferenceNo_DeductionDescriptionId",
                table: "EmployeeDeductionReferenceNo",
                column: "DeductionDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDeductionReferenceNo_EmployeeId",
                table: "EmployeeDeductionReferenceNo",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEarning_EarningDescriptionId",
                table: "EmployeeEarning",
                column: "EarningDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEarning_EmployeeId",
                table: "EmployeeEarning",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEarning_JobId",
                table: "EmployeeEarning",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_Description",
                table: "Job",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parish_Description",
                table: "Parish",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPeriod_Description",
                table: "PaymentPeriod",
                column: "Description",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDeduction");

            migrationBuilder.DropTable(
                name: "EmployeeDeductionReferenceNo");

            migrationBuilder.DropTable(
                name: "EmployeeEarning");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "DeductionDescription");

            migrationBuilder.DropTable(
                name: "EarningDescription");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "DeductionCalculationType");

            migrationBuilder.DropTable(
                name: "DeductionType");

            migrationBuilder.DropTable(
                name: "EarningType");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "EmployeeAddress");

            migrationBuilder.DropTable(
                name: "PaymentPeriod");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Parish");
        }
    }
}
