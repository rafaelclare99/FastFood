using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)" +
               "VALUES('Normal','Lanches feito com ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)" +
                "VALUES('Natural','Lanches feito com ingredientes integrais e naturais')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)" +
                "VALUES('Vegano','Lanches feito com ingredientes veganos')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");

        }
    }
}
