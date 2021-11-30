using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "diagnosticos");

            migrationBuilder.AddColumn<int>(
                name: "evaluacionIdEvaluacion",
                table: "citas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tratamientoIdTratamiento",
                table: "citas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "enfermedades",
                columns: table => new
                {
                    idEnfermedad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion_4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enfermedades", x => x.idEnfermedad);
                });

            migrationBuilder.CreateTable(
                name: "evaluaciones",
                columns: table => new
                {
                    IdEvaluacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identificacionPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pacienteidentificacion = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    identificacionPsicologo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Psicologoidentificacion = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ocupacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    consulta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prueba = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    analisis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pronostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recomendacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evaluaciones", x => x.IdEvaluacion);
                    table.ForeignKey(
                        name: "FK_evaluaciones_pacientes_pacienteidentificacion",
                        column: x => x.pacienteidentificacion,
                        principalTable: "pacientes",
                        principalColumn: "identificacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_evaluaciones_psicologos_Psicologoidentificacion",
                        column: x => x.Psicologoidentificacion,
                        principalTable: "psicologos",
                        principalColumn: "identificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_citas_evaluacionIdEvaluacion",
                table: "citas",
                column: "evaluacionIdEvaluacion");

            migrationBuilder.CreateIndex(
                name: "IX_citas_tratamientoIdTratamiento",
                table: "citas",
                column: "tratamientoIdTratamiento");

            migrationBuilder.CreateIndex(
                name: "IX_evaluaciones_pacienteidentificacion",
                table: "evaluaciones",
                column: "pacienteidentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_evaluaciones_Psicologoidentificacion",
                table: "evaluaciones",
                column: "Psicologoidentificacion");

            migrationBuilder.AddForeignKey(
                name: "FK_citas_evaluaciones_evaluacionIdEvaluacion",
                table: "citas",
                column: "evaluacionIdEvaluacion",
                principalTable: "evaluaciones",
                principalColumn: "IdEvaluacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_citas_tratamientos_tratamientoIdTratamiento",
                table: "citas",
                column: "tratamientoIdTratamiento",
                principalTable: "tratamientos",
                principalColumn: "IdTratamiento",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_citas_evaluaciones_evaluacionIdEvaluacion",
                table: "citas");

            migrationBuilder.DropForeignKey(
                name: "FK_citas_tratamientos_tratamientoIdTratamiento",
                table: "citas");

            migrationBuilder.DropTable(
                name: "enfermedades");

            migrationBuilder.DropTable(
                name: "evaluaciones");

            migrationBuilder.DropIndex(
                name: "IX_citas_evaluacionIdEvaluacion",
                table: "citas");

            migrationBuilder.DropIndex(
                name: "IX_citas_tratamientoIdTratamiento",
                table: "citas");

            migrationBuilder.DropColumn(
                name: "evaluacionIdEvaluacion",
                table: "citas");

            migrationBuilder.DropColumn(
                name: "tratamientoIdTratamiento",
                table: "citas");

            migrationBuilder.CreateTable(
                name: "diagnosticos",
                columns: table => new
                {
                    IdEvaluacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Psicologoidentificacion = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    analisis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    consulta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    identificacionPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    identificacionPsicologo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lugar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombrePaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombrePsicologo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ocupacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pacienteidentificacion = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    pronostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prueba = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recomendacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diagnosticos", x => x.IdEvaluacion);
                    table.ForeignKey(
                        name: "FK_diagnosticos_pacientes_pacienteidentificacion",
                        column: x => x.pacienteidentificacion,
                        principalTable: "pacientes",
                        principalColumn: "identificacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_diagnosticos_psicologos_Psicologoidentificacion",
                        column: x => x.Psicologoidentificacion,
                        principalTable: "psicologos",
                        principalColumn: "identificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_diagnosticos_pacienteidentificacion",
                table: "diagnosticos",
                column: "pacienteidentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_diagnosticos_Psicologoidentificacion",
                table: "diagnosticos",
                column: "Psicologoidentificacion");
        }
    }
}
