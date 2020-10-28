using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalServer.Migrations
{
    public partial class PasswordForAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 515, DateTimeKind.Local).AddTicks(8149), new DateTime(2020, 4, 22, 21, 59, 33, 515, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 515, DateTimeKind.Local).AddTicks(8149), new DateTime(2020, 4, 22, 21, 59, 33, 515, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 515, DateTimeKind.Local).AddTicks(8149), new DateTime(2020, 4, 22, 21, 59, 33, 515, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 515, DateTimeKind.Local).AddTicks(8149), new DateTime(2020, 4, 22, 21, 59, 33, 515, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 515, DateTimeKind.Local).AddTicks(8149), new DateTime(2020, 4, 22, 21, 59, 33, 515, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 22, 21, 59, 33, 515, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 22, 21, 59, 33, 516, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 514, DateTimeKind.Local).AddTicks(8146), "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 514, DateTimeKind.Local).AddTicks(8146), "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 514, DateTimeKind.Local).AddTicks(8146), "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 514, DateTimeKind.Local).AddTicks(8146), "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 510, DateTimeKind.Local).AddTicks(8104), "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 513, DateTimeKind.Local).AddTicks(8131), "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 513, DateTimeKind.Local).AddTicks(8131), "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 513, DateTimeKind.Local).AddTicks(8131), "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 513, DateTimeKind.Local).AddTicks(8131), "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920), "" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920), "" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920), "" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 115, DateTimeKind.Local).AddTicks(6920), "" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 110, DateTimeKind.Local).AddTicks(6875), "" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 114, DateTimeKind.Local).AddTicks(6911), "" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 114, DateTimeKind.Local).AddTicks(6911), "" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 114, DateTimeKind.Local).AddTicks(6911), "" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 4, 22, 15, 59, 42, 114, DateTimeKind.Local).AddTicks(6911), "" });
        }
    }
}
