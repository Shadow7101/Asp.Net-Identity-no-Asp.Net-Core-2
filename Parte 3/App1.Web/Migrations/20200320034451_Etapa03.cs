using Microsoft.EntityFrameworkCore.Migrations;

namespace App1.Web.Migrations
{
    public partial class Etapa03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Usuarios",
                newName: "EnderecoDeEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnderecoDeEmail",
                table: "Usuarios",
                newName: "Email");
        }
    }
}
