using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaribPayroll.Data.Migrations
{
    public partial class UpdateEmployeeEntity1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "Department",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Department",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Department",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Department",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDate",
                table: "Department",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                table: "Department",
                rowVersion: true,
                nullable: true);

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 2, 3, 12, 34, 56, 118, DateTimeKind.Unspecified).AddTicks(2680), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 2, 3, 12, 34, 56, 118, DateTimeKind.Unspecified).AddTicks(2699), new TimeSpan(0, -4, 0, 0, 0)) });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Department");

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 415, DateTimeKind.Unspecified).AddTicks(3579), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2194), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2212), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2227), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2228), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2231), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2232), new TimeSpan(0, -4, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DeductionCalculationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2234), new TimeSpan(0, -4, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 1, 30, 18, 12, 15, 418, DateTimeKind.Unspecified).AddTicks(2236), new TimeSpan(0, -4, 0, 0, 0)) });
        }
    }
}
