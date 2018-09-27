using Microsoft.EntityFrameworkCore.Migrations;

namespace LocadoraJogos.Migrations
{
    public partial class UsuarioAdm2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Adminstrador",
                table: "Usuarios",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adminstrador",
                table: "Usuarios");
        }
    }
}
