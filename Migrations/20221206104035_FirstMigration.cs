using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharpboolfix.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContenutiVideo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durata = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: true),
                    NumeroEpisodi = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContenutiVideo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profili",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profili", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContenutoVideoGenere",
                columns: table => new
                {
                    ContenutiVideoId = table.Column<int>(type: "int", nullable: false),
                    GeneriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContenutoVideoGenere", x => new { x.ContenutiVideoId, x.GeneriId });
                    table.ForeignKey(
                        name: "FK_ContenutoVideoGenere_ContenutiVideo_ContenutiVideoId",
                        column: x => x.ContenutiVideoId,
                        principalTable: "ContenutiVideo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContenutoVideoGenere_Generi_GeneriId",
                        column: x => x.GeneriId,
                        principalTable: "Generi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContenutoVideoProfilo",
                columns: table => new
                {
                    ContenutiVideoId = table.Column<int>(type: "int", nullable: false),
                    ProfiliId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContenutoVideoProfilo", x => new { x.ContenutiVideoId, x.ProfiliId });
                    table.ForeignKey(
                        name: "FK_ContenutoVideoProfilo_ContenutiVideo_ContenutiVideoId",
                        column: x => x.ContenutiVideoId,
                        principalTable: "ContenutiVideo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContenutoVideoProfilo_Profili_ProfiliId",
                        column: x => x.ProfiliId,
                        principalTable: "Profili",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfiloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayLists_Profili_ProfiloId",
                        column: x => x.ProfiloId,
                        principalTable: "Profili",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContenutoVideoPlayList",
                columns: table => new
                {
                    ContenutiVideoId = table.Column<int>(type: "int", nullable: false),
                    PlayListsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContenutoVideoPlayList", x => new { x.ContenutiVideoId, x.PlayListsId });
                    table.ForeignKey(
                        name: "FK_ContenutoVideoPlayList_ContenutiVideo_ContenutiVideoId",
                        column: x => x.ContenutiVideoId,
                        principalTable: "ContenutiVideo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContenutoVideoPlayList_PlayLists_PlayListsId",
                        column: x => x.PlayListsId,
                        principalTable: "PlayLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContenutoVideoGenere_GeneriId",
                table: "ContenutoVideoGenere",
                column: "GeneriId");

            migrationBuilder.CreateIndex(
                name: "IX_ContenutoVideoPlayList_PlayListsId",
                table: "ContenutoVideoPlayList",
                column: "PlayListsId");

            migrationBuilder.CreateIndex(
                name: "IX_ContenutoVideoProfilo_ProfiliId",
                table: "ContenutoVideoProfilo",
                column: "ProfiliId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayLists_ProfiloId",
                table: "PlayLists",
                column: "ProfiloId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContenutoVideoGenere");

            migrationBuilder.DropTable(
                name: "ContenutoVideoPlayList");

            migrationBuilder.DropTable(
                name: "ContenutoVideoProfilo");

            migrationBuilder.DropTable(
                name: "Generi");

            migrationBuilder.DropTable(
                name: "PlayLists");

            migrationBuilder.DropTable(
                name: "ContenutiVideo");

            migrationBuilder.DropTable(
                name: "Profili");
        }
    }
}
