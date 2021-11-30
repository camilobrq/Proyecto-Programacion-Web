using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_citas_Persona_pacienteidentificacion",
                table: "citas");

            migrationBuilder.DropForeignKey(
                name: "FK_citas_Persona_psicologoidentificacion",
                table: "citas");

            migrationBuilder.DropForeignKey(
                name: "FK_diagnosticos_Persona_psicologoidentificacion",
                table: "diagnosticos");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_agendas_agendaPsicologoidAgenda",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_usuarios_usuarioidUsuario",
                table: "Persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persona",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Eps",
                table: "Persona");

            migrationBuilder.RenameTable(
                name: "Persona",
                newName: "psicologos");

            migrationBuilder.RenameIndex(
                name: "IX_Persona_usuarioidUsuario",
                table: "psicologos",
                newName: "IX_psicologos_usuarioidUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Persona_agendaPsicologoidAgenda",
                table: "psicologos",
                newName: "IX_psicologos_agendaPsicologoidAgenda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_psicologos",
                table: "psicologos",
                column: "identificacion");

            migrationBuilder.CreateTable(
                name: "pacientes",
                columns: table => new
                {
                    identificacion = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Eps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usuarioidUsuario = table.Column<int>(type: "int", nullable: true),
                    tipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacientes", x => x.identificacion);
                    table.ForeignKey(
                        name: "FK_pacientes_usuarios_usuarioidUsuario",
                        column: x => x.usuarioidUsuario,
                        principalTable: "usuarios",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pacientes_usuarioidUsuario",
                table: "pacientes",
                column: "usuarioidUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_citas_pacientes_pacienteidentificacion",
                table: "citas",
                column: "pacienteidentificacion",
                principalTable: "pacientes",
                principalColumn: "identificacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_citas_psicologos_psicologoidentificacion",
                table: "citas",
                column: "psicologoidentificacion",
                principalTable: "psicologos",
                principalColumn: "identificacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_diagnosticos_psicologos_psicologoidentificacion",
                table: "diagnosticos",
                column: "psicologoidentificacion",
                principalTable: "psicologos",
                principalColumn: "identificacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_psicologos_agendas_agendaPsicologoidAgenda",
                table: "psicologos",
                column: "agendaPsicologoidAgenda",
                principalTable: "agendas",
                principalColumn: "idAgenda",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_psicologos_usuarios_usuarioidUsuario",
                table: "psicologos",
                column: "usuarioidUsuario",
                principalTable: "usuarios",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_citas_pacientes_pacienteidentificacion",
                table: "citas");

            migrationBuilder.DropForeignKey(
                name: "FK_citas_psicologos_psicologoidentificacion",
                table: "citas");

            migrationBuilder.DropForeignKey(
                name: "FK_diagnosticos_psicologos_psicologoidentificacion",
                table: "diagnosticos");

            migrationBuilder.DropForeignKey(
                name: "FK_psicologos_agendas_agendaPsicologoidAgenda",
                table: "psicologos");

            migrationBuilder.DropForeignKey(
                name: "FK_psicologos_usuarios_usuarioidUsuario",
                table: "psicologos");

            migrationBuilder.DropTable(
                name: "pacientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_psicologos",
                table: "psicologos");

            migrationBuilder.RenameTable(
                name: "psicologos",
                newName: "Persona");

            migrationBuilder.RenameIndex(
                name: "IX_psicologos_usuarioidUsuario",
                table: "Persona",
                newName: "IX_Persona_usuarioidUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_psicologos_agendaPsicologoidAgenda",
                table: "Persona",
                newName: "IX_Persona_agendaPsicologoidAgenda");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Eps",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persona",
                table: "Persona",
                column: "identificacion");

            migrationBuilder.AddForeignKey(
                name: "FK_citas_Persona_pacienteidentificacion",
                table: "citas",
                column: "pacienteidentificacion",
                principalTable: "Persona",
                principalColumn: "identificacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_citas_Persona_psicologoidentificacion",
                table: "citas",
                column: "psicologoidentificacion",
                principalTable: "Persona",
                principalColumn: "identificacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_diagnosticos_Persona_psicologoidentificacion",
                table: "diagnosticos",
                column: "psicologoidentificacion",
                principalTable: "Persona",
                principalColumn: "identificacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_agendas_agendaPsicologoidAgenda",
                table: "Persona",
                column: "agendaPsicologoidAgenda",
                principalTable: "agendas",
                principalColumn: "idAgenda",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_usuarios_usuarioidUsuario",
                table: "Persona",
                column: "usuarioidUsuario",
                principalTable: "usuarios",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
