using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "evaluaciones",
                columns: table => new
                {
                    IdEvaluacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identifiacionPaciente = table.Column<string>(nullable: true),
                    identifiacionPsicologo = table.Column<string>(nullable: true),
                    pacienteidentificacion = table.Column<string>(nullable: true),
                    diagnostico = table.Column<string>(nullable: true),
                    Psicologoidentificacion = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_evaluaciones_Psicologoidentificacion",
                table: "evaluaciones",
                column: "Psicologoidentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_evaluaciones_pacienteidentificacion",
                table: "evaluaciones",
                column: "pacienteidentificacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "evaluaciones");

            migrationBuilder.DropTable(
                name: "psicologos");
        }
    }
}
