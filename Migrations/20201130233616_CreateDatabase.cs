using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiTareasManuales.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Disenio",
                columns: table => new
                {
                    IdDisenio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDisenio = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disenio", x => x.IdDisenio);
                });

            migrationBuilder.CreateTable(
                name: "Elemento",
                columns: table => new
                {
                    IdElemento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreElemento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elemento", x => x.IdElemento);
                });

            migrationBuilder.CreateTable(
                name: "Medida",
                columns: table => new
                {
                    IdMedida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMedida = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medida", x => x.IdMedida);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Trabajo",
                columns: table => new
                {
                    IdTipoTrabajo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoTrabajo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Trabajo", x => x.IdTipoTrabajo);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_User",
                columns: table => new
                {
                    IdTipoUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoUser = table.Column<int>(type: "int", nullable: false),
                    NombreTipoUser = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_User", x => x.IdTipoUser);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUser = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Tipo_UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_User_Tipo_User_Tipo_UserId",
                        column: x => x.Tipo_UserId,
                        principalTable: "Tipo_User",
                        principalColumn: "IdTipoUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    IdTarea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NroSerie = table.Column<int>(type: "int", nullable: false),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duracion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Tipo_TrabajoId = table.Column<int>(type: "int", nullable: false),
                    ElementoId = table.Column<int>(type: "int", nullable: false),
                    MedidaId = table.Column<int>(type: "int", nullable: false),
                    DisenioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.IdTarea);
                    table.ForeignKey(
                        name: "FK_Tarea_Disenio_DisenioId",
                        column: x => x.DisenioId,
                        principalTable: "Disenio",
                        principalColumn: "IdDisenio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tarea_Elemento_ElementoId",
                        column: x => x.ElementoId,
                        principalTable: "Elemento",
                        principalColumn: "IdElemento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tarea_Medida_MedidaId",
                        column: x => x.MedidaId,
                        principalTable: "Medida",
                        principalColumn: "IdMedida",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tarea_Tipo_Trabajo_Tipo_TrabajoId",
                        column: x => x.Tipo_TrabajoId,
                        principalTable: "Tipo_Trabajo",
                        principalColumn: "IdTipoTrabajo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tarea_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_DisenioId",
                table: "Tarea",
                column: "DisenioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_ElementoId",
                table: "Tarea",
                column: "ElementoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_MedidaId",
                table: "Tarea",
                column: "MedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_Tipo_TrabajoId",
                table: "Tarea",
                column: "Tipo_TrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_UserId",
                table: "Tarea",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Tipo_UserId",
                table: "User",
                column: "Tipo_UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Disenio");

            migrationBuilder.DropTable(
                name: "Elemento");

            migrationBuilder.DropTable(
                name: "Medida");

            migrationBuilder.DropTable(
                name: "Tipo_Trabajo");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Tipo_User");
        }
    }
}
