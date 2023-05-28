using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loba.Infrastructure.Migrations
{
    public partial class ajuste_fks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioAudioTextoEntity",
                table: "UsuarioAudioTextoEntity");

            migrationBuilder.RenameTable(
                name: "UsuarioAudioTextoEntity",
                newName: "UsuarioAudioTexto");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioAudioTextoEntityid",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioAudioTextoEntityid",
                table: "TranscricaoAudio",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioAudioTextoEntityid",
                table: "AtaTexto",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioAudioTexto",
                table: "UsuarioAudioTexto",
                column: "id");

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

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_UsuarioAudioTextoEntityid",
                table: "Usuario",
                column: "UsuarioAudioTextoEntityid");

            migrationBuilder.CreateIndex(
                name: "IX_TranscricaoAudio_UsuarioAudioTextoEntityid",
                table: "TranscricaoAudio",
                column: "UsuarioAudioTextoEntityid");

            migrationBuilder.CreateIndex(
                name: "IX_AtaTexto_UsuarioAudioTextoEntityid",
                table: "AtaTexto",
                column: "UsuarioAudioTextoEntityid");

            migrationBuilder.AddForeignKey(
                name: "FK_AtaTexto_UsuarioAudioTexto_UsuarioAudioTextoEntityid",
                table: "AtaTexto",
                column: "UsuarioAudioTextoEntityid",
                principalTable: "UsuarioAudioTexto",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TranscricaoAudio_UsuarioAudioTexto_UsuarioAudioTextoEntityid",
                table: "TranscricaoAudio",
                column: "UsuarioAudioTextoEntityid",
                principalTable: "UsuarioAudioTexto",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_UsuarioAudioTexto_UsuarioAudioTextoEntityid",
                table: "Usuario",
                column: "UsuarioAudioTextoEntityid",
                principalTable: "UsuarioAudioTexto",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtaTexto_UsuarioAudioTexto_UsuarioAudioTextoEntityid",
                table: "AtaTexto");

            migrationBuilder.DropForeignKey(
                name: "FK_TranscricaoAudio_UsuarioAudioTexto_UsuarioAudioTextoEntityid",
                table: "TranscricaoAudio");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_UsuarioAudioTexto_UsuarioAudioTextoEntityid",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_UsuarioAudioTextoEntityid",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_TranscricaoAudio_UsuarioAudioTextoEntityid",
                table: "TranscricaoAudio");

            migrationBuilder.DropIndex(
                name: "IX_AtaTexto_UsuarioAudioTextoEntityid",
                table: "AtaTexto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioAudioTexto",
                table: "UsuarioAudioTexto");

            migrationBuilder.DropColumn(
                name: "UsuarioAudioTextoEntityid",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "UsuarioAudioTextoEntityid",
                table: "TranscricaoAudio");

            migrationBuilder.DropColumn(
                name: "UsuarioAudioTextoEntityid",
                table: "AtaTexto");

            migrationBuilder.RenameTable(
                name: "UsuarioAudioTexto",
                newName: "UsuarioAudioTextoEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioAudioTextoEntity",
                table: "UsuarioAudioTextoEntity",
                column: "id");

            migrationBuilder.UpdateData(
                table: "AtaTexto",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 30, 14, 19, 55, 967, DateTimeKind.Local).AddTicks(5666));

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
    }
}
