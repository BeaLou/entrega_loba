using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loba.Infrastructure.Migrations
{
    public partial class addedDataInclusao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "dataInclusao",
                table: "UsuarioAudioTexto",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dataInclusao",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dataInclusao",
                table: "TranscricaoAudio",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dataInclusao",
                table: "AtaTexto",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AtaTexto",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "dataAlteracao", "dataInclusao" },
                values: new object[] { new DateTime(2022, 10, 30, 16, 11, 58, 330, DateTimeKind.Local).AddTicks(6794), new DateTime(2022, 10, 30, 16, 11, 58, 330, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "TranscricaoAudio",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "dataAlteracao", "dataInclusao" },
                values: new object[] { new DateTime(2022, 10, 30, 16, 11, 58, 329, DateTimeKind.Local).AddTicks(6738), new DateTime(2022, 10, 30, 16, 11, 58, 328, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "dataAlteracao", "dataInclusao" },
                values: new object[] { new DateTime(2022, 10, 30, 16, 11, 58, 330, DateTimeKind.Local).AddTicks(8087), new DateTime(2022, 10, 30, 16, 11, 58, 330, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "UsuarioAudioTexto",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "dataAlteracao", "dataInclusao" },
                values: new object[] { new DateTime(2022, 10, 30, 16, 11, 58, 330, DateTimeKind.Local).AddTicks(9162), new DateTime(2022, 10, 30, 16, 11, 58, 330, DateTimeKind.Local).AddTicks(9159) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dataInclusao",
                table: "UsuarioAudioTexto");

            migrationBuilder.DropColumn(
                name: "dataInclusao",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "dataInclusao",
                table: "TranscricaoAudio");

            migrationBuilder.DropColumn(
                name: "dataInclusao",
                table: "AtaTexto");

            migrationBuilder.UpdateData(
                table: "AtaTexto",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 30, 15, 47, 6, 28, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "TranscricaoAudio",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 30, 15, 47, 6, 26, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 30, 15, 47, 6, 28, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "UsuarioAudioTexto",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 30, 15, 47, 6, 29, DateTimeKind.Local).AddTicks(1375));
        }
    }
}
