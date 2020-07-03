using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace yapf1.Migrations.Blog
{
    public partial class InitialBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
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
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: true),
                    AuthorShown = table.Column<bool>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Posted = table.Column<DateTime>(nullable: false),
                    PostId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
