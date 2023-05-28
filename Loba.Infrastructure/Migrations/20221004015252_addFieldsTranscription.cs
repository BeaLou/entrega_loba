using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loba.Infrastructure.Migrations
{
    public partial class addFieldsTranscription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "tempoAudio",
                table: "Arquivo",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "caminhoArquivo",
                table: "Arquivo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "idiomaTranscricao",
                table: "Arquivo",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Arquivo",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "caminhoArquivo", "dataAlteracao", "idiomaTranscricao" },
                values: new object[] { "c:\\teste\\teste", new DateTime(2022, 10, 3, 22, 52, 52, 365, DateTimeKind.Local).AddTicks(8605), "pt-BR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "caminhoArquivo",
                table: "Arquivo");

            migrationBuilder.DropColumn(
                name: "idiomaTranscricao",
                table: "Arquivo");

            migrationBuilder.AlterColumn<string>(
                name: "tempoAudio",
                table: "Arquivo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Arquivo",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 9, 27, 21, 29, 36, 840, DateTimeKind.Local).AddTicks(5604));
        }
    }
}
