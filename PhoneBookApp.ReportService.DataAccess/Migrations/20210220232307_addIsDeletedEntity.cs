using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneBookApp.ReportService.DataAccess.Migrations
{
    public partial class addIsDeletedEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "Reports");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Reports",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reports",
                table: "Reports",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "CreaatedTime", "DemandTime", "IsDeleted", "Location", "PersonCount", "PhoneCount", "Status" },
                values: new object[,]
                {
                    { new Guid("a91a5982-12b0-448a-a1a2-8b1a975f4c66"), new DateTime(2021, 2, 21, 2, 23, 4, 992, DateTimeKind.Local).AddTicks(8050), new DateTime(2021, 2, 21, 2, 23, 4, 996, DateTimeKind.Local).AddTicks(637), false, "Istanbul", 5, 10, 1 },
                    { new Guid("818dbe25-7ce0-4678-8b0c-f9d737fa3cb1"), new DateTime(2021, 2, 21, 2, 23, 4, 996, DateTimeKind.Local).AddTicks(2463), new DateTime(2021, 2, 21, 2, 23, 4, 996, DateTimeKind.Local).AddTicks(2481), true, "Rize", 3, 20, 2 },
                    { new Guid("2c202633-30ab-4ed3-a0f2-8957cc9ead90"), new DateTime(2021, 2, 21, 2, 23, 4, 996, DateTimeKind.Local).AddTicks(2517), new DateTime(2021, 2, 21, 2, 23, 4, 996, DateTimeKind.Local).AddTicks(2519), true, "Antalya", 25, 50, 2 },
                    { new Guid("107ea30b-d10b-4a1f-8b90-eaba051c7d3b"), new DateTime(2021, 2, 21, 2, 23, 4, 996, DateTimeKind.Local).AddTicks(2523), new DateTime(2021, 2, 21, 2, 23, 4, 996, DateTimeKind.Local).AddTicks(2525), false, "Eskişehir", 35, 150, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Reports",
                table: "Reports");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("107ea30b-d10b-4a1f-8b90-eaba051c7d3b"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("2c202633-30ab-4ed3-a0f2-8957cc9ead90"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("818dbe25-7ce0-4678-8b0c-f9d737fa3cb1"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("a91a5982-12b0-448a-a1a2-8b1a975f4c66"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Reports");

            migrationBuilder.RenameTable(
                name: "Reports",
                newName: "Repors");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Repors",
                type: "text",
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
    }
}
