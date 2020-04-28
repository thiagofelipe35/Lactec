using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoricoClimatologico.Database.Migrations
{
    public partial class AdicionarCampos_DataConsulta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataConsulta",
                table: "Historico",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataConsulta",
                table: "Historico");
        }
    }
}
