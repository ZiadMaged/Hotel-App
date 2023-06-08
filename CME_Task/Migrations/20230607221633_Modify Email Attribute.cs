using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CME_Task.Migrations
{
    /// <inheritdoc />
    public partial class ModifyEmailAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "RoomType",
                table: "RoomTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "RoomType",
                table: "RoomTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
