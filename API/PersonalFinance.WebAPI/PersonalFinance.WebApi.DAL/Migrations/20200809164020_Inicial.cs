using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalFinance.WebApi.DAL.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inicial = table.Column<DateTime>(nullable: false),
                    Final = table.Column<DateTime>(nullable: false),
                    ValorGasto = table.Column<double>(nullable: false),
                    ValorGanho = table.Column<double>(nullable: false),
                    ValorSobra = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContaBancaria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeBanco = table.Column<string>(nullable: true),
                    ValorConta = table.Column<double>(nullable: false),
                    Rendimento = table.Column<double>(nullable: false),
                    CompetenciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaBancaria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContaBancaria_Competencia_CompetenciaId",
                        column: x => x.CompetenciaId,
                        principalTable: "Competencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GanhoExtra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origem = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    DataGanho = table.Column<DateTime>(nullable: false),
                    CompetenciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GanhoExtra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GanhoExtra_Competencia_CompetenciaId",
                        column: x => x.CompetenciaId,
                        principalTable: "Competencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gastos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeConta = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    DataPagamento = table.Column<DateTime>(nullable: false),
                    DataGasto = table.Column<DateTime>(nullable: false),
                    CompetenciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gastos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gastos_Competencia_CompetenciaId",
                        column: x => x.CompetenciaId,
                        principalTable: "Competencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Investimentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeInvestimento = table.Column<string>(nullable: true),
                    ValorInvestido = table.Column<double>(nullable: false),
                    Rendimento = table.Column<double>(nullable: false),
                    CompetenciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investimentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Investimentos_Competencia_CompetenciaId",
                        column: x => x.CompetenciaId,
                        principalTable: "Competencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEmpresa = table.Column<string>(nullable: true),
                    DataRecebimento = table.Column<DateTime>(nullable: false),
                    ValorBruto = table.Column<double>(nullable: false),
                    Desconto1 = table.Column<double>(nullable: false),
                    Desconto2 = table.Column<double>(nullable: false),
                    Imposto = table.Column<double>(nullable: false),
                    ValorLiquido = table.Column<double>(nullable: false),
                    ValorAdicional = table.Column<double>(nullable: false),
                    CompetenciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salario_Competencia_CompetenciaId",
                        column: x => x.CompetenciaId,
                        principalTable: "Competencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContaBancaria_CompetenciaId",
                table: "ContaBancaria",
                column: "CompetenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_GanhoExtra_CompetenciaId",
                table: "GanhoExtra",
                column: "CompetenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_CompetenciaId",
                table: "Gastos",
                column: "CompetenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Investimentos_CompetenciaId",
                table: "Investimentos",
                column: "CompetenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Salario_CompetenciaId",
                table: "Salario",
                column: "CompetenciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContaBancaria");

            migrationBuilder.DropTable(
                name: "GanhoExtra");

            migrationBuilder.DropTable(
                name: "Gastos");

            migrationBuilder.DropTable(
                name: "Investimentos");

            migrationBuilder.DropTable(
                name: "Salario");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Competencia");
        }
    }
}
