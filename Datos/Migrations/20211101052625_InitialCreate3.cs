using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "identifiacionPaciente",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "identifiacionPsicologo",
                table: "evaluaciones");

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha",
                table: "evaluaciones",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "identificacionPaciente",
                table: "evaluaciones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "identificacionPsicologo",
                table: "evaluaciones",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fecha",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "identificacionPaciente",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "identificacionPsicologo",
                table: "evaluaciones");

            migrationBuilder.AddColumn<string>(
                name: "identifiacionPaciente",
                table: "evaluaciones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "identifiacionPsicologo",
                table: "evaluaciones",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
