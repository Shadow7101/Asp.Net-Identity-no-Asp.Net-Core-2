using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace App1.Web.Data.Migrations
{
    public partial class Etapa05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerfisGrupos_Perfis_RoleId",
                table: "PerfisGrupos");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosGrupos_Usuarios_UserId",
                table: "UsuariosGrupos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuariosGrupos",
                table: "UsuariosGrupos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerfisGrupos",
                table: "PerfisGrupos");

            migrationBuilder.RenameTable(
                name: "UsuariosGrupos",
                newName: "UsuariosDireitosDeAcesso");

            migrationBuilder.RenameTable(
                name: "PerfisGrupos",
                newName: "PerfisDireitosDeAcesso");

            migrationBuilder.RenameIndex(
                name: "IX_UsuariosGrupos_UserId",
                table: "UsuariosDireitosDeAcesso",
                newName: "IX_UsuariosDireitosDeAcesso_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PerfisGrupos_RoleId",
                table: "PerfisDireitosDeAcesso",
                newName: "IX_PerfisDireitosDeAcesso_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuariosDireitosDeAcesso",
                table: "UsuariosDireitosDeAcesso",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerfisDireitosDeAcesso",
                table: "PerfisDireitosDeAcesso",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PerfisDireitosDeAcesso_Perfis_RoleId",
                table: "PerfisDireitosDeAcesso",
                column: "RoleId",
                principalTable: "Perfis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosDireitosDeAcesso_Usuarios_UserId",
                table: "UsuariosDireitosDeAcesso",
                column: "UserId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerfisDireitosDeAcesso_Perfis_RoleId",
                table: "PerfisDireitosDeAcesso");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosDireitosDeAcesso_Usuarios_UserId",
                table: "UsuariosDireitosDeAcesso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuariosDireitosDeAcesso",
                table: "UsuariosDireitosDeAcesso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerfisDireitosDeAcesso",
                table: "PerfisDireitosDeAcesso");

            migrationBuilder.RenameTable(
                name: "UsuariosDireitosDeAcesso",
                newName: "UsuariosGrupos");

            migrationBuilder.RenameTable(
                name: "PerfisDireitosDeAcesso",
                newName: "PerfisGrupos");

            migrationBuilder.RenameIndex(
                name: "IX_UsuariosDireitosDeAcesso_UserId",
                table: "UsuariosGrupos",
                newName: "IX_UsuariosGrupos_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PerfisDireitosDeAcesso_RoleId",
                table: "PerfisGrupos",
                newName: "IX_PerfisGrupos_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuariosGrupos",
                table: "UsuariosGrupos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerfisGrupos",
                table: "PerfisGrupos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PerfisGrupos_Perfis_RoleId",
                table: "PerfisGrupos",
                column: "RoleId",
                principalTable: "Perfis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosGrupos_Usuarios_UserId",
                table: "UsuariosGrupos",
                column: "UserId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
