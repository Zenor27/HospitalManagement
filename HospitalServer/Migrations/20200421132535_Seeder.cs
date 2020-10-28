using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalServer.Migrations
{
    public partial class Seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CreatedAt", "Date", "Description", "PatientId", "StaffId", "Status" },
                values: new object[] { 2, new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), "Rendez-Vous classique", 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "CreatedAt", "Description" },
                values: new object[] { 2, new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), "Portez des masques. Restez prudent." });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FirstName", "LastName" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 25, 34, 798, DateTimeKind.Local).AddTicks(7021), "Denis", "Lastname" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "Background", "CreatedAt", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 2, "EPITA", "Troubles psychologiques", new DateTime(2020, 4, 21, 15, 25, 34, 798, DateTimeKind.Local).AddTicks(7021), "Sylvie", "Lastname", "0000000000" },
                    { 3, "EPITA", "Troubles psychologiques", new DateTime(2020, 4, 21, 15, 25, 34, 798, DateTimeKind.Local).AddTicks(7021), "Antoine", "Lastname", "0000000000" },
                    { 4, "EPITA", "Troubles psychologiques", new DateTime(2020, 4, 21, 15, 25, 34, 798, DateTimeKind.Local).AddTicks(7021), "Xavier", "Login", "0000000000" }
                });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StaffType" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 25, 34, 794, DateTimeKind.Local).AddTicks(6983), 0 });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedAt", "FirstName", "LastName", "PhoneNumber", "StaffType" },
                values: new object[,]
                {
                    { 2, "14 Rue de Villejuif, 94800 Villejuif", new DateTime(2020, 4, 21, 15, 25, 34, 797, DateTimeKind.Local).AddTicks(7012), "Gauthier", "Lastname", "0707070707", 0 },
                    { 3, "14 Rue de Villejuif, 94800 Villejuif", new DateTime(2020, 4, 21, 15, 25, 34, 797, DateTimeKind.Local).AddTicks(7012), "Julien", "Lastname", "0707070707", 1 },
                    { 4, "14 Rue de Villejuif, 94800 Villejuif", new DateTime(2020, 4, 21, 15, 25, 34, 797, DateTimeKind.Local).AddTicks(7012), "Louis", "Lastname", "0707070707", 2 },
                    { 5, "14 Rue de Villejuif, 94800 Villejuif", new DateTime(2020, 4, 21, 15, 25, 34, 797, DateTimeKind.Local).AddTicks(7012), "Albert", "Login", "0707070707", 3 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CreatedAt", "Date", "Description", "PatientId", "StaffId", "Status" },
                values: new object[] { 3, new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), "Rendez-Vous classique", 2, 1, 1 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CreatedAt", "Date", "Description", "PatientId", "StaffId", "Status" },
                values: new object[] { 4, new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), "Rendez-Vous classique", 2, 2, 0 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CreatedAt", "Date", "Description", "PatientId", "StaffId", "Status" },
                values: new object[] { 5, new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), new DateTime(2020, 4, 21, 15, 25, 34, 799, DateTimeKind.Local).AddTicks(7030), "Rendez-Vous classique", 3, 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 17, 17, 11, 45, 694, DateTimeKind.Utc).AddTicks(8568), new DateTime(2020, 4, 17, 17, 11, 45, 694, DateTimeKind.Utc).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 17, 17, 11, 45, 695, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FirstName", "LastName" },
                values: new object[] { new DateTime(2020, 4, 17, 17, 11, 45, 694, DateTimeKind.Utc).AddTicks(8568), "Louis", "Lastname" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StaffType" },
                values: new object[] { new DateTime(2020, 4, 17, 17, 11, 45, 692, DateTimeKind.Utc).AddTicks(8551), 3 });
        }
    }
}
