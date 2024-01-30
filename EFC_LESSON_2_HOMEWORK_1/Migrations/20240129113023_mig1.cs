using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC_LESSON_2_HOMEWORK_1.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorlees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorlees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Presss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Id_Dap = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Departments_Id_Dap",
                        column: x => x.Id_Dap,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Id_Facultiy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Faculties_Id_Facultiy",
                        column: x => x.Id_Facultiy,
                        principalTable: "Faculties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    YearPress = table.Column<int>(type: "int", nullable: false),
                    Id_Themes = table.Column<int>(type: "int", nullable: false),
                    Id_Catagory = table.Column<int>(type: "int", nullable: false),
                    Id_Authors = table.Column<int>(type: "int", nullable: false),
                    Id_Press = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    PressId = table.Column<int>(type: "int", nullable: true),
                    ThemeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_Authors_Id_Authors",
                        column: x => x.Id_Authors,
                        principalTable: "Authors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_Categorlees_Id_Catagory",
                        column: x => x.Id_Catagory,
                        principalTable: "Categorlees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_Presss_Id_Press",
                        column: x => x.Id_Press,
                        principalTable: "Presss",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_Presss_PressId",
                        column: x => x.PressId,
                        principalTable: "Presss",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_Themes_Id_Themes",
                        column: x => x.Id_Themes,
                        principalTable: "Themes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Id_Group = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Term = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Teacher = table.Column<int>(type: "int", nullable: false),
                    TeacherId1 = table.Column<int>(type: "int", nullable: false),
                    Id_Book = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Id_Lib = table.Column<int>(type: "int", nullable: false),
                    LibId = table.Column<int>(type: "int", nullable: false),
                    DateOut = table.Column<DateTime>(type: "Date", nullable: false),
                    DateIn = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_Cards_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Cards_Books_Id_Book",
                        column: x => x.Id_Book,
                        principalTable: "Books",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_T_Cards_Libs_Id_Lib",
                        column: x => x.Id_Lib,
                        principalTable: "Libs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_T_Cards_Libs_LibId",
                        column: x => x.LibId,
                        principalTable: "Libs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Cards_Teachers_Id_Teacher",
                        column: x => x.Id_Teacher,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_T_Cards_Teachers_TeacherId1",
                        column: x => x.TeacherId1,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "S_Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Student = table.Column<int>(type: "int", nullable: false),
                    StudentId1 = table.Column<int>(type: "int", nullable: false),
                    Id_Book = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Id_Lib = table.Column<int>(type: "int", nullable: false),
                    LibId = table.Column<int>(type: "int", nullable: false),
                    DateOut = table.Column<DateTime>(type: "Date", nullable: false),
                    DateIn = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_S_Cards_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_S_Cards_Books_Id_Book",
                        column: x => x.Id_Book,
                        principalTable: "Books",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_S_Cards_Libs_Id_Lib",
                        column: x => x.Id_Lib,
                        principalTable: "Libs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_S_Cards_Libs_LibId",
                        column: x => x.LibId,
                        principalTable: "Libs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_S_Cards_Students_Id_Student",
                        column: x => x.Id_Student,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_S_Cards_Students_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Authors",
                table: "Books",
                column: "Id_Authors");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Catagory",
                table: "Books",
                column: "Id_Catagory");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Press",
                table: "Books",
                column: "Id_Press");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Themes",
                table: "Books",
                column: "Id_Themes");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Name",
                table: "Books",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_PressId",
                table: "Books",
                column: "PressId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_ThemeId",
                table: "Books",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_Id_Facultiy",
                table: "Groups",
                column: "Id_Facultiy");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_BookId",
                table: "S_Cards",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_Id_Book",
                table: "S_Cards",
                column: "Id_Book");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_Id_Lib",
                table: "S_Cards",
                column: "Id_Lib");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_Id_Student",
                table: "S_Cards",
                column: "Id_Student");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_LibId",
                table: "S_Cards",
                column: "LibId");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_StudentId1",
                table: "S_Cards",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_BookId",
                table: "T_Cards",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_Id_Book",
                table: "T_Cards",
                column: "Id_Book");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_Id_Lib",
                table: "T_Cards",
                column: "Id_Lib");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_Id_Teacher",
                table: "T_Cards",
                column: "Id_Teacher");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_LibId",
                table: "T_Cards",
                column: "LibId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_TeacherId1",
                table: "T_Cards",
                column: "TeacherId1");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_Id_Dap",
                table: "Teachers",
                column: "Id_Dap");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "S_Cards");

            migrationBuilder.DropTable(
                name: "T_Cards");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Libs");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categorlees");

            migrationBuilder.DropTable(
                name: "Presss");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
