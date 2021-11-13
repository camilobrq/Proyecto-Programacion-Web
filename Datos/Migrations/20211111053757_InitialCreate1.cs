using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "areaPsicologo",
                table: "psicologos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaNacimiento",
                table: "psicologos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "tipoDocumento",
                table: "psicologos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaNacimiento",
                table: "pacientes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "tipoDocumento",
                table: "pacientes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "areaPsicologo",
                table: "psicologos");

            migrationBuilder.DropColumn(
                name: "fechaNacimiento",
                table: "psicologos");

            migrationBuilder.DropColumn(
                name: "tipoDocumento",
                table: "psicologos");

            migrationBuilder.DropColumn(
                name: "fechaNacimiento",
                table: "pacientes");

            migrationBuilder.DropColumn(
                name: "tipoDocumento",
                table: "pacientes");
        }
    }
}
