using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InSight.Infra.Data.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioPerfil_Usuario_UsuarioId",
                table: "UsuarioPerfil");

            migrationBuilder.DeleteData(
                table: "Fornecedor",
                keyColumn: "Id",
                keyValue: new Guid("bf179962-62ad-4cd6-9476-40151f12ae48"));

            migrationBuilder.InsertData(
                table: "Fornecedor",
                columns: new[] { "Id", "Cnpj", "Nome" },
                values: new object[] { new Guid("f2a39d17-72c3-474d-8191-2edce07c9356"), "03530117000175", "Hagen do Brasil" });

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioPerfil_Usuario_UsuarioId",
                table: "UsuarioPerfil",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioPerfil_Usuario_UsuarioId",
                table: "UsuarioPerfil");

            migrationBuilder.DeleteData(
                table: "Fornecedor",
                keyColumn: "Id",
                keyValue: new Guid("f2a39d17-72c3-474d-8191-2edce07c9356"));

            migrationBuilder.InsertData(
                table: "Fornecedor",
                columns: new[] { "Id", "Cnpj", "Nome" },
                values: new object[] { new Guid("bf179962-62ad-4cd6-9476-40151f12ae48"), "03530117000175", "Hagen do Brasil" });

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioPerfil_Usuario_UsuarioId",
                table: "UsuarioPerfil",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
