using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Entidades
{
    public class Estoque
    {
        public Estoque(int qtdProduto)
        {
            QtdProduto = qtdProduto;
            Produtos = new List<Produto>();
        }

        protected Estoque()
        {
        }

        public int QtdProduto { get; private set; }
        public IEnumerable<Produto> Produtos { get; private set; }
    }
}
