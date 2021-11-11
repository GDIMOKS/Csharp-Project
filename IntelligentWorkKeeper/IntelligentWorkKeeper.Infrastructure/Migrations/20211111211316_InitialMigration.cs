using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IntelligentWorkKeeper.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CollectionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartPage = table.Column<int>(type: "int", nullable: false),
                    EndPage = table.Column<int>(type: "int", nullable: false),
                    MagazineNumber = table.Column<int>(type: "int", nullable: false),
                    Part = table.Column<int>(type: "int", nullable: false),
                    ArticleType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Edition = table.Column<int>(type: "int", nullable: false),
                    EditionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntelligentWorks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GRNTI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntelligentWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UDK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationCertificates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RightHolder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationCertificates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatronymicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortPatronymicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberInList = table.Column<int>(type: "int", nullable: false),
                    IntelligentWorkId = table.Column<int>(type: "int", nullable: false),
                    IntelligentWorkId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_IntelligentWorks_IntelligentWorkId1",
                        column: x => x.IntelligentWorkId1,
                        principalTable: "IntelligentWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Indexations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntelligentWorkId = table.Column<int>(type: "int", nullable: false),
                    IntelligentWorkId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indexations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Indexations_IntelligentWorks_IntelligentWorkId1",
                        column: x => x.IntelligentWorkId1,
                        principalTable: "IntelligentWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KeyWords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Word = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntelligentWorkId = table.Column<int>(type: "int", nullable: false),
                    IntelligentWorkId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyWords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeyWords_IntelligentWorks_IntelligentWorkId1",
                        column: x => x.IntelligentWorkId1,
                        principalTable: "IntelligentWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_IntelligentWorkId1",
                table: "Authors",
                column: "IntelligentWorkId1");

            migrationBuilder.CreateIndex(
                name: "IX_Indexations_IntelligentWorkId1",
                table: "Indexations",
                column: "IntelligentWorkId1");

            migrationBuilder.CreateIndex(
                name: "IX_KeyWords_IntelligentWorkId1",
                table: "KeyWords",
                column: "IntelligentWorkId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Indexations");

            migrationBuilder.DropTable(
                name: "KeyWords");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.DropTable(
                name: "RegistrationCertificates");

            migrationBuilder.DropTable(
                name: "IntelligentWorks");
        }
    }
}
