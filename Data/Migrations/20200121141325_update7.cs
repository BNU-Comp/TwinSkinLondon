using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TwinSkinLondon.Data.Migrations
{
    public partial class update7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //HELLO
            migrationBuilder.DropColumn(
                name: "DateDelivered",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "DateOrdered",
                table: "Order",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "DatePublish",
                table: "Message",
                newName: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Order",
                newName: "DateOrdered");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Message",
                newName: "DatePublish");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDelivered",
                table: "Order",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
