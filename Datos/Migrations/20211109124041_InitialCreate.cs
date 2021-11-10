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
                name: "psicologos",
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
                    Universidad = table.Column<string>(nullable: true),
                    fechaFinalizacion = table.Column<string>(nullable: true),
                    areaEspecializada = table.Column<string>(nullable: true),
                    mesesExperiencia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_psicologos", x => x.identificacion);
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

            migrationBuilder.CreateTable(
                name: "evaluaciones",
                columns: table => new
                {
                    IdEvaluacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identificacionPaciente = table.Column<string>(nullable: true),
                    pacienteidentificacion = table.Column<string>(nullable: true),
                    identificacionPsicologo = table.Column<string>(nullable: true),
                    Psicologoidentificacion = table.Column<string>(nullable: true),
                    fecha = table.Column<DateTime>(nullable: false),
                    diagnostico = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evaluaciones", x => x.IdEvaluacion);
                    table.ForeignKey(
                        name: "FK_evaluaciones_psicologos_Psicologoidentificacion",
                        column: x => x.Psicologoidentificacion,
                        principalTable: "psicologos",
                        principalColumn: "identificacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_evaluaciones_pacientes_pacienteidentificacion",
                        column: x => x.pacienteidentificacion,
                        principalTable: "pacientes",
                        principalColumn: "identificacion",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_citas_pacienteidentificacion",
                table: "citas",
                column: "pacienteidentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_evaluaciones_Psicologoidentificacion",
                table: "evaluaciones",
                column: "Psicologoidentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_evaluaciones_pacienteidentificacion",
                table: "evaluaciones",
                column: "pacienteidentificacion");

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
                name: "citas");

            migrationBuilder.DropTable(
                name: "evaluaciones");

            migrationBuilder.DropTable(
                name: "tratamientos");

            migrationBuilder.DropTable(
                name: "psicologos");

            migrationBuilder.DropTable(
                name: "pacientes");
        }
    }
}
