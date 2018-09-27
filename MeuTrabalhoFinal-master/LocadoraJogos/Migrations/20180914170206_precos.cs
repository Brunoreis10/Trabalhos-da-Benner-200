using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraJogos.Migrations
{
    public partial class precos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogos");

            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Produtos",
                nullable: false,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Preco",
                table: "Produtos",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.CreateTable(
                name: "Jogos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataDeLancamento = table.Column<string>(nullable: true),
                    Desenvolvedor = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Titulo = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogos", x => x.Id);
                });
        }
    }
}
