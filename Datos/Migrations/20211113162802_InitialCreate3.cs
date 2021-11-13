using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "agendas",
                columns: table => new
                {
                    idAgenda = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPsicologo = table.Column<string>(nullable: true),
                    psicologoidentificacion = table.Column<string>(nullable: true),
                    nombrePsicologo = table.Column<string>(nullable: true),
                    areaEspecializada = table.Column<string>(nullable: true),
                    areaPsicologo = table.Column<string>(nullable: true),
                    fechaDeseada = table.Column<DateTime>(nullable: false),
                    horaCita = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agendas", x => x.idAgenda);
                    table.ForeignKey(
                        name: "FK_agendas_psicologos_psicologoidentificacion",
                        column: x => x.psicologoidentificacion,
                        principalTable: "psicologos",
                        principalColumn: "identificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_agendas_psicologoidentificacion",
                table: "agendas",
                column: "psicologoidentificacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "agendas");
        }
    }
}
