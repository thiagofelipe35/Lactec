using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoricoClimatologico.Database.Migrations
{
    public partial class AdicionarCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodigoCidade",
                table: "Historico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Data",
                table: "Historico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Temperatura",
                table: "Historico",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Timezone",
                table: "Historico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Umidade",
                table: "Historico",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Visibilidade",
                table: "Historico",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoCidade",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "Temperatura",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "Timezone",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "Umidade",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "Visibilidade",
                table: "Historico");
        }
    }
}
