using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tratamientos",
                columns: table => new
                {
                    IdTratamiento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identificacionPaciente = table.Column<string>(nullable: true),
                    pacienteidentificacion = table.Column<string>(nullable: true),
                    identificacionPsicologo = table.Column<string>(nullable: true),
                    Psicologoidentificacion = table.Column<string>(nullable: true),
                    fecha = table.Column<DateTime>(nullable: false),
                    medicacion = table.Column<string>(nullable: true),
                    tratamientoPaso = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tratamientos", x => x.IdTratamiento);
                    table.ForeignKey(
                        name: "FK_tratamientos_psicologos_Psicologoidentificacion",
                        column: x => x.Psicologoidentificacion,
                        principalTable: "psicologos",
                        principalColumn: "identificacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tratamientos_pacientes_pacienteidentificacion",
                        column: x => x.pacienteidentificacion,
                        principalTable: "pacientes",
                        principalColumn: "identificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tratamientos_Psicologoidentificacion",
                table: "tratamientos",
                column: "Psicologoidentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_tratamientos_pacienteidentificacion",
                table: "tratamientos",
                column: "pacienteidentificacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tratamientos");
        }
    }
}
