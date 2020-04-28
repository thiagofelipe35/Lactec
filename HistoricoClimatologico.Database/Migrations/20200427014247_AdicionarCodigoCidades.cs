using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoricoClimatologico.Database.Migrations
{
    public partial class AdicionarCodigoCidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Cidade",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 1,
                column: "Codigo",
                value: "3662762");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 2,
                column: "Codigo",
                value: "3663517");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 3,
                column: "Codigo",
                value: "3662574");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 4,
                column: "Codigo",
                value: "3467747");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 5,
                column: "Codigo",
                value: "3396016");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 6,
                column: "Codigo",
                value: "3469058");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 7,
                column: "Codigo",
                value: "3469745");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 8,
                column: "Codigo",
                value: "3465038");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 9,
                column: "Codigo",
                value: "3455459");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 10,
                column: "Codigo",
                value: "3386496");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 11,
                column: "Codigo",
                value: "3448439");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 12,
                column: "Codigo",
                value: "3451189");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 13,
                column: "Codigo",
                value: "3405863");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 14,
                column: "Codigo",
                value: "3388368");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 15,
                column: "Codigo",
                value: "3462377");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Codigo", "Nome" },
                values: new object[] { "3450554", "Salvador" });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 17,
                column: "Codigo",
                value: "6320645");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 18,
                column: "Codigo",
                value: "3452925");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 19,
                column: "Codigo",
                value: "3464975");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 20,
                column: "Codigo",
                value: "6323121");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 21,
                column: "Codigo",
                value: "2270968");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 22,
                column: "Codigo",
                value: "3399415");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 23,
                column: "Codigo",
                value: "3390760");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 24,
                column: "Codigo",
                value: "3397277");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 25,
                column: "Codigo",
                value: "3471872");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 26,
                column: "Codigo",
                value: "3394023");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 27,
                column: "Codigo",
                value: "3444924");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Cidade");

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: 16,
                column: "Nome",
                value: "Salvador[nota 1]");
        }
    }
}
