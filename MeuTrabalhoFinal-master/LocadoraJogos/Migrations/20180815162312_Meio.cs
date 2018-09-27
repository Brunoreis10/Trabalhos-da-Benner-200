using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraJogos.Migrations
{
    public partial class Meio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DataDeLancamento",
                table: "Jogos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Desenvolvedor",
                table: "Jogos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Jogos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    DataDeNascimento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropColumn(
                name: "DataDeLancamento",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "Desenvolvedor",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Jogos");
        }
    }
}
