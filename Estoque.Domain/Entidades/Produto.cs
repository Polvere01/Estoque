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
        }

        protected Produto()
        {
        }

        public int IdProduto { get; private set; }
        public string DescricaoProduto { get; private set; }
        public Empresa Empresa { get; private set; }
        public GrupoProduto GrupoProduto { get; private set; }
    }
}
