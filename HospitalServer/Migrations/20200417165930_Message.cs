using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalServer.Migrations
{
    public partial class Message : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 4, 17, 16, 59, 30, 341, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "CreatedAt", "Description" },
                values: new object[] { 1, new DateTime(2020, 4, 17, 16, 59, 30, 341, DateTimeKind.Utc).AddTicks(5424), "Alerte COVID-19. Restez prudent." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 4, 17, 16, 54, 29, 276, DateTimeKind.Utc).AddTicks(9085));
        }
    }
}
