using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneBookApp.ReportService.DataAccess.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PersonCount = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    PhoneCount = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Location", "PersonCount", "PhoneCount", "Status" },
                values: new object[,]
                {
                    { new Guid("8045f5e4-a5bb-4117-8491-928b3d285ce0"), "Istanbul", 5, 10, 1 },
                    { new Guid("4f955656-c5db-4793-a2bb-0920ac5fb563"), "Rize", 3, 20, 2 },
                    { new Guid("99ec0e66-d598-4819-9a5f-194aed0eb5e8"), "Antalya", 25, 50, 2 },
                    { new Guid("5c31f5e4-ab68-41e0-bbc3-c575059e8918"), "Eskişehir", 35, 150, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
