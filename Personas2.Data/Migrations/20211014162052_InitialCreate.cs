using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Personas2.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    TipoDocumento = table.Column<int>(type: "int", nullable: false),
                    NoDocumento = table.Column<string>(type: "varchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoContacto = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Direccion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioRegistro = table.Column<int>(type: "int", nullable: false),
                    UsuarioModifica = table.Column<int>(type: "int", nullable: false),
                    UsuarioElimina = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEliminado = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona2", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona2");
        }
    }
}
