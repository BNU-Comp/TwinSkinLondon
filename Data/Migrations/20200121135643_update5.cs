using Microsoft.EntityFrameworkCore.Migrations;

namespace TwinSkinLondon.Data.Migrations
{
    public partial class update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Message",
                newName: "DatePublish");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DatePublish",
                table: "Message",
                newName: "Date");
        }
    }
}
