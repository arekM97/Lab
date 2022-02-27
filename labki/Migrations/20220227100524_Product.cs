using Microsoft.EntityFrameworkCore.Migrations;

namespace labki.Migrations
{
    public partial class Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsVisible",
                table: "Products",
                newName: "IsGood");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsGood",
                table: "Products",
                newName: "IsGood");
        }
    }
}
