using Microsoft.EntityFrameworkCore.Migrations;

namespace TwinSkinLondon.Data.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Address_AddressID",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_AddressID",
                table: "Customers",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_AddressID",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Address_AddressID",
                table: "Customers",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
