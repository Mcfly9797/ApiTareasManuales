using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiTareasManuales.Migrations
{
    public partial class CorreccionTablaTareaNombreUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_User_UsuarioId",
                table: "Tarea");

            migrationBuilder.DropIndex(
                name: "IX_Tarea_UsuarioId",
                table: "Tarea");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Tarea");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Tarea",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_UserId",
                table: "Tarea",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_User_UserId",
                table: "Tarea",
                column: "UserId",
                principalTable: "User",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_User_UserId",
                table: "Tarea");

            migrationBuilder.DropIndex(
                name: "IX_Tarea_UserId",
                table: "Tarea");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tarea");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Tarea",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_UsuarioId",
                table: "Tarea",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_User_UsuarioId",
                table: "Tarea",
                column: "UsuarioId",
                principalTable: "User",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
