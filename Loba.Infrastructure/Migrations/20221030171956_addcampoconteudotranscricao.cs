using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loba.Infrastructure.Migrations
{
    public partial class addcampoconteudotranscricao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "textoTranscricao",
                table: "AtaTexto",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AtaTexto",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "dataAlteracao", "textoTranscricao" },
                values: new object[] { new DateTime(2022, 10, 30, 14, 19, 55, 967, DateTimeKind.Local).AddTicks(5666), "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" });

            migrationBuilder.UpdateData(
                table: "TranscricaoAudio",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 30, 14, 19, 55, 966, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 30, 14, 19, 55, 967, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "UsuarioAudioTextoEntity",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 30, 14, 19, 55, 967, DateTimeKind.Local).AddTicks(8328));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "textoTranscricao",
                table: "AtaTexto");

            migrationBuilder.UpdateData(
                table: "AtaTexto",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 11, 22, 58, 24, 440, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "TranscricaoAudio",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 11, 22, 58, 24, 439, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 11, 22, 58, 24, 440, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "UsuarioAudioTextoEntity",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 11, 22, 58, 24, 440, DateTimeKind.Local).AddTicks(4001));
        }
    }
}
