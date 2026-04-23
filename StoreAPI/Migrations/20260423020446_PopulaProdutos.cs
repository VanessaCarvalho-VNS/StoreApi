using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produtos (Nome, Descricao, Preco, Estoque, ImagemUrl, DataCadastro, CategoriaId) " +
                "VALUES('Coca-cola', 'Refrigerante de cola', 5.00, 100, 'coca-cola.jpg', NOW(), 1)");

            mb.Sql("Insert into Produtos (Nome, Descricao, Preco, Estoque, ImagemUrl, DataCadastro, CategoriaId) " +
                "VALUES('Hambúrguer', 'Hambúrguer com queijo, alface e tomate', 15.00, 50, 'hamburguer.jpg', NOW(), 2)");

            mb.Sql("Insert into Produtos (Nome, Descricao, Preco, Estoque, ImagemUrl, DataCadastro, CategoriaId) " +
                "VALUES('Sorvete', 'Sorvete de chocolate', 7.00, 30, 'sorvete.jpg', NOW(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
