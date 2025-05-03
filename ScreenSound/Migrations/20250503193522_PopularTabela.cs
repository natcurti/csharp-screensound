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
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] {"Bon Jovi", "Bon Jovi é uma banda americana de rock, formada em 1983, em Sayreville, Nova Jersey. A formação atual da banda consiste no cantor Jon Bon Jovi, no tecladista David Bryan, no baterista Tico Torres, no guitarrista Phil X e no baixista Hugh McDonald.", "https://upload.wikimedia.org/wikipedia/commons/4/49/Jon_Bon_Jovi_at_the_2009_Tribeca_Film_Festival_3.jpg" });
            
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] { "Scorpions", "Scorpions é uma banda Alemã de rock, originária de Hanôver, fundada em 1965 por Rudolf Schenker, sendo a primeira banda de hard rock formada no país germânico. No início eram chamadas de Nameless, depois passou para The Scorpions até o final de 1969, depois foram chamados simplesmente de Scorpions.", "https://upload.wikimedia.org/wikipedia/commons/d/de/Scorpions_in_Melbourne%2C_Australia_17.10.2016.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
