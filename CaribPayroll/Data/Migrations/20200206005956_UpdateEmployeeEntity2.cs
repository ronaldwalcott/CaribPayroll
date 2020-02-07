using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaribPayroll.Data.Migrations
{
    public partial class UpdateEmployeeEntity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeductionDescription_DeductionCalculationType_DeductionCalculationTypeId",
                table: "DeductionDescription");

            migrationBuilder.DropForeignKey(
                name: "FK_DeductionDescription_DeductionType_DeductionTypeId",
                table: "DeductionDescription");

            migrationBuilder.DropForeignKey(
                name: "FK_EarningDescription_EarningType_EarningTypeId",
                table: "EarningDescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeAddress_EmployeeAddressId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_PaymentPeriod_PaymentPeriodId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAddress_District_DistrictId",
                table: "EmployeeAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAddress_Parish_ParishId",
                table: "EmployeeAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDeduction_Bank_BankId",
                table: "EmployeeDeduction");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDeduction_Employee_EmployeeId",
                table: "EmployeeDeduction");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDeductionReferenceNo_DeductionDescription_DeductionDescriptionId",
                table: "EmployeeDeductionReferenceNo");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDeductionReferenceNo_Employee_EmployeeId",
                table: "EmployeeDeductionReferenceNo");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEarning_EarningDescription_EarningDescriptionId",
                table: "EmployeeEarning");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEarning_Employee_EmployeeId",
                table: "EmployeeEarning");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEarning_Job_JobId",
                table: "EmployeeEarning");

            migrationBuilder.DropIndex(
                name: "IX_Employee_EmployeeAddressId",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "EmployeeEarning",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "EmployeeEarning",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EarningDescriptionId",
                table: "EmployeeEarning",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "EmployeeDeductionReferenceNo",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeductionDescriptionId",
                table: "EmployeeDeductionReferenceNo",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "EmployeeDeduction",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BankId",
                table: "EmployeeDeduction",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ParishId",
                table: "EmployeeAddress",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "EmployeeAddress",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DistrictId",
                table: "EmployeeAddress",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentPeriodId",
                table: "Employee",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeAddressId",
                table: "Employee",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Employee",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EarningTypeId",
                table: "EarningDescription",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeductionTypeId",
                table: "DeductionDescription",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeductionCalculationTypeId",
                table: "DeductionDescription",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 5, 20, 59, 55, 792, DateTimeKind.Unspecified).AddTicks(3731), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 5, 20, 59, 55, 795, DateTimeKind.Unspecified).AddTicks(3274), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 5, 20, 59, 55, 795, DateTimeKind.Unspecified).AddTicks(3960), new TimeSpan(0, -4, 0, 0, 0)), "Percent", new DateTimeOffset(new DateTime(2020, 2, 5, 20, 59, 55, 795, DateTimeKind.Unspecified).AddTicks(3979), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 5, 20, 59, 55, 795, DateTimeKind.Unspecified).AddTicks(3990), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 5, 20, 59, 55, 795, DateTimeKind.Unspecified).AddTicks(3991), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 5, 20, 59, 55, 795, DateTimeKind.Unspecified).AddTicks(3994), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 5, 20, 59, 55, 795, DateTimeKind.Unspecified).AddTicks(3995), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 5, 20, 59, 55, 795, DateTimeKind.Unspecified).AddTicks(3997), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 5, 20, 59, 55, 795, DateTimeKind.Unspecified).AddTicks(3999), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "PaymentPeriod",
                columns: new[] { "Id", "Action", "CreatedBy", "CreatedDate", "Description", "ModifiedBy", "ModifiedDate", "PaymentCode" },
                values: new object[] { 1, "A", null, new DateTimeOffset(new DateTime(2020, 2, 5, 20, 59, 55, 796, DateTimeKind.Unspecified).AddTicks(8049), new TimeSpan(0, -4, 0, 0, 0)), "Monthly", null, new DateTimeOffset(new DateTime(2020, 2, 5, 20, 59, 55, 796, DateTimeKind.Unspecified).AddTicks(8062), new TimeSpan(0, -4, 0, 0, 0)), "M" });

            migrationBuilder.InsertData(
                table: "PaymentPeriod",
                columns: new[] { "Id", "Action", "CreatedBy", "CreatedDate", "Description", "ModifiedBy", "ModifiedDate", "PaymentCode" },
                values: new object[] { 2, "A", null, new DateTimeOffset(new DateTime(2020, 2, 5, 20, 59, 55, 796, DateTimeKind.Unspecified).AddTicks(8109), new TimeSpan(0, -4, 0, 0, 0)), "Weekly", null, new DateTimeOffset(new DateTime(2020, 2, 5, 20, 59, 55, 796, DateTimeKind.Unspecified).AddTicks(8111), new TimeSpan(0, -4, 0, 0, 0)), "W" });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeAddressId",
                table: "Employee",
                column: "EmployeeAddressId",
                unique: true,
                filter: "[EmployeeAddressId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_DeductionDescription_DeductionCalculationType_DeductionCalculationTypeId",
                table: "DeductionDescription",
                column: "DeductionCalculationTypeId",
                principalTable: "DeductionCalculationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeductionDescription_DeductionType_DeductionTypeId",
                table: "DeductionDescription",
                column: "DeductionTypeId",
                principalTable: "DeductionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EarningDescription_EarningType_EarningTypeId",
                table: "EarningDescription",
                column: "EarningTypeId",
                principalTable: "EarningType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeAddress_EmployeeAddressId",
                table: "Employee",
                column: "EmployeeAddressId",
                principalTable: "EmployeeAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_PaymentPeriod_PaymentPeriodId",
                table: "Employee",
                column: "PaymentPeriodId",
                principalTable: "PaymentPeriod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAddress_District_DistrictId",
                table: "EmployeeAddress",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAddress_Parish_ParishId",
                table: "EmployeeAddress",
                column: "ParishId",
                principalTable: "Parish",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDeduction_Bank_BankId",
                table: "EmployeeDeduction",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDeduction_Employee_EmployeeId",
                table: "EmployeeDeduction",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDeductionReferenceNo_DeductionDescription_DeductionDescriptionId",
                table: "EmployeeDeductionReferenceNo",
                column: "DeductionDescriptionId",
                principalTable: "DeductionDescription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDeductionReferenceNo_Employee_EmployeeId",
                table: "EmployeeDeductionReferenceNo",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEarning_EarningDescription_EarningDescriptionId",
                table: "EmployeeEarning",
                column: "EarningDescriptionId",
                principalTable: "EarningDescription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEarning_Employee_EmployeeId",
                table: "EmployeeEarning",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEarning_Job_JobId",
                table: "EmployeeEarning",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeductionDescription_DeductionCalculationType_DeductionCalculationTypeId",
                table: "DeductionDescription");

            migrationBuilder.DropForeignKey(
                name: "FK_DeductionDescription_DeductionType_DeductionTypeId",
                table: "DeductionDescription");

            migrationBuilder.DropForeignKey(
                name: "FK_EarningDescription_EarningType_EarningTypeId",
                table: "EarningDescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeAddress_EmployeeAddressId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_PaymentPeriod_PaymentPeriodId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAddress_District_DistrictId",
                table: "EmployeeAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAddress_Parish_ParishId",
                table: "EmployeeAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDeduction_Bank_BankId",
                table: "EmployeeDeduction");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDeduction_Employee_EmployeeId",
                table: "EmployeeDeduction");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDeductionReferenceNo_DeductionDescription_DeductionDescriptionId",
                table: "EmployeeDeductionReferenceNo");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDeductionReferenceNo_Employee_EmployeeId",
                table: "EmployeeDeductionReferenceNo");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEarning_EarningDescription_EarningDescriptionId",
                table: "EmployeeEarning");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEarning_Employee_EmployeeId",
                table: "EmployeeEarning");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEarning_Job_JobId",
                table: "EmployeeEarning");

            migrationBuilder.DropIndex(
                name: "IX_Employee_EmployeeAddressId",
                table: "Employee");

            migrationBuilder.DeleteData(
                table: "PaymentPeriod",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentPeriod",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "EmployeeEarning",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "EmployeeEarning",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EarningDescriptionId",
                table: "EmployeeEarning",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "EmployeeDeductionReferenceNo",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeductionDescriptionId",
                table: "EmployeeDeductionReferenceNo",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "EmployeeDeduction",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BankId",
                table: "EmployeeDeduction",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParishId",
                table: "EmployeeAddress",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "EmployeeAddress",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DistrictId",
                table: "EmployeeAddress",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentPeriodId",
                table: "Employee",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeAddressId",
                table: "Employee",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Employee",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EarningTypeId",
                table: "EarningDescription",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeductionTypeId",
                table: "DeductionDescription",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeductionCalculationTypeId",
                table: "DeductionDescription",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 3, 12, 34, 56, 115, DateTimeKind.Unspecified).AddTicks(6241), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 3, 12, 34, 56, 118, DateTimeKind.Unspecified).AddTicks(1908), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 3, 12, 34, 56, 118, DateTimeKind.Unspecified).AddTicks(2680), new TimeSpan(0, -4, 0, 0, 0)), "Fixed", new DateTimeOffset(new DateTime(2020, 2, 3, 12, 34, 56, 118, DateTimeKind.Unspecified).AddTicks(2699), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 3, 12, 34, 56, 118, DateTimeKind.Unspecified).AddTicks(2710), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 3, 12, 34, 56, 118, DateTimeKind.Unspecified).AddTicks(2712), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 3, 12, 34, 56, 118, DateTimeKind.Unspecified).AddTicks(2714), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 3, 12, 34, 56, 118, DateTimeKind.Unspecified).AddTicks(2716), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 3, 12, 34, 56, 118, DateTimeKind.Unspecified).AddTicks(2718), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 3, 12, 34, 56, 118, DateTimeKind.Unspecified).AddTicks(2720), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeAddressId",
                table: "Employee",
                column: "EmployeeAddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DeductionDescription_DeductionCalculationType_DeductionCalculationTypeId",
                table: "DeductionDescription",
                column: "DeductionCalculationTypeId",
                principalTable: "DeductionCalculationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeductionDescription_DeductionType_DeductionTypeId",
                table: "DeductionDescription",
                column: "DeductionTypeId",
                principalTable: "DeductionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EarningDescription_EarningType_EarningTypeId",
                table: "EarningDescription",
                column: "EarningTypeId",
                principalTable: "EarningType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeAddress_EmployeeAddressId",
                table: "Employee",
                column: "EmployeeAddressId",
                principalTable: "EmployeeAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_PaymentPeriod_PaymentPeriodId",
                table: "Employee",
                column: "PaymentPeriodId",
                principalTable: "PaymentPeriod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAddress_District_DistrictId",
                table: "EmployeeAddress",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAddress_Parish_ParishId",
                table: "EmployeeAddress",
                column: "ParishId",
                principalTable: "Parish",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDeduction_Bank_BankId",
                table: "EmployeeDeduction",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDeduction_Employee_EmployeeId",
                table: "EmployeeDeduction",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDeductionReferenceNo_DeductionDescription_DeductionDescriptionId",
                table: "EmployeeDeductionReferenceNo",
                column: "DeductionDescriptionId",
                principalTable: "DeductionDescription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDeductionReferenceNo_Employee_EmployeeId",
                table: "EmployeeDeductionReferenceNo",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEarning_EarningDescription_EarningDescriptionId",
                table: "EmployeeEarning",
                column: "EarningDescriptionId",
                principalTable: "EarningDescription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEarning_Employee_EmployeeId",
                table: "EmployeeEarning",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEarning_Job_JobId",
                table: "EmployeeEarning",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
