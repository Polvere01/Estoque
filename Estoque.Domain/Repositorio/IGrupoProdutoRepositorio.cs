using Estoque.Domain.Entidades;
using System;
using System.Collections.Generic;

namespace Estoque.Domain.Repositorio
{
    public interface IGrupoProdutoaRepositorio : IDisposable
    {
        GrupoProduto RetornaGrupoProduto(int idGrupoProduto);
        List<GrupoProduto> ListaGrupoProduto();
        void Incluir(GrupoProduto grupoProduto);
        void Excluir(int idGrupoProduto);
        void Alterar(GrupoProduto grupoProduto);
    }
}
