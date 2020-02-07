using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaribPayroll.Data.Migrations
{
    public partial class UpdateEmployeeEntity4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAddress_Employee_EmployeeId",
                table: "EmployeeAddress");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeAddress_EmployeeId",
                table: "EmployeeAddress");

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 6, 0, 13, 45, 5, DateTimeKind.Unspecified).AddTicks(5532), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 6, 0, 13, 45, 8, DateTimeKind.Unspecified).AddTicks(5374), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 6, 0, 13, 45, 8, DateTimeKind.Unspecified).AddTicks(6119), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 6, 0, 13, 45, 8, DateTimeKind.Unspecified).AddTicks(6140), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 6, 0, 13, 45, 8, DateTimeKind.Unspecified).AddTicks(6149), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 6, 0, 13, 45, 8, DateTimeKind.Unspecified).AddTicks(6151), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 6, 0, 13, 45, 8, DateTimeKind.Unspecified).AddTicks(6155), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 6, 0, 13, 45, 8, DateTimeKind.Unspecified).AddTicks(6156), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 6, 0, 13, 45, 8, DateTimeKind.Unspecified).AddTicks(6159), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 6, 0, 13, 45, 8, DateTimeKind.Unspecified).AddTicks(6161), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentPeriod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 6, 0, 13, 45, 10, DateTimeKind.Unspecified).AddTicks(635), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 6, 0, 13, 45, 10, DateTimeKind.Unspecified).AddTicks(678), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentPeriod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 6, 0, 13, 45, 10, DateTimeKind.Unspecified).AddTicks(733), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 6, 0, 13, 45, 10, DateTimeKind.Unspecified).AddTicks(736), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeAddressId",
                table: "Employee",
                column: "EmployeeAddressId",
                unique: true,
                filter: "[EmployeeAddressId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeAddress_EmployeeAddressId",
                table: "Employee",
                column: "EmployeeAddressId",
                principalTable: "EmployeeAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeAddress_EmployeeAddressId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_EmployeeAddressId",
                table: "Employee");

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 5, 23, 20, 38, 237, DateTimeKind.Unspecified).AddTicks(4619), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 5, 23, 20, 38, 239, DateTimeKind.Unspecified).AddTicks(9577), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 5, 23, 20, 38, 240, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 5, 23, 20, 38, 240, DateTimeKind.Unspecified).AddTicks(318), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 5, 23, 20, 38, 240, DateTimeKind.Unspecified).AddTicks(329), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 5, 23, 20, 38, 240, DateTimeKind.Unspecified).AddTicks(331), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 5, 23, 20, 38, 240, DateTimeKind.Unspecified).AddTicks(333), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 5, 23, 20, 38, 240, DateTimeKind.Unspecified).AddTicks(335), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 5, 23, 20, 38, 240, DateTimeKind.Unspecified).AddTicks(337), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 5, 23, 20, 38, 240, DateTimeKind.Unspecified).AddTicks(339), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentPeriod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 5, 23, 20, 38, 241, DateTimeKind.Unspecified).AddTicks(5335), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 5, 23, 20, 38, 241, DateTimeKind.Unspecified).AddTicks(5349), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentPeriod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 5, 23, 20, 38, 241, DateTimeKind.Unspecified).AddTicks(5397), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 5, 23, 20, 38, 241, DateTimeKind.Unspecified).AddTicks(5399), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_EmployeeId",
                table: "EmployeeAddress",
                column: "EmployeeId",
                unique: true,
                filter: "[EmployeeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAddress_Employee_EmployeeId",
                table: "EmployeeAddress",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
