using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CME_Task.Migrations
{
    /// <inheritdoc />
    public partial class ModifyReservationFKs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("35c68e23-4d68-486f-bfbc-68eb8bbb7220"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4e2c06d3-d8e4-41e4-9297-7e67243923fe"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("535a5a68-4390-4905-b938-e1ed036d3f39"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ae57ffa9-b8ad-4a48-933d-a9a6b09b2310"));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedsNum", "Floor", "Price", "RoomNumber", "RoomType" },
                values: new object[,]
                {
                    { new Guid("45860593-dcb6-4c31-a17f-a0a0d4b00cf3"), 2, 2, 250f, 4, 2 },
                    { new Guid("bded554b-e30d-4cbf-ad2d-c98871f63215"), 1, 1, 100f, 1, 1 },
                    { new Guid("f44beb77-f5a3-4b0c-bdc6-daba09c9adc6"), 2, 2, 200f, 3, 2 },
                    { new Guid("fa4e3740-8027-49ce-808a-18ca61ea3563"), 1, 1, 150f, 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("45860593-dcb6-4c31-a17f-a0a0d4b00cf3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("bded554b-e30d-4cbf-ad2d-c98871f63215"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f44beb77-f5a3-4b0c-bdc6-daba09c9adc6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fa4e3740-8027-49ce-808a-18ca61ea3563"));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedsNum", "Floor", "Price", "RoomNumber", "RoomType" },
                values: new object[,]
                {
                    { new Guid("35c68e23-4d68-486f-bfbc-68eb8bbb7220"), 1, 1, 150f, 2, 3 },
                    { new Guid("4e2c06d3-d8e4-41e4-9297-7e67243923fe"), 1, 1, 100f, 1, 1 },
                    { new Guid("535a5a68-4390-4905-b938-e1ed036d3f39"), 2, 2, 200f, 3, 2 },
                    { new Guid("ae57ffa9-b8ad-4a48-933d-a9a6b09b2310"), 2, 2, 250f, 4, 2 }
                });
        }
    }
}
