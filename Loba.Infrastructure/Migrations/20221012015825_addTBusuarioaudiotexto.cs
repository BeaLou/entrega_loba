using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loba.Infrastructure.Migrations
{
    public partial class addTBusuarioaudiotexto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuarioAudioTextoEntity",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dataAlteracao = table.Column<DateTime>(nullable: true),
                    excluido = table.Column<bool>(nullable: false),
                    idUsuario = table.Column<int>(nullable: false),
                    idArquivoAudio = table.Column<int>(nullable: false),
                    idArquivoTexto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioAudioTextoEntity", x => x.id);
                });

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

            migrationBuilder.InsertData(
                table: "UsuarioAudioTextoEntity",
                columns: new[] { "id", "dataAlteracao", "excluido", "idArquivoAudio", "idArquivoTexto", "idUsuario" },
                values: new object[] { -1, new DateTime(2022, 10, 11, 22, 58, 24, 440, DateTimeKind.Local).AddTicks(4001), false, -1, -1, -1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioAudioTextoEntity");

            migrationBuilder.UpdateData(
                table: "AtaTexto",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 10, 22, 18, 26, 833, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "TranscricaoAudio",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 10, 22, 18, 26, 831, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 10, 22, 18, 26, 833, DateTimeKind.Local).AddTicks(3843));
        }
    }
}
