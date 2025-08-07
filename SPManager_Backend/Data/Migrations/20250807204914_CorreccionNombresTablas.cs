using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SPManager_Backend.Data.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionNombresTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    IdDescripcion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lugar = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    HorasRegistradas = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.IdDescripcion);
                });

            migrationBuilder.CreateTable(
                name: "Encargado",
                columns: table => new
                {
                    IdEncargado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoPersonal = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    TelefonoOficina = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encargado", x => x.IdEncargado);
                });

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    CodigoEstudiante = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Facultad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Carrera = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ciclo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IdDescripcion = table.Column<int>(type: "int", nullable: false),
                    IdEncargado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.CodigoEstudiante);
                    table.ForeignKey(
                        name: "FK_Estudiante_Detalle_IdDescripcion",
                        column: x => x.IdDescripcion,
                        principalTable: "Detalle",
                        principalColumn: "IdDescripcion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estudiante_Encargado_IdEncargado",
                        column: x => x.IdEncargado,
                        principalTable: "Encargado",
                        principalColumn: "IdEncargado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_IdDescripcion",
                table: "Estudiante",
                column: "IdDescripcion");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_IdEncargado",
                table: "Estudiante",
                column: "IdEncargado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiante");

            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "Encargado");
        }
    }
}
