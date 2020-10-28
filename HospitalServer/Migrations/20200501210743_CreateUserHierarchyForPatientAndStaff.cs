using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalServer.Migrations
{
    public partial class CreateUserHierarchyForPatientAndStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Staffs_StaffId",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UserType = table.Column<int>(nullable: false),
                    Background = table.Column<string>(nullable: true),
                    StaffType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 1, 23, 7, 42, 840, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 1, 23, 7, 42, 841, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "UserType", "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber", "Background" },
                values: new object[,]
                {
                    { 6, "EPITA", new DateTime(2020, 5, 1, 23, 7, 42, 842, DateTimeKind.Local).AddTicks(3079), 1, "denis@fail.com", "Denis", "Lastname", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0000000000", "Troubles psychologiques" },
                    { 7, "EPITA", new DateTime(2020, 5, 1, 23, 7, 42, 842, DateTimeKind.Local).AddTicks(3079), 1, "sylvie@fail.com", "Sylvie", "Lastname", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0000000000", "Troubles psychologiques" },
                    { 8, "EPITA", new DateTime(2020, 5, 1, 23, 7, 42, 842, DateTimeKind.Local).AddTicks(3079), 1, "Login@fail.com", "Antoine", "Login", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0000000000", "Troubles psychologiques" },
                    { 9, "EPITA", new DateTime(2020, 5, 1, 23, 7, 42, 842, DateTimeKind.Local).AddTicks(3079), 1, "xavier@fail.com", "Xavier", "Login", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0000000000", "Troubles psychologiques" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "UserType", "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber", "StaffType" },
                values: new object[,]
                {
                    { 1, "14 Rue de Villejuif, 94800 Villejuif", new DateTime(2020, 5, 1, 23, 7, 42, 842, DateTimeKind.Local).AddTicks(3079), 0, "antoine@fail.com", "Antoine", "Lastname", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0707070707", 0 },
                    { 2, "14 Rue de Villejuif, 94800 Villejuif", new DateTime(2020, 5, 1, 23, 7, 42, 842, DateTimeKind.Local).AddTicks(3079), 0, "gauthier@fail.com", "Gauthier", "Lastname", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0707070707", 0 },
                    { 3, "14 Rue de Villejuif, 94800 Villejuif", new DateTime(2020, 5, 1, 23, 7, 42, 842, DateTimeKind.Local).AddTicks(3079), 0, "julien@fail.com", "Julien", "Lastname", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0707070707", 1 },
                    { 4, "14 Rue de Villejuif, 94800 Villejuif", new DateTime(2020, 5, 1, 23, 7, 42, 842, DateTimeKind.Local).AddTicks(3079), 0, "louis@fail.com", "Louis", "Lastname", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0707070707", 2 },
                    { 5, "14 Rue de Villejuif, 94800 Villejuif", new DateTime(2020, 5, 1, 23, 7, 42, 842, DateTimeKind.Local).AddTicks(3079), 0, "albert@fail.com", "Albert", "Login", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0707070707", 3 }
                });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date", "PatientId" },
                values: new object[] { new DateTime(2020, 5, 1, 23, 7, 42, 843, DateTimeKind.Local).AddTicks(3078), new DateTime(2020, 5, 1, 23, 7, 42, 843, DateTimeKind.Local).AddTicks(3078), 6 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date", "PatientId" },
                values: new object[] { new DateTime(2020, 5, 1, 23, 7, 42, 843, DateTimeKind.Local).AddTicks(3078), new DateTime(2020, 5, 1, 23, 7, 42, 843, DateTimeKind.Local).AddTicks(3078), 6 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Date", "PatientId" },
                values: new object[] { new DateTime(2020, 5, 1, 23, 7, 42, 843, DateTimeKind.Local).AddTicks(3078), new DateTime(2020, 5, 1, 23, 7, 42, 843, DateTimeKind.Local).AddTicks(3078), 7 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Date", "PatientId" },
                values: new object[] { new DateTime(2020, 5, 1, 23, 7, 42, 843, DateTimeKind.Local).AddTicks(3078), new DateTime(2020, 5, 1, 23, 7, 42, 843, DateTimeKind.Local).AddTicks(3078), 7 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Date", "PatientId" },
                values: new object[] { new DateTime(2020, 5, 1, 23, 7, 42, 843, DateTimeKind.Local).AddTicks(3078), new DateTime(2020, 5, 1, 23, 7, 42, 843, DateTimeKind.Local).AddTicks(3078), 8 });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Users_PatientId",
                table: "Appointments",
                column: "PatientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Users_StaffId",
                table: "Appointments",
                column: "StaffId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Users_PatientId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Users_StaffId",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "Background", "CreatedAt", "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "EPITA", "Troubles psychologiques", new DateTime(2020, 4, 22, 22, 29, 4, 166, DateTimeKind.Local).AddTicks(7184), "denis@fail.com", "Denis", "Lastname", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0000000000" },
                    { 2, "EPITA", "Troubles psychologiques", new DateTime(2020, 4, 22, 22, 29, 4, 166, DateTimeKind.Local).AddTicks(7184), "sylvie@fail.com", "Sylvie", "Lastname", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0000000000" },
                    { 3, "EPITA", "Troubles psychologiques", new DateTime(2020, 4, 22, 22, 29, 4, 166, DateTimeKind.Local).AddTicks(7184), "Login@fail.com", "Antoine", "Login", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0000000000" },
                    { 4, "EPITA", "Troubles psychologiques", new DateTime(2020, 4, 22, 22, 29, 4, 166, DateTimeKind.Local).AddTicks(7184), "xavier@fail.com", "Xavier", "Login", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0000000000" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "StaffType" },
                values: new object[,]
                {
                    { 1, "14 Rue de Villejuif, 94800 Villejuif", new DateTime(2020, 4, 22, 22, 29, 4, 162, DateTimeKind.Local).AddTicks(7145), "antoine@fail.com", "Antoine", "Lastname", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0707070707", 0 },
                    { 2, "14 Rue de Villejuif, 94800 Villejuif", new DateTime(2020, 4, 22, 22, 29, 4, 165, DateTimeKind.Local).AddTicks(7183), "gauthier@fail.com", "Gauthier", "Lastname", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0707070707", 0 },
                    { 3, "14 Rue de Villejuif, 94800 Villejuif", new DateTime(2020, 4, 22, 22, 29, 4, 165, DateTimeKind.Local).AddTicks(7183), "julien@fail.com", "Julien", "Lastname", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0707070707", 1 },
                    { 4, "14 Rue de Villejuif, 94800 Villejuif", new DateTime(2020, 4, 22, 22, 29, 4, 165, DateTimeKind.Local).AddTicks(7183), "louis@fail.com", "Louis", "Lastname", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0707070707", 2 },
                    { 5, "14 Rue de Villejuif, 94800 Villejuif", new DateTime(2020, 4, 22, 22, 29, 4, 165, DateTimeKind.Local).AddTicks(7183), "albert@fail.com", "Albert", "Login", "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK", "0707070707", 3 }
                });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date", "PatientId" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date", "PatientId" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Date", "PatientId" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Date", "PatientId" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Date", "PatientId" },
                values: new object[] { new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), new DateTime(2020, 4, 22, 22, 29, 4, 167, DateTimeKind.Local).AddTicks(7196), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Email",
                table: "Patients",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_Email",
                table: "Staffs",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Staffs_StaffId",
                table: "Appointments",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
