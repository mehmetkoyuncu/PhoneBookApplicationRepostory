using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneBookApp.PersonService.DataAccess.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("480ab9a9-dafd-4c37-99cf-6c34f74af816"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c05736af-3109-4197-b412-34a027d43cc6"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CompanyName", "CreatedTime", "IsDeleted", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("af5c2744-fe13-4b59-b79a-df9ad25e8d89"), "Bilge Adam", new DateTime(2021, 2, 21, 1, 25, 40, 700, DateTimeKind.Local).AddTicks(5431), false, "Mehmet", "Koyuncu" },
                    { new Guid("b2dcad91-97b5-4cce-a199-3c2d2bec1e55"), "Setur", new DateTime(2021, 2, 21, 1, 25, 40, 703, DateTimeKind.Local).AddTicks(2458), true, "Name 1", "Name 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af5c2744-fe13-4b59-b79a-df9ad25e8d89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2dcad91-97b5-4cce-a199-3c2d2bec1e55"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CompanyName", "CreatedTime", "IsDeleted", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("480ab9a9-dafd-4c37-99cf-6c34f74af816"), "Bilge Adam", new DateTime(2021, 2, 15, 15, 38, 9, 667, DateTimeKind.Local).AddTicks(5308), false, "Mehmet", "Koyuncu" },
                    { new Guid("c05736af-3109-4197-b412-34a027d43cc6"), "Setur", new DateTime(2021, 2, 15, 15, 38, 9, 692, DateTimeKind.Local).AddTicks(9661), true, "Name 1", "Name 2" }
                });
        }
    }
}
