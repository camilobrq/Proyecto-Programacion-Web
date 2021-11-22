using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "analisis",
                table: "evaluaciones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "consulta",
                table: "evaluaciones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lugar",
                table: "evaluaciones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombrePaciente",
                table: "evaluaciones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombrePsicologo",
                table: "evaluaciones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observacion",
                table: "evaluaciones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ocupacion",
                table: "evaluaciones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pronostico",
                table: "evaluaciones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "prueba",
                table: "evaluaciones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "recomendacion",
                table: "evaluaciones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "estado",
                table: "citas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "analisis",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "consulta",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "lugar",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "nombrePaciente",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "nombrePsicologo",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "observacion",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "ocupacion",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "pronostico",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "prueba",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "recomendacion",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "estado",
                table: "citas");
        }
    }
}
