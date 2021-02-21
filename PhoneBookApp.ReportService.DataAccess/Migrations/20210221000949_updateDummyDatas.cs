using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneBookApp.ReportService.DataAccess.Migrations
{
    public partial class updateDummyDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "CreaatedTime", "DemandTime", "IsDeleted", "Location", "PersonCount", "PhoneCount", "Status" },
                values: new object[,]
                {
                    { new Guid("a8d1c8d1-560a-415f-b41f-ba4385b57dad"), new DateTime(2021, 2, 21, 3, 9, 48, 299, DateTimeKind.Local).AddTicks(7713), new DateTime(2021, 2, 21, 3, 9, 48, 301, DateTimeKind.Local).AddTicks(6463), false, "Istanbul", 5, 10, 1 },
                    { new Guid("ca0a304b-d0e0-4875-b9cc-501bb36f6063"), new DateTime(2021, 2, 21, 3, 9, 48, 301, DateTimeKind.Local).AddTicks(8431), new DateTime(2021, 2, 21, 3, 9, 48, 301, DateTimeKind.Local).AddTicks(8452), true, "Rize", 3, 20, 2 },
                    { new Guid("d6d14f22-a678-4c34-bb31-ad4985a64de5"), new DateTime(2021, 2, 21, 3, 9, 48, 301, DateTimeKind.Local).AddTicks(8497), new DateTime(2021, 2, 21, 3, 9, 48, 301, DateTimeKind.Local).AddTicks(8501), true, "Antalya", 25, 50, 2 },
                    { new Guid("f55921b7-c4c3-4a15-ac34-9666cb2446dc"), new DateTime(2021, 2, 21, 3, 9, 48, 301, DateTimeKind.Local).AddTicks(8508), new DateTime(2021, 2, 21, 3, 9, 48, 301, DateTimeKind.Local).AddTicks(8509), false, "Eskişehir", 35, 150, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("a8d1c8d1-560a-415f-b41f-ba4385b57dad"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("ca0a304b-d0e0-4875-b9cc-501bb36f6063"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("d6d14f22-a678-4c34-bb31-ad4985a64de5"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("f55921b7-c4c3-4a15-ac34-9666cb2446dc"));

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
    }
}
