using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalFinance.WebApi.DAL.Migrations
{
    public partial class MudancaNomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Final",
                table: "Competencia");

            migrationBuilder.DropColumn(
                name: "Inicial",
                table: "Competencia");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFinal",
                table: "Competencia",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicial",
                table: "Competencia",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataFinal",
                table: "Competencia");

            migrationBuilder.DropColumn(
                name: "DataInicial",
                table: "Competencia");

            migrationBuilder.AddColumn<DateTime>(
                name: "Final",
                table: "Competencia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Inicial",
                table: "Competencia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
