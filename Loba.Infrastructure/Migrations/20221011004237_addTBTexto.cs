using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loba.Infrastructure.Migrations
{
    public partial class addTBTexto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AtaTexto",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dataAlteracao = table.Column<DateTime>(nullable: true),
                    excluido = table.Column<bool>(nullable: false),
                    nome = table.Column<string>(maxLength: 100, nullable: true),
                    caminho = table.Column<string>(nullable: true),
                    tamanho = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtaTexto", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "AtaTexto",
                columns: new[] { "id", "caminho", "dataAlteracao", "excluido", "nome", "tamanho" },
                values: new object[] { -1, "c:\\teste\\teste", new DateTime(2022, 10, 10, 21, 42, 37, 644, DateTimeKind.Local).AddTicks(6042), false, "PrimeiroArquivo", "50mb" });

            migrationBuilder.UpdateData(
                table: "TranscricaoAudio",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 10, 21, 42, 37, 643, DateTimeKind.Local).AddTicks(4814));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtaTexto");

            migrationBuilder.UpdateData(
                table: "TranscricaoAudio",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 10, 21, 10, 40, 236, DateTimeKind.Local).AddTicks(9096));
        }
    }
}
