using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalServer.Migrations
{
    public partial class UniqueEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Staffs",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 166, DateTimeKind.Local).AddTicks(7184), "denis@fail.com" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 166, DateTimeKind.Local).AddTicks(7184), "sylvie@fail.com" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 166, DateTimeKind.Local).AddTicks(7184), "login@fail.com" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 166, DateTimeKind.Local).AddTicks(7184), "xavier@fail.com" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 162, DateTimeKind.Local).AddTicks(7145), "antoine@fail.com" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 165, DateTimeKind.Local).AddTicks(7183), "gauthier@fail.com" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 165, DateTimeKind.Local).AddTicks(7183), "julien@fail.com" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 165, DateTimeKind.Local).AddTicks(7183), "louis@fail.com" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 165, DateTimeKind.Local).AddTicks(7183), "albert@fail.com" });

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_Email",
                table: "Staffs",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Email",
                table: "Patients",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Staffs_Email",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Patients_Email",
                table: "Patients");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));

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
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 514, DateTimeKind.Local).AddTicks(8146), "no@fail.com" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 514, DateTimeKind.Local).AddTicks(8146), "no@fail.com" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 514, DateTimeKind.Local).AddTicks(8146), "no@fail.com" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 514, DateTimeKind.Local).AddTicks(8146), "no@fail.com" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 510, DateTimeKind.Local).AddTicks(8104), "no@fail.com" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 513, DateTimeKind.Local).AddTicks(8131), "no@fail.com" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 513, DateTimeKind.Local).AddTicks(8131), "no@fail.com" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 513, DateTimeKind.Local).AddTicks(8131), "no@fail.com" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2020, 4, 22, 21, 59, 33, 513, DateTimeKind.Local).AddTicks(8131), "no@fail.com" });
        }
    }
}
