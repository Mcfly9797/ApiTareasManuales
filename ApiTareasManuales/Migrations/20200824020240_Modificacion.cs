using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiTareasManuales.Migrations
{
    public partial class Modificacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Usuario_UsuarioId",
                table: "Tarea");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Tipo_Usuario_Tipo_UserId",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipo_Usuario",
                table: "Tipo_Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Tipo_Usuario",
                newName: "Tipo_User");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_Tipo_UserId",
                table: "User",
                newName: "IX_User_Tipo_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "IdUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipo_User",
                table: "Tipo_User",
                column: "IdTipoUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_User_UsuarioId",
                table: "Tarea",
                column: "UsuarioId",
                principalTable: "User",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Tipo_User_Tipo_UserId",
                table: "User",
                column: "Tipo_UserId",
                principalTable: "Tipo_User",
                principalColumn: "IdTipoUser",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_User_UsuarioId",
                table: "Tarea");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Tipo_User_Tipo_UserId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipo_User",
                table: "Tipo_User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "Tipo_User",
                newName: "Tipo_Usuario");

            migrationBuilder.RenameIndex(
                name: "IX_User_Tipo_UserId",
                table: "Usuario",
                newName: "IX_Usuario_Tipo_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "IdUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipo_Usuario",
                table: "Tipo_Usuario",
                column: "IdTipoUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_Usuario_UsuarioId",
                table: "Tarea",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Tipo_Usuario_Tipo_UserId",
                table: "Usuario",
                column: "Tipo_UserId",
                principalTable: "Tipo_Usuario",
                principalColumn: "IdTipoUser",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
