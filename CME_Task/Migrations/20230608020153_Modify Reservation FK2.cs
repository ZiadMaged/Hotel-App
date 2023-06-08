using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CME_Task.Migrations
{
    /// <inheritdoc />
    public partial class ModifyReservationFK2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("25255e39-3ca7-4e2d-ae84-ce62ada15a1b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("30e3ba56-dcdc-43d2-aad9-ddbeb0239dd4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6796bd08-8d50-4275-a852-1f75bfa6da79"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9934b605-9bb7-4d7d-9867-0bd4f8e354c6"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("25255e39-3ca7-4e2d-ae84-ce62ada15a1b"), 1, 1, 100f, 1, 1 },
                    { new Guid("30e3ba56-dcdc-43d2-aad9-ddbeb0239dd4"), 2, 2, 250f, 4, 2 },
                    { new Guid("6796bd08-8d50-4275-a852-1f75bfa6da79"), 1, 1, 150f, 2, 3 },
                    { new Guid("9934b605-9bb7-4d7d-9867-0bd4f8e354c6"), 2, 2, 200f, 3, 2 }
                });
        }
    }
}
