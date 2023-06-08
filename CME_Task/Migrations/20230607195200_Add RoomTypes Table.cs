using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CME_Task.Migrations
{
    /// <inheritdoc />
    public partial class AddRoomTypesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("24aa052c-739e-4cc9-92ab-c2df9576c373"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5f3e7dae-2f8c-4797-a4f8-c9355cd9ab4c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("89311eda-6fdb-412e-9896-68504049e3d4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9ad16913-a3db-4c6a-8b4a-8cac0de2b3fd"));

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "RoomType" },
                values: new object[,]
                {
                    { 1, "Standard" },
                    { 2, "Suite" },
                    { 3, "Deluxe" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedsNum", "Floor", "Price", "RoomNumber", "RoomType" },
                values: new object[,]
                {
                    { new Guid("227fe832-6364-48ac-af13-321f937fd1f0"), 2, 2, 250f, 4, 2 },
                    { new Guid("58795f8a-4703-4e32-a636-d558b2fcf81f"), 1, 1, 150f, 2, 3 },
                    { new Guid("9f6dc4c3-1f34-4827-9520-72e66ee202a1"), 2, 2, 200f, 3, 2 },
                    { new Guid("bbc76288-130d-48c0-8e35-8505a7860317"), 1, 1, 100f, 1, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("227fe832-6364-48ac-af13-321f937fd1f0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("58795f8a-4703-4e32-a636-d558b2fcf81f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9f6dc4c3-1f34-4827-9520-72e66ee202a1"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("bbc76288-130d-48c0-8e35-8505a7860317"));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedsNum", "Floor", "Price", "RoomNumber", "RoomType" },
                values: new object[,]
                {
                    { new Guid("24aa052c-739e-4cc9-92ab-c2df9576c373"), 1, 1, 150f, 2, 2 },
                    { new Guid("5f3e7dae-2f8c-4797-a4f8-c9355cd9ab4c"), 2, 2, 250f, 4, 1 },
                    { new Guid("89311eda-6fdb-412e-9896-68504049e3d4"), 2, 2, 200f, 3, 1 },
                    { new Guid("9ad16913-a3db-4c6a-8b4a-8cac0de2b3fd"), 1, 1, 100f, 1, 0 }
                });
        }
    }
}
