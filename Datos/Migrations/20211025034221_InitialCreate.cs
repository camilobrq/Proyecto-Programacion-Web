using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pacientes",
                columns: table => new
                {
                    identificacion = table.Column<string>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    sexo = table.Column<string>(nullable: true),
                    edad = table.Column<int>(nullable: false),
                    telefono = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    Eps = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacientes", x => x.identificacion);
                });

            migrationBuilder.CreateTable(
                name: "citas",
                columns: table => new
                {
                    idCita = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPaciente = table.Column<string>(nullable: true),
                    pacienteidentificacion = table.Column<string>(nullable: true),
                    tiposSolicitud = table.Column<string>(nullable: true),
                    fechaDeseada = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citas", x => x.idCita);
                    table.ForeignKey(
                        name: "FK_citas_pacientes_pacienteidentificacion",
                        column: x => x.pacienteidentificacion,
                        principalTable: "pacientes",
                        principalColumn: "identificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_citas_pacienteidentificacion",
                table: "citas",
                column: "pacienteidentificacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "citas");

            migrationBuilder.DropTable(
                name: "pacientes");
        }
    }
}
