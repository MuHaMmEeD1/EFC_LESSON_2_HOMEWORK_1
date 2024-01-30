using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC_LESSON_2_HOMEWORK_1.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Presss_PressId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Themes_ThemeId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PressId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ThemeId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PressId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ThemeId",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PressId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThemeId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_PressId",
                table: "Books",
                column: "PressId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_ThemeId",
                table: "Books",
                column: "ThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Presss_PressId",
                table: "Books",
                column: "PressId",
                principalTable: "Presss",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Themes_ThemeId",
                table: "Books",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "Id");
        }
    }
}
