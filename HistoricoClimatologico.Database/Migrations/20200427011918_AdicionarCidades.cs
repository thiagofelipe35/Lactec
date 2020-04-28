using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoricoClimatologico.Database.Migrations
{
    public partial class AdicionarCidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Porto Velho" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 25, "Aracaju" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 24, "João Pessoa" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 23, "Recife" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 22, "Fortaleza" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 21, "Belo Horizonte" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 20, "Florianópolis" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 19, "Curitiba" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 18, "Porto Alegre" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 17, "Maceió" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 16, "Salvador[nota 1]" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 15, "Goiânia" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 26, "Natal" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 14, "São Luís" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 12, "Rio de Janeiro" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 11, "São Paulo" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 10, "Teresina" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 9, "Palmas" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 8, "Cuiabá" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 7, "Boa Vista" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 6, "Brasília" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 5, "Macapá" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 4, "Campo Grande" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Rio Branco" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Manaus" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 13, "Belém" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 27, "Vitória" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cidade");
        }
    }
}
