using Microsoft.EntityFrameworkCore.Migrations;

namespace TwinSkinLondon.Data.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Review",
                newName: "DateSent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateSent",
                table: "Review",
                newName: "Date");
        }
    }
}
