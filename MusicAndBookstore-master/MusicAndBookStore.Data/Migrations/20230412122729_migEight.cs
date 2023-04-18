using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicAndBookStore.Data.Migrations
{
    public partial class migEight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Products",
                type: "float",
                nullable: true);
        }
    }
}
