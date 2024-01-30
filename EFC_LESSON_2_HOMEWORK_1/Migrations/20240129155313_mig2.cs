using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC_LESSON_2_HOMEWORK_1.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Books_BookId",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Libs_LibId",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Students_StudentId1",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Books_BookId",
                table: "T_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Libs_LibId",
                table: "T_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Teachers_TeacherId1",
                table: "T_Cards");

            migrationBuilder.DropIndex(
                name: "IX_T_Cards_BookId",
                table: "T_Cards");

            migrationBuilder.DropIndex(
                name: "IX_T_Cards_LibId",
                table: "T_Cards");

            migrationBuilder.DropIndex(
                name: "IX_T_Cards_TeacherId1",
                table: "T_Cards");

            migrationBuilder.DropIndex(
                name: "IX_Students_GroupId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_S_Cards_BookId",
                table: "S_Cards");

            migrationBuilder.DropIndex(
                name: "IX_S_Cards_LibId",
                table: "S_Cards");

            migrationBuilder.DropIndex(
                name: "IX_S_Cards_StudentId1",
                table: "S_Cards");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "T_Cards");

            migrationBuilder.DropColumn(
                name: "LibId",
                table: "T_Cards");

            migrationBuilder.DropColumn(
                name: "TeacherId1",
                table: "T_Cards");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "S_Cards");

            migrationBuilder.DropColumn(
                name: "LibId",
                table: "S_Cards");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "S_Cards");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "T_Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LibId",
                table: "T_Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId1",
                table: "T_Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "S_Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LibId",
                table: "S_Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId1",
                table: "S_Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_BookId",
                table: "T_Cards",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_LibId",
                table: "T_Cards",
                column: "LibId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_TeacherId1",
                table: "T_Cards",
                column: "TeacherId1");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_BookId",
                table: "S_Cards",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_LibId",
                table: "S_Cards",
                column: "LibId");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_StudentId1",
                table: "S_Cards",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Books_BookId",
                table: "S_Cards",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Libs_LibId",
                table: "S_Cards",
                column: "LibId",
                principalTable: "Libs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Students_StudentId1",
                table: "S_Cards",
                column: "StudentId1",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Books_BookId",
                table: "T_Cards",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Libs_LibId",
                table: "T_Cards",
                column: "LibId",
                principalTable: "Libs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Teachers_TeacherId1",
                table: "T_Cards",
                column: "TeacherId1",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
