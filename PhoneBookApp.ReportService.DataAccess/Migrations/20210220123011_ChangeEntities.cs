using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneBookApp.ReportService.DataAccess.Migrations
{
    public partial class ChangeEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreaatedTime",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreaatedTime", "DemandTime", "Location", "PersonCount", "PhoneCount", "Status" },
                values: new object[,]
                {
                    { new Guid("75331445-ffd9-46b3-912f-3919f0bdd7b3"), new DateTime(2021, 2, 20, 15, 30, 9, 478, DateTimeKind.Local).AddTicks(2637), new DateTime(2021, 2, 20, 15, 30, 9, 479, DateTimeKind.Local).AddTicks(8275), "Istanbul", 5, 10, 1 },
                    { new Guid("b04b8919-a184-413e-ad96-666847ccd606"), new DateTime(2021, 2, 20, 15, 30, 9, 479, DateTimeKind.Local).AddTicks(9382), new DateTime(2021, 2, 20, 15, 30, 9, 479, DateTimeKind.Local).AddTicks(9404), "Rize", 3, 20, 2 },
                    { new Guid("24e89a68-fb03-49eb-8000-1a2e03bba3ed"), new DateTime(2021, 2, 20, 15, 30, 9, 479, DateTimeKind.Local).AddTicks(9431), new DateTime(2021, 2, 20, 15, 30, 9, 479, DateTimeKind.Local).AddTicks(9435), "Antalya", 25, 50, 2 },
                    { new Guid("c5fd9cb3-0ef6-4d34-a8f3-e33fa63a242e"), new DateTime(2021, 2, 20, 15, 30, 9, 479, DateTimeKind.Local).AddTicks(9439), new DateTime(2021, 2, 20, 15, 30, 9, 479, DateTimeKind.Local).AddTicks(9441), "Eskişehir", 35, 150, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24e89a68-fb03-49eb-8000-1a2e03bba3ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75331445-ffd9-46b3-912f-3919f0bdd7b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b04b8919-a184-413e-ad96-666847ccd606"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5fd9cb3-0ef6-4d34-a8f3-e33fa63a242e"));

            migrationBuilder.DropColumn(
                name: "CreaatedTime",
                table: "Users");

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
    }
}
