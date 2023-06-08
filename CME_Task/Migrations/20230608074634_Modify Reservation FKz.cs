using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CME_Task.Migrations
{
    /// <inheritdoc />
    public partial class ModifyReservationFKz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4983d095-89fb-4293-b24e-155a20f76081"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("92dfa817-3a6f-4e61-a1c4-dfa911f52e5e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("aaa615fd-0ef9-4181-a372-7d35e2cccb17"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e6cc4734-c083-4e66-8b1f-1483ee5b09f7"));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedsNum", "Floor", "Price", "RoomNumber", "RoomType" },
                values: new object[,]
                {
                    { new Guid("218e8701-27b1-4c20-aaf8-cdc21901efed"), 1, 1, 150f, 2, 3 },
                    { new Guid("d410cd65-deb1-4197-8463-c3c788998d82"), 2, 2, 250f, 4, 2 },
                    { new Guid("e037ce53-49bd-4268-a60f-2643b0b3c1d8"), 1, 1, 100f, 1, 1 },
                    { new Guid("e925c33e-b838-4b38-9acf-2b1727fc1875"), 2, 2, 200f, 3, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("218e8701-27b1-4c20-aaf8-cdc21901efed"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d410cd65-deb1-4197-8463-c3c788998d82"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e037ce53-49bd-4268-a60f-2643b0b3c1d8"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e925c33e-b838-4b38-9acf-2b1727fc1875"));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedsNum", "Floor", "Price", "RoomNumber", "RoomType" },
                values: new object[,]
                {
                    { new Guid("4983d095-89fb-4293-b24e-155a20f76081"), 1, 1, 100f, 1, 1 },
                    { new Guid("92dfa817-3a6f-4e61-a1c4-dfa911f52e5e"), 1, 1, 150f, 2, 3 },
                    { new Guid("aaa615fd-0ef9-4181-a372-7d35e2cccb17"), 2, 2, 200f, 3, 2 },
                    { new Guid("e6cc4734-c083-4e66-8b1f-1483ee5b09f7"), 2, 2, 250f, 4, 2 }
                });
        }
    }
}
