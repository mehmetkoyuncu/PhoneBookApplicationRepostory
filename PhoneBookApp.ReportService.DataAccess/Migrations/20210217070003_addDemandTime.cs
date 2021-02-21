using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneBookApp.ReportService.DataAccess.Migrations
{
    public partial class addDemandTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f955656-c5db-4793-a2bb-0920ac5fb563"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c31f5e4-ab68-41e0-bbc3-c575059e8918"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8045f5e4-a5bb-4117-8491-928b3d285ce0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99ec0e66-d598-4819-9a5f-194aed0eb5e8"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DemandTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DemandTime", "Location", "PersonCount", "PhoneCount", "Status" },
                values: new object[,]
                {
                    { new Guid("36cca656-ec46-4a8e-a872-63b01379bbb6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Istanbul", 5, 10, 1 },
                    { new Guid("e02a3bae-2a4c-4a44-bcf1-f734e037a7ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rize", 3, 20, 2 },
                    { new Guid("eca0f21d-4cba-4720-9545-26656fa1fe05"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antalya", 25, 50, 2 },
                    { new Guid("99b60188-4903-49e6-8748-42b1bbc921b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eskişehir", 35, 150, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36cca656-ec46-4a8e-a872-63b01379bbb6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99b60188-4903-49e6-8748-42b1bbc921b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e02a3bae-2a4c-4a44-bcf1-f734e037a7ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eca0f21d-4cba-4720-9545-26656fa1fe05"));

            migrationBuilder.DropColumn(
                name: "DemandTime",
                table: "Users");

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
    }
}
