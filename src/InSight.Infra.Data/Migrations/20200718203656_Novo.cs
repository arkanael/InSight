using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InSight.Infra.Data.Migrations
{
    public partial class Novo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fornecedor",
                keyColumn: "Id",
                keyValue: new Guid("e165afbd-81bf-4bae-af8f-0fb82ee5a45b"));

            migrationBuilder.InsertData(
                table: "Fornecedor",
                columns: new[] { "Id", "Cnpj", "Nome" },
                values: new object[] { new Guid("bf179962-62ad-4cd6-9476-40151f12ae48"), "03530117000175", "Hagen do Brasil" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fornecedor",
                keyColumn: "Id",
                keyValue: new Guid("bf179962-62ad-4cd6-9476-40151f12ae48"));

            migrationBuilder.InsertData(
                table: "Fornecedor",
                columns: new[] { "Id", "Cnpj", "Nome" },
                values: new object[] { new Guid("e165afbd-81bf-4bae-af8f-0fb82ee5a45b"), "03530117000175", "Hagen do Brasil" });
        }
    }
}
