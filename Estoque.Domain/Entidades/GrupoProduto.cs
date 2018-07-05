using System.Collections;
using System.Collections.Generic;

namespace Estoque.Domain.Entidades
{
    public class Produto
    {
        public Produto(int idProduto, string descricaoProduto)
        {
            IdProduto = idProduto;
            DescricaoProduto = descricaoProduto;
            Produtos = new List<Produto>();
        }

        protected Produto()
        {
        }

        public int IdProduto { get; private set; }
        public string DescricaoProduto { get; private set; }
        public IEnumerable<Produto> Produtos { get; private set; }
    }
}
