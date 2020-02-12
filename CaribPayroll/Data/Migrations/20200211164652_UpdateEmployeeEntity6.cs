using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaribPayroll.Data.Migrations
{
    public partial class UpdateEmployeeEntity6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "EmployeeDeduction",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeDeduction",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "EmployeeDeduction",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "EmployeeDeduction",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDate",
                table: "EmployeeDeduction",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                table: "EmployeeDeduction",
                rowVersion: true,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 11, 12, 46, 51, 823, DateTimeKind.Unspecified).AddTicks(6895), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 11, 12, 46, 51, 826, DateTimeKind.Unspecified).AddTicks(3799), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 11, 12, 46, 51, 826, DateTimeKind.Unspecified).AddTicks(4477), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 11, 12, 46, 51, 826, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 11, 12, 46, 51, 826, DateTimeKind.Unspecified).AddTicks(4507), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 11, 12, 46, 51, 826, DateTimeKind.Unspecified).AddTicks(4509), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 11, 12, 46, 51, 826, DateTimeKind.Unspecified).AddTicks(4511), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 11, 12, 46, 51, 826, DateTimeKind.Unspecified).AddTicks(4513), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 11, 12, 46, 51, 826, DateTimeKind.Unspecified).AddTicks(4515), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 11, 12, 46, 51, 826, DateTimeKind.Unspecified).AddTicks(4517), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentPeriod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 11, 12, 46, 51, 827, DateTimeKind.Unspecified).AddTicks(8491), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 11, 12, 46, 51, 827, DateTimeKind.Unspecified).AddTicks(8514), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentPeriod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 11, 12, 46, 51, 827, DateTimeKind.Unspecified).AddTicks(8563), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 11, 12, 46, 51, 827, DateTimeKind.Unspecified).AddTicks(8565), new TimeSpan(0, -4, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action",
                table: "EmployeeDeduction");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeDeduction");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "EmployeeDeduction");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "EmployeeDeduction");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "EmployeeDeduction");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "EmployeeDeduction");

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
        }
    }
}
