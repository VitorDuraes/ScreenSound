using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Alok", "Alok é um DJ e produtor musical brasileiro de música eletrônica.", "https://www.google.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Anitta", "Anitta é uma cantora, compositora e empresária brasileira.", "https://www.google.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Djavan", "Djavan é um cantor, compositor e violonista brasileiro.", "https://www.google.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Luan Santana", "Luan Santana é um cantor e compositor brasileiro de música sertaneja.", "https://www.google.com" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Marília Mendonça", "Marília Mendonça foi uma cantora e compositora brasileira de música sertaneja.", "https://www.google.com" });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
