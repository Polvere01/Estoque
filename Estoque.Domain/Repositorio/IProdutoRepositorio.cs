using Estoque.Domain.Entidades;
using System;
using System.Collections.Generic;

namespace Estoque.Domain.Repositorio
{
    public interface IProdutoRepositorio : IDisposable
    {
        Produto RetornaProduto(int idProduto);
        List<Produto> ListaProduto();
        void Incluir(Produto produto);
        void Excluir(int idProduto);
        void Alterar(Produto produto);
    }
}
