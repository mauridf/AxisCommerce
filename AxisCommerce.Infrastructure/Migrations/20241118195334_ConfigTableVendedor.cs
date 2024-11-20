using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AxisCommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ConfigTableVendedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Vendedor_Gerente",
                table: "Vendedores");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Vendedor_OperadorCaixa",
                table: "Vendedores");

            migrationBuilder.AlterColumn<string>(
                name: "SenhaVendedor",
                table: "Vendedores",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "NomeVendedor",
                table: "Vendedores",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "LoginVendedor",
                table: "Vendedores",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CodVendedor",
                table: "Vendedores",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Vendedores",
                type: "character varying(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Apelido",
                table: "Vendedores",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<Guid>(
                name: "LojasId",
                table: "Vendedores",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendedores_LojasId",
                table: "Vendedores",
                column: "LojasId");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Vendedor_Gerente",
                table: "Vendedores",
                sql: "\"IndicaGerente\" IN (false, true)");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Vendedor_OperadorCaixa",
                table: "Vendedores",
                sql: "\"IndicaOperadorCaixa\" IN (false, true)");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedores_Lojas_LojasId",
                table: "Vendedores",
                column: "LojasId",
                principalTable: "Lojas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedores_Lojas_LojasId",
                table: "Vendedores");

            migrationBuilder.DropIndex(
                name: "IX_Vendedores_LojasId",
                table: "Vendedores");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Vendedor_Gerente",
                table: "Vendedores");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Vendedor_OperadorCaixa",
                table: "Vendedores");

            migrationBuilder.DropColumn(
                name: "LojasId",
                table: "Vendedores");

            migrationBuilder.AlterColumn<string>(
                name: "SenhaVendedor",
                table: "Vendedores",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "NomeVendedor",
                table: "Vendedores",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LoginVendedor",
                table: "Vendedores",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CodVendedor",
                table: "Vendedores",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Vendedores",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "Apelido",
                table: "Vendedores",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AddCheckConstraint(
                name: "CK_Vendedor_Gerente",
                table: "Vendedores",
                sql: "\"IndicaGerente\" IN (false, true)");  // Correção aqui

            migrationBuilder.AddCheckConstraint(
                name: "CK_Vendedor_OperadorCaixa",
                table: "Vendedores",
                sql: "\"IndicaOperadorCaixa\" IN (false, true)");  // Correção aqui
        }
    }
}
