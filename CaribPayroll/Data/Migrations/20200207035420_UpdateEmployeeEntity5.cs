using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaribPayroll.Data.Migrations
{
    public partial class UpdateEmployeeEntity5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_Surname_FirstName_MiddleName",
                table: "Employee");

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 6, 23, 54, 19, 663, DateTimeKind.Unspecified).AddTicks(7007), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 6, 23, 54, 19, 666, DateTimeKind.Unspecified).AddTicks(9990), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 6, 23, 54, 19, 667, DateTimeKind.Unspecified).AddTicks(742), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 6, 23, 54, 19, 667, DateTimeKind.Unspecified).AddTicks(760), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 6, 23, 54, 19, 667, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 6, 23, 54, 19, 667, DateTimeKind.Unspecified).AddTicks(772), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 6, 23, 54, 19, 667, DateTimeKind.Unspecified).AddTicks(774), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 6, 23, 54, 19, 667, DateTimeKind.Unspecified).AddTicks(776), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 6, 23, 54, 19, 667, DateTimeKind.Unspecified).AddTicks(779), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 6, 23, 54, 19, 667, DateTimeKind.Unspecified).AddTicks(780), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentPeriod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 6, 23, 54, 19, 668, DateTimeKind.Unspecified).AddTicks(4908), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 6, 23, 54, 19, 668, DateTimeKind.Unspecified).AddTicks(4931), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentPeriod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 6, 23, 54, 19, 668, DateTimeKind.Unspecified).AddTicks(4982), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 6, 23, 54, 19, 668, DateTimeKind.Unspecified).AddTicks(4985), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Surname_FirstName_MiddleName_EmployeeNo",
                table: "Employee",
                columns: new[] { "Surname", "FirstName", "MiddleName", "EmployeeNo" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_Surname_FirstName_MiddleName_EmployeeNo",
                table: "Employee");

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
                name: "IX_Employee_Surname_FirstName_MiddleName",
                table: "Employee",
                columns: new[] { "Surname", "FirstName", "MiddleName" },
                unique: true);
        }
    }
}
