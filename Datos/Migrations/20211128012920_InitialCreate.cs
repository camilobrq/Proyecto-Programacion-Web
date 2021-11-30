using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "administradores",
                columns: table => new
                {
                    nombreUsuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    contraseña = table.Column<string>(type: "varchar(20)", nullable: true),
                    tipoUsuario = table.Column<string>(type: "varchar(20)", nullable: true),
                    estado = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradores", x => x.nombreUsuario);
                });

            migrationBuilder.CreateTable(
                name: "agendas",
                columns: table => new
                {
                    idAgenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agendas", x => x.idAgenda);
                });

            migrationBuilder.CreateTable(
                name: "pacientes",
                columns: table => new
                {
                    nombreUsuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Eps = table.Column<string>(type: "varchar(40)", nullable: true),
                    contraseña = table.Column<string>(type: "varchar(20)", nullable: true),
                    tipoUsuario = table.Column<string>(type: "varchar(20)", nullable: true),
                    estado = table.Column<string>(type: "varchar(10)", nullable: true),
                    identificacion = table.Column<string>(type: "varchar(30)", nullable: true),
                    tipoDocumento = table.Column<string>(type: "varchar(20)", nullable: true),
                    nombre = table.Column<string>(type: "varchar(30)", nullable: true),
                    apellido = table.Column<string>(type: "varchar(30)", nullable: true),
                    sexo = table.Column<string>(type: "varchar(10)", nullable: true),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "varchar(20)", nullable: true),
                    correo = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacientes", x => x.nombreUsuario);
                });

            migrationBuilder.CreateTable(
                name: "disponibilidades",
                columns: table => new
                {
                    idDisponibilidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    AgendaidAgenda = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disponibilidades", x => x.idDisponibilidad);
                    table.ForeignKey(
                        name: "FK_disponibilidades_agendas_AgendaidAgenda",
                        column: x => x.AgendaidAgenda,
                        principalTable: "agendas",
                        principalColumn: "idAgenda",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "psicologos",
                columns: table => new
                {
                    nombreUsuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UniversidadEgreso = table.Column<string>(type: "varchar(40)", nullable: true),
                    fechaFinalizacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    areaEspecializada = table.Column<string>(type: "varchar(40)", nullable: true),
                    areaPsicologo = table.Column<string>(type: "varchar(40)", nullable: true),
                    mesesExperiencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    agendaPsicologoidAgenda = table.Column<int>(type: "int", nullable: true),
                    contraseña = table.Column<string>(type: "varchar(20)", nullable: true),
                    tipoUsuario = table.Column<string>(type: "varchar(20)", nullable: true),
                    estado = table.Column<string>(type: "varchar(10)", nullable: true),
                    identificacion = table.Column<string>(type: "varchar(30)", nullable: true),
                    tipoDocumento = table.Column<string>(type: "varchar(20)", nullable: true),
                    nombre = table.Column<string>(type: "varchar(30)", nullable: true),
                    apellido = table.Column<string>(type: "varchar(30)", nullable: true),
                    sexo = table.Column<string>(type: "varchar(10)", nullable: true),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "varchar(20)", nullable: true),
                    correo = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_psicologos", x => x.nombreUsuario);
                    table.ForeignKey(
                        name: "FK_psicologos_agendas_agendaPsicologoidAgenda",
                        column: x => x.agendaPsicologoidAgenda,
                        principalTable: "agendas",
                        principalColumn: "idAgenda",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "diagnosticos",
                columns: table => new
                {
                    idDiagnostico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    psicologonombreUsuario = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diagnosticos", x => x.idDiagnostico);
                    table.ForeignKey(
                        name: "FK_diagnosticos_psicologos_psicologonombreUsuario",
                        column: x => x.psicologonombreUsuario,
                        principalTable: "psicologos",
                        principalColumn: "nombreUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "citas",
                columns: table => new
                {
                    idCita = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pacientenombreUsuario = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    psicologonombreUsuario = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    diagnosticoidDiagnostico = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citas", x => x.idCita);
                    table.ForeignKey(
                        name: "FK_citas_diagnosticos_diagnosticoidDiagnostico",
                        column: x => x.diagnosticoidDiagnostico,
                        principalTable: "diagnosticos",
                        principalColumn: "idDiagnostico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_citas_pacientes_pacientenombreUsuario",
                        column: x => x.pacientenombreUsuario,
                        principalTable: "pacientes",
                        principalColumn: "nombreUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_citas_psicologos_psicologonombreUsuario",
                        column: x => x.psicologonombreUsuario,
                        principalTable: "psicologos",
                        principalColumn: "nombreUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tratamientos",
                columns: table => new
                {
                    idTratamiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreTratamiento = table.Column<string>(type: "varchar(30)", nullable: true),
                    descripcionTratamiento = table.Column<string>(type: "varchar(500)", nullable: true),
                    DiagnosticoidDiagnostico = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tratamientos", x => x.idTratamiento);
                    table.ForeignKey(
                        name: "FK_tratamientos_diagnosticos_DiagnosticoidDiagnostico",
                        column: x => x.DiagnosticoidDiagnostico,
                        principalTable: "diagnosticos",
                        principalColumn: "idDiagnostico",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_citas_diagnosticoidDiagnostico",
                table: "citas",
                column: "diagnosticoidDiagnostico");

            migrationBuilder.CreateIndex(
                name: "IX_citas_pacientenombreUsuario",
                table: "citas",
                column: "pacientenombreUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_citas_psicologonombreUsuario",
                table: "citas",
                column: "psicologonombreUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_diagnosticos_psicologonombreUsuario",
                table: "diagnosticos",
                column: "psicologonombreUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_disponibilidades_AgendaidAgenda",
                table: "disponibilidades",
                column: "AgendaidAgenda");

            migrationBuilder.CreateIndex(
                name: "IX_psicologos_agendaPsicologoidAgenda",
                table: "psicologos",
                column: "agendaPsicologoidAgenda");

            migrationBuilder.CreateIndex(
                name: "IX_tratamientos_DiagnosticoidDiagnostico",
                table: "tratamientos",
                column: "DiagnosticoidDiagnostico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administradores");

            migrationBuilder.DropTable(
                name: "citas");

            migrationBuilder.DropTable(
                name: "disponibilidades");

            migrationBuilder.DropTable(
                name: "tratamientos");

            migrationBuilder.DropTable(
                name: "pacientes");

            migrationBuilder.DropTable(
                name: "diagnosticos");

            migrationBuilder.DropTable(
                name: "psicologos");

            migrationBuilder.DropTable(
                name: "agendas");
        }
    }
}
