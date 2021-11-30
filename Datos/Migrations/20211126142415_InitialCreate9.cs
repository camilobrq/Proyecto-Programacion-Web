using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "enfermedades",
                columns: table => new
                {
                    idEnfermedad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_3 = table.Column<string>(nullable: true),
                    Descripcion_3 = table.Column<string>(nullable: true),
                    Codigo_4 = table.Column<string>(nullable: true),
                    Descripcion_4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enfermedades", x => x.idEnfermedad);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "enfermedades");
        }
    }
}
