using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalServer.Migrations
{
    public partial class Staff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Staffs");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Staffs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Staffs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffType",
                table: "Staffs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "FirstName", "LastName", "PhoneNumber", "StaffType" },
                values: new object[] { "14 Rue de Villejuif, 94800 Villejuif", "Antoine", "Lastname", "0707070707", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "StaffType",
                table: "Staffs");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Plic Federis");
        }
    }
}
