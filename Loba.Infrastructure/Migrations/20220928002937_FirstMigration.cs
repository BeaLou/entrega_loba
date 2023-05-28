using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loba.Infrastructure.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arquivo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dataAlteracao = table.Column<DateTime>(nullable: true),
                    excluido = table.Column<bool>(nullable: false),
                    nomeArquivo = table.Column<string>(maxLength: 100, nullable: true),
                    extensaoArquivo = table.Column<string>(nullable: true),
                    hexaArquivo = table.Column<string>(nullable: true),
                    tempoAudio = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arquivo", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Arquivo",
                columns: new[] { "id", "dataAlteracao", "excluido", "extensaoArquivo", "hexaArquivo", "nomeArquivo", "tempoAudio" },
                values: new object[] { -1, new DateTime(2022, 9, 27, 21, 29, 36, 840, DateTimeKind.Local).AddTicks(5604), false, ".wav", null, "PrimeiroArquivo", "1:00:10" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arquivo");
        }
    }
}
