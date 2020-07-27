using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalFinance.WebApi.DAL.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContaBancaria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeBanco = table.Column<string>(nullable: true),
                    ValorConta = table.Column<double>(nullable: false),
                    Rendimento = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaBancaria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GanhoExtra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origem = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    DataGanho = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GanhoExtra", x => x.Id);
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
                    DataGasto = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gastos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Investimentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeInvestimento = table.Column<string>(nullable: true),
                    ValorInvestido = table.Column<double>(nullable: false),
                    Rendimento = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investimentos", x => x.Id);
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
                    ValorAdicional = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salario", x => x.Id);
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
                name: "Patrimonio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorPatrimonio = table.Column<double>(nullable: false),
                    ContaBancariaId = table.Column<int>(nullable: false),
                    InvestimentosId = table.Column<int>(nullable: false),
                    UsuariosId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patrimonio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patrimonio_ContaBancaria_ContaBancariaId",
                        column: x => x.ContaBancariaId,
                        principalTable: "ContaBancaria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patrimonio_Investimentos_InvestimentosId",
                        column: x => x.InvestimentosId,
                        principalTable: "Investimentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patrimonio_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    ValorSobra = table.Column<double>(nullable: false),
                    SalarioId = table.Column<int>(nullable: false),
                    GastosId = table.Column<int>(nullable: false),
                    GanhoExtraId = table.Column<int>(nullable: false),
                    PatrimonioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competencia_GanhoExtra_GanhoExtraId",
                        column: x => x.GanhoExtraId,
                        principalTable: "GanhoExtra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Competencia_Gastos_GastosId",
                        column: x => x.GastosId,
                        principalTable: "Gastos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Competencia_Patrimonio_PatrimonioId",
                        column: x => x.PatrimonioId,
                        principalTable: "Patrimonio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Competencia_Salario_SalarioId",
                        column: x => x.SalarioId,
                        principalTable: "Salario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competencia_GanhoExtraId",
                table: "Competencia",
                column: "GanhoExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_Competencia_GastosId",
                table: "Competencia",
                column: "GastosId");

            migrationBuilder.CreateIndex(
                name: "IX_Competencia_PatrimonioId",
                table: "Competencia",
                column: "PatrimonioId");

            migrationBuilder.CreateIndex(
                name: "IX_Competencia_SalarioId",
                table: "Competencia",
                column: "SalarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Patrimonio_ContaBancariaId",
                table: "Patrimonio",
                column: "ContaBancariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Patrimonio_InvestimentosId",
                table: "Patrimonio",
                column: "InvestimentosId");

            migrationBuilder.CreateIndex(
                name: "IX_Patrimonio_UsuariosId",
                table: "Patrimonio",
                column: "UsuariosId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Competencia");

            migrationBuilder.DropTable(
                name: "GanhoExtra");

            migrationBuilder.DropTable(
                name: "Gastos");

            migrationBuilder.DropTable(
                name: "Patrimonio");

            migrationBuilder.DropTable(
                name: "Salario");

            migrationBuilder.DropTable(
                name: "ContaBancaria");

            migrationBuilder.DropTable(
                name: "Investimentos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
