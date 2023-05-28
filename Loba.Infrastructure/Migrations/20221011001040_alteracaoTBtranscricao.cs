using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loba.Infrastructure.Migrations
{
    public partial class alteracaoTBtranscricao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Arquivo",
                table: "Arquivo");

            migrationBuilder.DropColumn(
                name: "caminhoArquivo",
                table: "Arquivo");

            migrationBuilder.DropColumn(
                name: "extensaoArquivo",
                table: "Arquivo");

            migrationBuilder.DropColumn(
                name: "hexaArquivo",
                table: "Arquivo");

            migrationBuilder.DropColumn(
                name: "idiomaTranscricao",
                table: "Arquivo");

            migrationBuilder.DropColumn(
                name: "nomeArquivo",
                table: "Arquivo");

            migrationBuilder.DropColumn(
                name: "tempoAudio",
                table: "Arquivo");

            migrationBuilder.RenameTable(
                name: "Arquivo",
                newName: "TranscricaoAudio");

            migrationBuilder.AddColumn<string>(
                name: "caminho",
                table: "TranscricaoAudio",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "duracao",
                table: "TranscricaoAudio",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nome",
                table: "TranscricaoAudio",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TranscricaoAudio",
                table: "TranscricaoAudio",
                column: "id");

            migrationBuilder.UpdateData(
                table: "TranscricaoAudio",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "caminho", "dataAlteracao", "duracao", "nome" },
                values: new object[] { "c:\\teste\\teste", new DateTime(2022, 10, 10, 21, 10, 40, 236, DateTimeKind.Local).AddTicks(9096), "1:00:10", "PrimeiroArquivo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TranscricaoAudio",
                table: "TranscricaoAudio");

            migrationBuilder.DropColumn(
                name: "caminho",
                table: "TranscricaoAudio");

            migrationBuilder.DropColumn(
                name: "duracao",
                table: "TranscricaoAudio");

            migrationBuilder.DropColumn(
                name: "nome",
                table: "TranscricaoAudio");

            migrationBuilder.RenameTable(
                name: "TranscricaoAudio",
                newName: "Arquivo");

            migrationBuilder.AddColumn<string>(
                name: "caminhoArquivo",
                table: "Arquivo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "extensaoArquivo",
                table: "Arquivo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hexaArquivo",
                table: "Arquivo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "idiomaTranscricao",
                table: "Arquivo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nomeArquivo",
                table: "Arquivo",
                type: "varchar(100) CHARACTER SET utf8mb4",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tempoAudio",
                table: "Arquivo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arquivo",
                table: "Arquivo",
                column: "id");

            migrationBuilder.UpdateData(
                table: "Arquivo",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "caminhoArquivo", "dataAlteracao", "extensaoArquivo", "idiomaTranscricao", "nomeArquivo", "tempoAudio" },
                values: new object[] { "c:\\teste\\teste", new DateTime(2022, 10, 3, 22, 52, 52, 365, DateTimeKind.Local).AddTicks(8605), ".wav", "pt-BR", "PrimeiroArquivo", "1:00:10" });
        }
    }
}
