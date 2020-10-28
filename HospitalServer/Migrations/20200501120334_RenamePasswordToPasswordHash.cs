using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalServer.Migrations
{
    public partial class RenamePasswordToPasswordHash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("Password", "Staffs", "PasswordHash");
            migrationBuilder.RenameColumn("Password", "Patients", "PasswordHash");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("PasswordHash", "Staffs", "Password");
            migrationBuilder.RenameColumn("PasswordHash", "Patients", "Password");
        }
    }
}
