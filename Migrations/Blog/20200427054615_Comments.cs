using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace yapf1.Migrations.Blog
{
    public partial class Comments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFile",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoLink",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Posted = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    ImageFile = table.Column<string>(nullable: true),
                    VideoLink = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropColumn(
                name: "ImageFile",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "VideoLink",
                table: "Comments");
        }
    }
}
