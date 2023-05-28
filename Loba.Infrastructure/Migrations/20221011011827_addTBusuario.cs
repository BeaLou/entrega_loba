using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loba.Infrastructure.Migrations
{
    public partial class addTBusuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dataAlteracao = table.Column<DateTime>(nullable: true),
                    excluido = table.Column<bool>(nullable: false),
                    nome = table.Column<string>(maxLength: 100, nullable: true),
                    email = table.Column<string>(nullable: true),
                    senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });

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

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "id", "dataAlteracao", "email", "excluido", "nome", "senha" },
                values: new object[] { -1, new DateTime(2022, 10, 10, 22, 18, 26, 833, DateTimeKind.Local).AddTicks(3843), "bea@bea.com", false, "Bea", "123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.UpdateData(
                table: "AtaTexto",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 10, 21, 42, 37, 644, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "TranscricaoAudio",
                keyColumn: "id",
                keyValue: -1,
                column: "dataAlteracao",
                value: new DateTime(2022, 10, 10, 21, 42, 37, 643, DateTimeKind.Local).AddTicks(4814));
        }
    }
}
