using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "areaEspecializada",
                table: "agendas");

            migrationBuilder.DropColumn(
                name: "areaPsicologo",
                table: "agendas");

            migrationBuilder.DropColumn(
                name: "nombrePsicologo",
                table: "agendas");

            migrationBuilder.AddColumn<string>(
                name: "nombrePaciente",
                table: "citas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nombrePaciente",
                table: "citas");

            migrationBuilder.AddColumn<string>(
                name: "areaEspecializada",
                table: "agendas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "areaPsicologo",
                table: "agendas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombrePsicologo",
                table: "agendas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
