using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_citas_pacientes_pacientenombreUsuario",
                table: "citas");

            migrationBuilder.DropForeignKey(
                name: "FK_citas_psicologos_psicologonombreUsuario",
                table: "citas");

            migrationBuilder.DropForeignKey(
                name: "FK_diagnosticos_psicologos_psicologonombreUsuario",
                table: "diagnosticos");

            migrationBuilder.DropForeignKey(
                name: "FK_psicologos_agendas_agendaPsicologoidAgenda",
                table: "psicologos");

            migrationBuilder.DropTable(
                name: "pacientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_psicologos",
                table: "psicologos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_administradores",
                table: "administradores");

            migrationBuilder.DropColumn(
                name: "nombreUsuario",
                table: "psicologos");

            migrationBuilder.DropColumn(
                name: "contraseña",
                table: "psicologos");

            migrationBuilder.DropColumn(
                name: "correo",
                table: "psicologos");

            migrationBuilder.DropColumn(
                name: "estado",
                table: "psicologos");

            migrationBuilder.DropColumn(
                name: "telefono",
                table: "psicologos");

            migrationBuilder.RenameTable(
                name: "psicologos",
                newName: "Persona");

            migrationBuilder.RenameTable(
                name: "administradores",
                newName: "usuarios");

            migrationBuilder.RenameColumn(
                name: "psicologonombreUsuario",
                table: "diagnosticos",
                newName: "psicologoidentificacion");

            migrationBuilder.RenameIndex(
                name: "IX_diagnosticos_psicologonombreUsuario",
                table: "diagnosticos",
                newName: "IX_diagnosticos_psicologoidentificacion");

            migrationBuilder.RenameColumn(
                name: "psicologonombreUsuario",
                table: "citas",
                newName: "psicologoidentificacion");

            migrationBuilder.RenameColumn(
                name: "pacientenombreUsuario",
                table: "citas",
                newName: "pacienteidentificacion");

            migrationBuilder.RenameIndex(
                name: "IX_citas_psicologonombreUsuario",
                table: "citas",
                newName: "IX_citas_psicologoidentificacion");

            migrationBuilder.RenameIndex(
                name: "IX_citas_pacientenombreUsuario",
                table: "citas",
                newName: "IX_citas_pacienteidentificacion");

            migrationBuilder.RenameColumn(
                name: "tipoUsuario",
                table: "Persona",
                newName: "Eps");

            migrationBuilder.RenameIndex(
                name: "IX_psicologos_agendaPsicologoidAgenda",
                table: "Persona",
                newName: "IX_Persona_agendaPsicologoidAgenda");

            migrationBuilder.RenameColumn(
                name: "contraseña",
                table: "usuarios",
                newName: "telefono");

            migrationBuilder.AlterColumn<string>(
                name: "identificacion",
                table: "Persona",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "usuarioidUsuario",
                table: "Persona",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombreUsuario",
                table: "usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "idUsuario",
                table: "usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "contrasena",
                table: "usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "correo",
                table: "usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persona",
                table: "Persona",
                column: "identificacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios",
                column: "idUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_usuarioidUsuario",
                table: "Persona",
                column: "usuarioidUsuario");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "PK_usuarios",
                table: "usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persona",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_usuarioidUsuario",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "idUsuario",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "contrasena",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "correo",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "usuarioidUsuario",
                table: "Persona");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "administradores");

            migrationBuilder.RenameTable(
                name: "Persona",
                newName: "psicologos");

            migrationBuilder.RenameColumn(
                name: "psicologoidentificacion",
                table: "diagnosticos",
                newName: "psicologonombreUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_diagnosticos_psicologoidentificacion",
                table: "diagnosticos",
                newName: "IX_diagnosticos_psicologonombreUsuario");

            migrationBuilder.RenameColumn(
                name: "psicologoidentificacion",
                table: "citas",
                newName: "psicologonombreUsuario");

            migrationBuilder.RenameColumn(
                name: "pacienteidentificacion",
                table: "citas",
                newName: "pacientenombreUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_citas_psicologoidentificacion",
                table: "citas",
                newName: "IX_citas_psicologonombreUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_citas_pacienteidentificacion",
                table: "citas",
                newName: "IX_citas_pacientenombreUsuario");

            migrationBuilder.RenameColumn(
                name: "telefono",
                table: "administradores",
                newName: "contraseña");

            migrationBuilder.RenameColumn(
                name: "Eps",
                table: "psicologos",
                newName: "tipoUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Persona_agendaPsicologoidAgenda",
                table: "psicologos",
                newName: "IX_psicologos_agendaPsicologoidAgenda");

            migrationBuilder.AlterColumn<string>(
                name: "nombreUsuario",
                table: "administradores",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "identificacion",
                table: "psicologos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "nombreUsuario",
                table: "psicologos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "contraseña",
                table: "psicologos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "correo",
                table: "psicologos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "estado",
                table: "psicologos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telefono",
                table: "psicologos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_administradores",
                table: "administradores",
                column: "nombreUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_psicologos",
                table: "psicologos",
                column: "nombreUsuario");

            migrationBuilder.CreateTable(
                name: "pacientes",
                columns: table => new
                {
                    nombreUsuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Eps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacientes", x => x.nombreUsuario);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_citas_pacientes_pacientenombreUsuario",
                table: "citas",
                column: "pacientenombreUsuario",
                principalTable: "pacientes",
                principalColumn: "nombreUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_citas_psicologos_psicologonombreUsuario",
                table: "citas",
                column: "psicologonombreUsuario",
                principalTable: "psicologos",
                principalColumn: "nombreUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_diagnosticos_psicologos_psicologonombreUsuario",
                table: "diagnosticos",
                column: "psicologonombreUsuario",
                principalTable: "psicologos",
                principalColumn: "nombreUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_psicologos_agendas_agendaPsicologoidAgenda",
                table: "psicologos",
                column: "agendaPsicologoidAgenda",
                principalTable: "agendas",
                principalColumn: "idAgenda",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
