using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_lib.Migrations
{
    /// <inheritdoc />
    public partial class IniciandoDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TituloLivro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AutorLivro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AnoLancamento = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    QuantidadeDisponivel = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locações",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeLocatario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AnoNascimento = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locações", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Locações");
        }
    }
}
