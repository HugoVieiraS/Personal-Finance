using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalFinance.WebApi.DAL.Migrations
{
    public partial class Inicialv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeEmpresa",
                table: "Salario");

            migrationBuilder.DropColumn(
                name: "DataGanho",
                table: "GanhoExtra");

            migrationBuilder.AddColumn<string>(
                name: "OrigemGanho",
                table: "Salario",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInvestimento",
                table: "Investimentos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataRecebimento",
                table: "GanhoExtra",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrigemGanho",
                table: "Salario");

            migrationBuilder.DropColumn(
                name: "DataInvestimento",
                table: "Investimentos");

            migrationBuilder.DropColumn(
                name: "DataRecebimento",
                table: "GanhoExtra");

            migrationBuilder.AddColumn<string>(
                name: "NomeEmpresa",
                table: "Salario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataGanho",
                table: "GanhoExtra",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
