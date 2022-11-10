using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen2.Migrations
{
    public partial class primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    id_Autor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Nacionalidad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Edad = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.id_Autor);
                });

            migrationBuilder.CreateTable(
                name: "libros",
                columns: table => new
                {
                    id_Autor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isbn = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    precio = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libros", x => x.id_Autor);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "libros");
        }
    }
}
