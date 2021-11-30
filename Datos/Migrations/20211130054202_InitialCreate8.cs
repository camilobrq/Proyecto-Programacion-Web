using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_citas_diagnosticos_diagnosticoidDiagnostico",
                table: "citas");

            migrationBuilder.DropForeignKey(
                name: "FK_citas_psicologos_psicologoidentificacion",
                table: "citas");

            migrationBuilder.DropForeignKey(
                name: "FK_diagnosticos_psicologos_psicologoidentificacion",
                table: "diagnosticos");

            migrationBuilder.DropForeignKey(
                name: "FK_disponibilidades_agendas_AgendaidAgenda",
                table: "disponibilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_psicologos_agendas_agendaPsicologoidAgenda",
                table: "psicologos");

            migrationBuilder.DropForeignKey(
                name: "FK_psicologos_usuarios_usuarioidUsuario",
                table: "psicologos");

            migrationBuilder.DropForeignKey(
                name: "FK_tratamientos_diagnosticos_DiagnosticoidDiagnostico",
                table: "tratamientos");

            migrationBuilder.DropIndex(
                name: "IX_tratamientos_DiagnosticoidDiagnostico",
                table: "tratamientos");

            migrationBuilder.DropIndex(
                name: "IX_psicologos_agendaPsicologoidAgenda",
                table: "psicologos");

            migrationBuilder.DropIndex(
                name: "IX_disponibilidades_AgendaidAgenda",
                table: "disponibilidades");

            migrationBuilder.DropIndex(
                name: "IX_citas_diagnosticoidDiagnostico",
                table: "citas");

            migrationBuilder.DropIndex(
                name: "IX_citas_psicologoidentificacion",
                table: "citas");

            migrationBuilder.DropColumn(
                name: "DiagnosticoidDiagnostico",
                table: "tratamientos");

            migrationBuilder.DropColumn(
                name: "descripcionTratamiento",
                table: "tratamientos");

            migrationBuilder.DropColumn(
                name: "nombreTratamiento",
                table: "tratamientos");

            migrationBuilder.DropColumn(
                name: "agendaPsicologoidAgenda",
                table: "psicologos");

            migrationBuilder.DropColumn(
                name: "areaPsicologo",
                table: "psicologos");

            migrationBuilder.DropColumn(
                name: "AgendaidAgenda",
                table: "disponibilidades");

            migrationBuilder.DropColumn(
                name: "diagnosticoidDiagnostico",
                table: "citas");

            migrationBuilder.DropColumn(
                name: "psicologoidentificacion",
                table: "citas");

            migrationBuilder.RenameColumn(
                name: "idTratamiento",
                table: "tratamientos",
                newName: "IdTratamiento");

            migrationBuilder.RenameColumn(
                name: "usuarioidUsuario",
                table: "psicologos",
                newName: "UsuarioidUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_psicologos_usuarioidUsuario",
                table: "psicologos",
                newName: "IX_psicologos_UsuarioidUsuario");

            migrationBuilder.RenameColumn(
                name: "psicologoidentificacion",
                table: "diagnosticos",
                newName: "Psicologoidentificacion");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "diagnosticos",
                newName: "recomendacion");

            migrationBuilder.RenameColumn(
                name: "idDiagnostico",
                table: "diagnosticos",
                newName: "IdEvaluacion");

            migrationBuilder.RenameIndex(
                name: "IX_diagnosticos_psicologoidentificacion",
                table: "diagnosticos",
                newName: "IX_diagnosticos_Psicologoidentificacion");

            migrationBuilder.RenameColumn(
                name: "hora",
                table: "citas",
                newName: "tiposSolicitud");

            migrationBuilder.RenameColumn(
                name: "fecha",
                table: "citas",
                newName: "nombrePaciente");

            migrationBuilder.AddColumn<string>(
                name: "Psicologoidentificacion",
                table: "tratamientos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "codigo_3",
                table: "tratamientos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "codigo_4",
                table: "tratamientos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descripcion_3",
                table: "tratamientos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descripcion_4",
                table: "tratamientos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha",
                table: "tratamientos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "identificacionPaciente",
                table: "tratamientos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "identificacionPsicologo",
                table: "tratamientos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "medicacion",
                table: "tratamientos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pacienteidentificacion",
                table: "tratamientos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tratamientoPaso",
                table: "tratamientos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "areaEspecializada",
                table: "psicologos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UniversidadEgreso",
                table: "psicologos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "edad",
                table: "psicologos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "edad",
                table: "pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "analisis",
                table: "diagnosticos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "consulta",
                table: "diagnosticos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "diagnostico",
                table: "diagnosticos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha",
                table: "diagnosticos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "identificacionPaciente",
                table: "diagnosticos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "identificacionPsicologo",
                table: "diagnosticos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lugar",
                table: "diagnosticos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombrePaciente",
                table: "diagnosticos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombrePsicologo",
                table: "diagnosticos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observacion",
                table: "diagnosticos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ocupacion",
                table: "diagnosticos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pacienteidentificacion",
                table: "diagnosticos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pronostico",
                table: "diagnosticos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "prueba",
                table: "diagnosticos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "estado",
                table: "citas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaDeseada",
                table: "citas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "horaCita",
                table: "citas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "idPaciente",
                table: "citas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "citas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "citaidCita",
                table: "agendas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaDeseada",
                table: "agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "horaCita",
                table: "agendas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idCita",
                table: "agendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "idPsicologo",
                table: "agendas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "psicologoidentificacion",
                table: "agendas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tratamientos_pacienteidentificacion",
                table: "tratamientos",
                column: "pacienteidentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_tratamientos_Psicologoidentificacion",
                table: "tratamientos",
                column: "Psicologoidentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_diagnosticos_pacienteidentificacion",
                table: "diagnosticos",
                column: "pacienteidentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_agendas_citaidCita",
                table: "agendas",
                column: "citaidCita");

            migrationBuilder.CreateIndex(
                name: "IX_agendas_psicologoidentificacion",
                table: "agendas",
                column: "psicologoidentificacion");

            migrationBuilder.AddForeignKey(
                name: "FK_agendas_citas_citaidCita",
                table: "agendas",
                column: "citaidCita",
                principalTable: "citas",
                principalColumn: "idCita",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_agendas_psicologos_psicologoidentificacion",
                table: "agendas",
                column: "psicologoidentificacion",
                principalTable: "psicologos",
                principalColumn: "identificacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_diagnosticos_pacientes_pacienteidentificacion",
                table: "diagnosticos",
                column: "pacienteidentificacion",
                principalTable: "pacientes",
                principalColumn: "identificacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_diagnosticos_psicologos_Psicologoidentificacion",
                table: "diagnosticos",
                column: "Psicologoidentificacion",
                principalTable: "psicologos",
                principalColumn: "identificacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_psicologos_usuarios_UsuarioidUsuario",
                table: "psicologos",
                column: "UsuarioidUsuario",
                principalTable: "usuarios",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tratamientos_pacientes_pacienteidentificacion",
                table: "tratamientos",
                column: "pacienteidentificacion",
                principalTable: "pacientes",
                principalColumn: "identificacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tratamientos_psicologos_Psicologoidentificacion",
                table: "tratamientos",
                column: "Psicologoidentificacion",
                principalTable: "psicologos",
                principalColumn: "identificacion",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_agendas_citas_citaidCita",
                table: "agendas");

            migrationBuilder.DropForeignKey(
                name: "FK_agendas_psicologos_psicologoidentificacion",
                table: "agendas");

            migrationBuilder.DropForeignKey(
                name: "FK_diagnosticos_pacientes_pacienteidentificacion",
                table: "diagnosticos");

            migrationBuilder.DropForeignKey(
                name: "FK_diagnosticos_psicologos_Psicologoidentificacion",
                table: "diagnosticos");

            migrationBuilder.DropForeignKey(
                name: "FK_psicologos_usuarios_UsuarioidUsuario",
                table: "psicologos");

            migrationBuilder.DropForeignKey(
                name: "FK_tratamientos_pacientes_pacienteidentificacion",
                table: "tratamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_tratamientos_psicologos_Psicologoidentificacion",
                table: "tratamientos");

            migrationBuilder.DropIndex(
                name: "IX_tratamientos_pacienteidentificacion",
                table: "tratamientos");

            migrationBuilder.DropIndex(
                name: "IX_tratamientos_Psicologoidentificacion",
                table: "tratamientos");

            migrationBuilder.DropIndex(
                name: "IX_diagnosticos_pacienteidentificacion",
                table: "diagnosticos");

            migrationBuilder.DropIndex(
                name: "IX_agendas_citaidCita",
                table: "agendas");

            migrationBuilder.DropIndex(
                name: "IX_agendas_psicologoidentificacion",
                table: "agendas");

            migrationBuilder.DropColumn(
                name: "Psicologoidentificacion",
                table: "tratamientos");

            migrationBuilder.DropColumn(
                name: "codigo_3",
                table: "tratamientos");

            migrationBuilder.DropColumn(
                name: "codigo_4",
                table: "tratamientos");

            migrationBuilder.DropColumn(
                name: "descripcion_3",
                table: "tratamientos");

            migrationBuilder.DropColumn(
                name: "descripcion_4",
                table: "tratamientos");

            migrationBuilder.DropColumn(
                name: "fecha",
                table: "tratamientos");

            migrationBuilder.DropColumn(
                name: "identificacionPaciente",
                table: "tratamientos");

            migrationBuilder.DropColumn(
                name: "identificacionPsicologo",
                table: "tratamientos");

            migrationBuilder.DropColumn(
                name: "medicacion",
                table: "tratamientos");

            migrationBuilder.DropColumn(
                name: "pacienteidentificacion",
                table: "tratamientos");

            migrationBuilder.DropColumn(
                name: "tratamientoPaso",
                table: "tratamientos");

            migrationBuilder.DropColumn(
                name: "edad",
                table: "psicologos");

            migrationBuilder.DropColumn(
                name: "edad",
                table: "pacientes");

            migrationBuilder.DropColumn(
                name: "analisis",
                table: "diagnosticos");

            migrationBuilder.DropColumn(
                name: "consulta",
                table: "diagnosticos");

            migrationBuilder.DropColumn(
                name: "diagnostico",
                table: "diagnosticos");

            migrationBuilder.DropColumn(
                name: "fecha",
                table: "diagnosticos");

            migrationBuilder.DropColumn(
                name: "identificacionPaciente",
                table: "diagnosticos");

            migrationBuilder.DropColumn(
                name: "identificacionPsicologo",
                table: "diagnosticos");

            migrationBuilder.DropColumn(
                name: "lugar",
                table: "diagnosticos");

            migrationBuilder.DropColumn(
                name: "nombrePaciente",
                table: "diagnosticos");

            migrationBuilder.DropColumn(
                name: "nombrePsicologo",
                table: "diagnosticos");

            migrationBuilder.DropColumn(
                name: "observacion",
                table: "diagnosticos");

            migrationBuilder.DropColumn(
                name: "ocupacion",
                table: "diagnosticos");

            migrationBuilder.DropColumn(
                name: "pacienteidentificacion",
                table: "diagnosticos");

            migrationBuilder.DropColumn(
                name: "pronostico",
                table: "diagnosticos");

            migrationBuilder.DropColumn(
                name: "prueba",
                table: "diagnosticos");

            migrationBuilder.DropColumn(
                name: "estado",
                table: "citas");

            migrationBuilder.DropColumn(
                name: "fechaDeseada",
                table: "citas");

            migrationBuilder.DropColumn(
                name: "horaCita",
                table: "citas");

            migrationBuilder.DropColumn(
                name: "idPaciente",
                table: "citas");

            migrationBuilder.DropColumn(
                name: "nombre",
                table: "citas");

            migrationBuilder.DropColumn(
                name: "citaidCita",
                table: "agendas");

            migrationBuilder.DropColumn(
                name: "fechaDeseada",
                table: "agendas");

            migrationBuilder.DropColumn(
                name: "horaCita",
                table: "agendas");

            migrationBuilder.DropColumn(
                name: "idCita",
                table: "agendas");

            migrationBuilder.DropColumn(
                name: "idPsicologo",
                table: "agendas");

            migrationBuilder.DropColumn(
                name: "psicologoidentificacion",
                table: "agendas");

            migrationBuilder.RenameColumn(
                name: "IdTratamiento",
                table: "tratamientos",
                newName: "idTratamiento");

            migrationBuilder.RenameColumn(
                name: "UsuarioidUsuario",
                table: "psicologos",
                newName: "usuarioidUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_psicologos_UsuarioidUsuario",
                table: "psicologos",
                newName: "IX_psicologos_usuarioidUsuario");

            migrationBuilder.RenameColumn(
                name: "Psicologoidentificacion",
                table: "diagnosticos",
                newName: "psicologoidentificacion");

            migrationBuilder.RenameColumn(
                name: "recomendacion",
                table: "diagnosticos",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "IdEvaluacion",
                table: "diagnosticos",
                newName: "idDiagnostico");

            migrationBuilder.RenameIndex(
                name: "IX_diagnosticos_Psicologoidentificacion",
                table: "diagnosticos",
                newName: "IX_diagnosticos_psicologoidentificacion");

            migrationBuilder.RenameColumn(
                name: "tiposSolicitud",
                table: "citas",
                newName: "hora");

            migrationBuilder.RenameColumn(
                name: "nombrePaciente",
                table: "citas",
                newName: "fecha");

            migrationBuilder.AddColumn<int>(
                name: "DiagnosticoidDiagnostico",
                table: "tratamientos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descripcionTratamiento",
                table: "tratamientos",
                type: "varchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombreTratamiento",
                table: "tratamientos",
                type: "varchar(30)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "areaEspecializada",
                table: "psicologos",
                type: "varchar(40)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UniversidadEgreso",
                table: "psicologos",
                type: "varchar(40)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "agendaPsicologoidAgenda",
                table: "psicologos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "areaPsicologo",
                table: "psicologos",
                type: "varchar(40)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgendaidAgenda",
                table: "disponibilidades",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "diagnosticoidDiagnostico",
                table: "citas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "psicologoidentificacion",
                table: "citas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tratamientos_DiagnosticoidDiagnostico",
                table: "tratamientos",
                column: "DiagnosticoidDiagnostico");

            migrationBuilder.CreateIndex(
                name: "IX_psicologos_agendaPsicologoidAgenda",
                table: "psicologos",
                column: "agendaPsicologoidAgenda");

            migrationBuilder.CreateIndex(
                name: "IX_disponibilidades_AgendaidAgenda",
                table: "disponibilidades",
                column: "AgendaidAgenda");

            migrationBuilder.CreateIndex(
                name: "IX_citas_diagnosticoidDiagnostico",
                table: "citas",
                column: "diagnosticoidDiagnostico");

            migrationBuilder.CreateIndex(
                name: "IX_citas_psicologoidentificacion",
                table: "citas",
                column: "psicologoidentificacion");

            migrationBuilder.AddForeignKey(
                name: "FK_citas_diagnosticos_diagnosticoidDiagnostico",
                table: "citas",
                column: "diagnosticoidDiagnostico",
                principalTable: "diagnosticos",
                principalColumn: "idDiagnostico",
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
                name: "FK_disponibilidades_agendas_AgendaidAgenda",
                table: "disponibilidades",
                column: "AgendaidAgenda",
                principalTable: "agendas",
                principalColumn: "idAgenda",
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

            migrationBuilder.AddForeignKey(
                name: "FK_tratamientos_diagnosticos_DiagnosticoidDiagnostico",
                table: "tratamientos",
                column: "DiagnosticoidDiagnostico",
                principalTable: "diagnosticos",
                principalColumn: "idDiagnostico",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
