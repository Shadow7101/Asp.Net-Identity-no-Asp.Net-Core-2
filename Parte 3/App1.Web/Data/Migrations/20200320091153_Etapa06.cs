using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace App1.Web.Data.Migrations
{
    public partial class Etapa06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Usuarios",
                newName: "Login");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "Usuarios",
                newName: "LoginDeDoisFatores");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "Usuarios",
                newName: "Salt");

            migrationBuilder.RenameColumn(
                name: "PhoneNumberConfirmed",
                table: "Usuarios",
                newName: "CelularConfirmado");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Usuarios",
                newName: "Celular");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Usuarios",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "NormalizedUserName",
                table: "Usuarios",
                newName: "LoginPadronizado");

            migrationBuilder.RenameColumn(
                name: "NormalizedEmail",
                table: "Usuarios",
                newName: "EmailPadronizado");

            migrationBuilder.RenameColumn(
                name: "LockoutEnd",
                table: "Usuarios",
                newName: "UsuarioBloqueadoAte");

            migrationBuilder.RenameColumn(
                name: "LockoutEnabled",
                table: "Usuarios",
                newName: "UsuarioBloqueado");

            migrationBuilder.RenameColumn(
                name: "ConcurrencyStamp",
                table: "Usuarios",
                newName: "ChaveDeValidacao");

            migrationBuilder.RenameColumn(
                name: "AccessFailedCount",
                table: "Usuarios",
                newName: "ContadorFalhasDeLogin");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Usuarios",
                column: "LoginPadronizado",
                unique: true,
                filter: "[LoginPadronizado] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Usuarios",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "LoginDeDoisFatores",
                table: "Usuarios",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "Salt",
                table: "Usuarios",
                newName: "SecurityStamp");

            migrationBuilder.RenameColumn(
                name: "CelularConfirmado",
                table: "Usuarios",
                newName: "PhoneNumberConfirmed");

            migrationBuilder.RenameColumn(
                name: "Celular",
                table: "Usuarios",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Usuarios",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "LoginPadronizado",
                table: "Usuarios",
                newName: "NormalizedUserName");

            migrationBuilder.RenameColumn(
                name: "EmailPadronizado",
                table: "Usuarios",
                newName: "NormalizedEmail");

            migrationBuilder.RenameColumn(
                name: "UsuarioBloqueadoAte",
                table: "Usuarios",
                newName: "LockoutEnd");

            migrationBuilder.RenameColumn(
                name: "UsuarioBloqueado",
                table: "Usuarios",
                newName: "LockoutEnabled");

            migrationBuilder.RenameColumn(
                name: "ChaveDeValidacao",
                table: "Usuarios",
                newName: "ConcurrencyStamp");

            migrationBuilder.RenameColumn(
                name: "ContadorFalhasDeLogin",
                table: "Usuarios",
                newName: "AccessFailedCount");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Usuarios",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }
    }
}
