using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalFinance.WebApi.DAL.Migrations
{
    public partial class Inicialv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContaBancaria_Competencia_CompetenciaId",
                table: "ContaBancaria");

            migrationBuilder.DropForeignKey(
                name: "FK_Investimentos_Competencia_CompetenciaId",
                table: "Investimentos");

            migrationBuilder.DropTable(
                name: "LoginModel");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "ffc7f604-3550-4a44-910e-bc5a531019d3");

            migrationBuilder.AlterColumn<int>(
                name: "CompetenciaId",
                table: "Investimentos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompetenciaId",
                table: "ContaBancaria",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "016411a6-c529-4e11-b519-7d5fb8497660", 0, "63626842-d4cf-4f8c-a3f0-72cb726903b9", "admin@example.org", false, false, null, null, null, "AQAAAAEAACcQAAAAED0tb8N23CW0B1uLCmdSzL1kfJKD1NqSU6VxzkJ/ATsHW8awVv+bBSmNiACpNR9Iqw==", null, false, "58779edf-47b5-4e67-9034-65b44cf817ce", false, "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_ContaBancaria_Competencia_CompetenciaId",
                table: "ContaBancaria",
                column: "CompetenciaId",
                principalTable: "Competencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Investimentos_Competencia_CompetenciaId",
                table: "Investimentos",
                column: "CompetenciaId",
                principalTable: "Competencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContaBancaria_Competencia_CompetenciaId",
                table: "ContaBancaria");

            migrationBuilder.DropForeignKey(
                name: "FK_Investimentos_Competencia_CompetenciaId",
                table: "Investimentos");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: "016411a6-c529-4e11-b519-7d5fb8497660");

            migrationBuilder.AlterColumn<int>(
                name: "CompetenciaId",
                table: "Investimentos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompetenciaId",
                table: "ContaBancaria",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "LoginModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginModel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ffc7f604-3550-4a44-910e-bc5a531019d3", 0, "5edda6eb-9ead-4bff-9402-99e779be5c4a", "admin@example.org", false, false, null, null, null, "AQAAAAEAACcQAAAAED0tb8N23CW0B1uLCmdSzL1kfJKD1NqSU6VxzkJ/ATsHW8awVv+bBSmNiACpNR9Iqw==", null, false, "05b6d4b8-e5c1-477d-a4e4-000ae9646364", false, "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_ContaBancaria_Competencia_CompetenciaId",
                table: "ContaBancaria",
                column: "CompetenciaId",
                principalTable: "Competencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investimentos_Competencia_CompetenciaId",
                table: "Investimentos",
                column: "CompetenciaId",
                principalTable: "Competencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
