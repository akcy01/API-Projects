using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicAndBookStore.Data.Migrations
{
    public partial class migTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Products",
                type: "int",
                nullable: true);
        }
    }
}
