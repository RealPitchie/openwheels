using Microsoft.EntityFrameworkCore.Migrations;

namespace yapf1.Migrations.Blog
{
    public partial class LongreadProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PostId",
                table: "Comments");

             

            migrationBuilder.AddColumn<string>(
                name: "LongreadId",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_LongreadId",
                table: "Comments",
                column: "LongreadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Longreads_LongreadId",
                table: "Comments",
                column: "LongreadId",
                principalTable: "Longreads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Longreads_LongreadId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_LongreadId",
                table: "Comments");

             

            migrationBuilder.DropColumn(
                name: "LongreadId",
                table: "Comments");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
