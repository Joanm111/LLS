using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen2.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "librosid_Autor",
                table: "Autor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Autor_librosid_Autor",
                table: "Autor",
                column: "librosid_Autor");

            migrationBuilder.AddForeignKey(
                name: "FK_Autor_libros_librosid_Autor",
                table: "Autor",
                column: "librosid_Autor",
                principalTable: "libros",
                principalColumn: "id_Autor",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autor_libros_librosid_Autor",
                table: "Autor");

            migrationBuilder.DropIndex(
                name: "IX_Autor_librosid_Autor",
                table: "Autor");

            migrationBuilder.DropColumn(
                name: "librosid_Autor",
                table: "Autor");
        }
    }
}
