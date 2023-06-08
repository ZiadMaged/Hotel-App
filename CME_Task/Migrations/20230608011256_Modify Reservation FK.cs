using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CME_Task.Migrations
{
    /// <inheritdoc />
    public partial class ModifyReservationFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }
    }
}
