using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_psicologos_usuarios_UsuarioidUsuario",
                table: "psicologos");

            migrationBuilder.RenameColumn(
                name: "UsuarioidUsuario",
                table: "psicologos",
                newName: "usuarioidUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_psicologos_UsuarioidUsuario",
                table: "psicologos",
                newName: "IX_psicologos_usuarioidUsuario");

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
                name: "FK_psicologos_usuarios_usuarioidUsuario",
                table: "psicologos");

            migrationBuilder.RenameColumn(
                name: "usuarioidUsuario",
                table: "psicologos",
                newName: "UsuarioidUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_psicologos_usuarioidUsuario",
                table: "psicologos",
                newName: "IX_psicologos_UsuarioidUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_psicologos_usuarios_UsuarioidUsuario",
                table: "psicologos",
                column: "UsuarioidUsuario",
                principalTable: "usuarios",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
