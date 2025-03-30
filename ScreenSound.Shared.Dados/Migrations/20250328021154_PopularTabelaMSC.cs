using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabelaMSC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Hear Me Now", 2016 }); 

            migrationBuilder.InsertData("Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Downtown", 2017 }); 

            migrationBuilder.InsertData("Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Oceano", 1989 }); 

            migrationBuilder.InsertData("Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Meteoro", 2009 }); 

            migrationBuilder.InsertData("Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Infiel", 2016 }); 

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Musicas");
        }
    }
}
