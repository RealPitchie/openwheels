using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace yapf1.Migrations.Blog
{
    public partial class Longread : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Longreads",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Posted = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true),
                    Text = table.Column<string[]>(nullable: true),
                    ImageFile = table.Column<string[]>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    Author = table.Column<string>(nullable: true),
                    AuthorAvatar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Longreads", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Longreads");
        }
    }
}
