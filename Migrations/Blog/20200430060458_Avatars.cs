using Microsoft.EntityFrameworkCore.Migrations;

namespace yapf1.Migrations.Blog
{
    public partial class Avatars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorAvatar",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorAvatar",
                table: "Comments",
                nullable: true);

             
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorAvatar",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "AuthorAvatar",
                table: "Comments");

             
        }
    }
}
