using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalFinance.WebApi.DAL.Migrations
{
    public partial class InicialDois : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Patrimonio_UsuariosId",
                table: "Patrimonio");

            migrationBuilder.CreateIndex(
                name: "IX_Patrimonio_UsuariosId",
                table: "Patrimonio",
                column: "UsuariosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Patrimonio_UsuariosId",
                table: "Patrimonio");

            migrationBuilder.CreateIndex(
                name: "IX_Patrimonio_UsuariosId",
                table: "Patrimonio",
                column: "UsuariosId",
                unique: true);
        }
    }
}
