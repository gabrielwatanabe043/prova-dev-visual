using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace APIExemplo.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationinicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    idVeiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    descricao = table.Column<string>(type: "longtext", nullable: false),
                    ano = table.Column<int>(type: "int", nullable: false),
                    placa = table.Column<string>(type: "longtext", nullable: false),
                    modelo = table.Column<string>(type: "longtext", nullable: false),
                    marca = table.Column<string>(type: "longtext", nullable: false),
                    cor = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.idVeiculo);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
