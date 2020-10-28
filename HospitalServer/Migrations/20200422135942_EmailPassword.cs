using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalServer.Migrations
{
    public partial class EmailPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Staffs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Staffs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Patients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Patients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920), new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920), new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920), new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920), new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920), new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 22, 15, 59, 42, 116, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 22, 15, 59, 42, 116, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920), "no@fail.com", "" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920), "no@fail.com", "" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920), "no@fail.com", "" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920), "no@fail.com", "" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 110, DateTimeKind.Local).AddTicks(6875), "no@fail.com", "" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 114, DateTimeKind.Local).AddTicks(6911), "no@fail.com", "" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 114, DateTimeKind.Local).AddTicks(6911), "no@fail.com", "" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 114, DateTimeKind.Local).AddTicks(6911), "no@fail.com", "" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 114, DateTimeKind.Local).AddTicks(6911), "no@fail.com", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Patients");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 21, 15, 25, 34, 798, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 21, 15, 25, 34, 798, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 21, 15, 25, 34, 798, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 21, 15, 25, 34, 798, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 21, 15, 25, 34, 794, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 21, 15, 25, 34, 797, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 21, 15, 25, 34, 797, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 21, 15, 25, 34, 797, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 21, 15, 25, 34, 797, DateTimeKind.Local).AddTicks(7012));
        }
    }
}
