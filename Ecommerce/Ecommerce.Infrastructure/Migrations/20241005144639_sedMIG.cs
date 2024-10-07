using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sedMIG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name", "logo" },
                values: new object[,]
                {
                    { 1, "pc", "https://www.google.com/search?sca_esv=6449538529ffda2f&sxsrf=ADLYWIJLPNJcSg8eNexK0snUEW47SvzYNw:1728138541243&q=%D8%B5%D9%88%D8%B1&udm=2&fbs=AEQNm0BIRlNMsRe0SeE1EXtrwm1mjePOoxRIMPk2gPjqOozch23yls1763fqJ-YUzYzv81ep_VHpm7VSSZUvFi5aYRaMWgwTx1IvZn0TMjsKHvXSPj3Lq20Qs0HT-lFx8kMr7C-Xdnb_ZD9v0QliLURUjeuihX9OBcx5nIno_GQ80GQdoSkkYGQrwdyHaxjsiIKHT5dUco2g_gnjtmLEyID0gBja_7LIL3wcI92GyMmCXvnVrVcDCA0&sa=X&ved=2ahUKEwig-_3eufeIAxVoVqQEHdeiB_MQtKgLegQIDhAB&biw=1707&bih=820&dpr=1.13#vhid=Zpu9rWGEwuB5UM&vssid=mosaic" },
                    { 2, "micro", "https://www.google.com/search?sca_esv=6449538529ffda2f&sxsrf=ADLYWIJLPNJcSg8eNexK0snUEW47SvzYNw:1728138541243&q=%D8%B5%D9%88%D8%B1&udm=2&fbs=AEQNm0BIRlNMsRe0SeE1EXtrwm1mjePOoxRIMPk2gPjqOozch23yls1763fqJ-YUzYzv81ep_VHpm7VSSZUvFi5aYRaMWgwTx1IvZn0TMjsKHvXSPj3Lq20Qs0HT-lFx8kMr7C-Xdnb_ZD9v0QliLURUjeuihX9OBcx5nIno_GQ80GQdoSkkYGQrwdyHaxjsiIKHT5dUco2g_gnjtmLEyID0gBja_7LIL3wcI92GyMmCXvnVrVcDCA0&sa=X&ved=2ahUKEwig-_3eufeIAxVoVqQEHdeiB_MQtKgLegQIDhAB&biw=1707&bih=820&dpr=1.13#vhid=Zpu9rWGEwuB5UM&vssid=mosaic " },
                    { 3, "grel", "https://www.google.com/search?sca_esv=6449538529ffda2f&sxsrf=ADLYWIJLPNJcSg8eNexK0snUEW47SvzYNw:1728138541243&q=%D8%B5%D9%88%D8%B1&udm=2&fbs=AEQNm0BIRlNMsRe0SeE1EXtrwm1mjePOoxRIMPk2gPjqOozch23yls1763fqJ-YUzYzv81ep_VHpm7VSSZUvFi5aYRaMWgwTx1IvZn0TMjsKHvXSPj3Lq20Qs0HT-lFx8kMr7C-Xdnb_ZD9v0QliLURUjeuihX9OBcx5nIno_GQ80GQdoSkkYGQrwdyHaxjsiIKHT5dUco2g_gnjtmLEyID0gBja_7LIL3wcI92GyMmCXvnVrVcDCA0&sa=X&ved=2ahUKEwig-_3eufeIAxVoVqQEHdeiB_MQtKgLegQIDhAB&biw=1707&bih=820&dpr=1.13#vhid=Zpu9rWGEwuB5UM&vssid=mosaic" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 10, 5, 17, 46, 38, 274, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 10, 5, 17, 46, 38, 274, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 10, 5, 17, 46, 38, 274, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Date", "ProductId", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, "aaaaaaaa", new DateTime(2024, 10, 5, 17, 46, 38, 274, DateTimeKind.Local).AddTicks(329), 1, 1, 1 },
                    { 2, "ssssssss", new DateTime(2024, 10, 5, 17, 46, 38, 274, DateTimeKind.Local).AddTicks(333), 1, 1, 1 },
                    { 3, "dddddddd", new DateTime(2024, 10, 5, 17, 46, 38, 274, DateTimeKind.Local).AddTicks(335), 2, 2, 2 },
                    { 4, "ffffffff", new DateTime(2024, 10, 5, 17, 46, 38, 274, DateTimeKind.Local).AddTicks(337), 2, 3, 2 },
                    { 5, "gggggggg", new DateTime(2024, 10, 5, 17, 46, 38, 274, DateTimeKind.Local).AddTicks(340), 2, 4, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 10, 5, 12, 13, 6, 67, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 10, 5, 12, 13, 6, 67, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 10, 5, 12, 13, 6, 67, DateTimeKind.Local).AddTicks(6572));
        }
    }
}
