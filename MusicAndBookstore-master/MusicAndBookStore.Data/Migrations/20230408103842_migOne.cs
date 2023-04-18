using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicAndBookStore.Data.Migrations
{
    public partial class migOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BasePrice = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBNNumber = table.Column<int>(type: "int", nullable: true),
                    WriterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMDBRate = table.Column<double>(type: "float", nullable: true),
                    SingerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfSongs = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
