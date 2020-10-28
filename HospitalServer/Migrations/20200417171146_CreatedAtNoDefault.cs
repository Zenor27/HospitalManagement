using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalServer.Migrations
{
    public partial class CreatedAtNoDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedAt",
                value: new DateTime(2020, 4, 17, 17, 11, 45, 694, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 17, 17, 11, 45, 692, DateTimeKind.Utc).AddTicks(8551));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 4, 17, 17, 7, 15, 862, DateTimeKind.Utc).AddTicks(9179));
        }
    }
}
