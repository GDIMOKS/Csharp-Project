using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IntelligentWorkKeeper.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    NumberInList = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UDK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageCount = table.Column<int>(type: "int", nullable: true),
                    CollectionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartPage = table.Column<int>(type: "int", nullable: true),
                    EndPage = table.Column<int>(type: "int", nullable: true),
                    MagazineNumber = table.Column<int>(type: "int", nullable: true),
                    Part = table.Column<int>(type: "int", nullable: true),
                    ArticleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edition = table.Column<int>(type: "int", nullable: true),
                    EditionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RightHolder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntelligentWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorIntelligentWork",
                columns: table => new
                {
                    AuthorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IntelligentWorksId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorIntelligentWork", x => new { x.AuthorsId, x.IntelligentWorksId });
                    table.ForeignKey(
                        name: "FK_AuthorIntelligentWork_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorIntelligentWork_IntelligentWorks_IntelligentWorksId",
                        column: x => x.IntelligentWorksId,
                        principalTable: "IntelligentWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_AuthorIntelligentWork_IntelligentWorksId",
                table: "AuthorIntelligentWork",
                column: "IntelligentWorksId");

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
                name: "AuthorIntelligentWork");

            migrationBuilder.DropTable(
                name: "Indexations");

            migrationBuilder.DropTable(
                name: "KeyWords");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "IntelligentWorks");
        }
    }
}
