using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneBookApp.ReportService.DataAccess.Migrations
{
    public partial class UpdateEntityAndPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

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

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Repors");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Repors",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Repors",
                table: "Repors",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Repors",
                columns: new[] { "Id", "CreaatedTime", "DemandTime", "Location", "Name", "PersonCount", "PhoneCount", "Status" },
                values: new object[,]
                {
                    { new Guid("84e58e81-875d-4809-949c-65cacd40d496"), new DateTime(2021, 2, 21, 1, 24, 25, 775, DateTimeKind.Local).AddTicks(6542), new DateTime(2021, 2, 21, 1, 24, 25, 776, DateTimeKind.Local).AddTicks(8080), "Istanbul", null, 5, 10, 1 },
                    { new Guid("6adac263-d409-4e21-b528-423efc6d8d55"), new DateTime(2021, 2, 21, 1, 24, 25, 776, DateTimeKind.Local).AddTicks(8839), new DateTime(2021, 2, 21, 1, 24, 25, 776, DateTimeKind.Local).AddTicks(8854), "Rize", null, 3, 20, 2 },
                    { new Guid("141310bc-d23d-419e-9bf6-c6b375a72997"), new DateTime(2021, 2, 21, 1, 24, 25, 776, DateTimeKind.Local).AddTicks(8870), new DateTime(2021, 2, 21, 1, 24, 25, 776, DateTimeKind.Local).AddTicks(8872), "Antalya", null, 25, 50, 2 },
                    { new Guid("d204bedd-c9ba-4666-b762-2dda5cb32ade"), new DateTime(2021, 2, 21, 1, 24, 25, 776, DateTimeKind.Local).AddTicks(8874), new DateTime(2021, 2, 21, 1, 24, 25, 776, DateTimeKind.Local).AddTicks(8876), "Eskişehir", null, 35, 150, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Repors",
                table: "Repors");

            migrationBuilder.DeleteData(
                table: "Repors",
                keyColumn: "Id",
                keyValue: new Guid("141310bc-d23d-419e-9bf6-c6b375a72997"));

            migrationBuilder.DeleteData(
                table: "Repors",
                keyColumn: "Id",
                keyValue: new Guid("6adac263-d409-4e21-b528-423efc6d8d55"));

            migrationBuilder.DeleteData(
                table: "Repors",
                keyColumn: "Id",
                keyValue: new Guid("84e58e81-875d-4809-949c-65cacd40d496"));

            migrationBuilder.DeleteData(
                table: "Repors",
                keyColumn: "Id",
                keyValue: new Guid("d204bedd-c9ba-4666-b762-2dda5cb32ade"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Repors");

            migrationBuilder.RenameTable(
                name: "Repors",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

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
    }
}
