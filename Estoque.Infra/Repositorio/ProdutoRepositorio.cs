using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Estoque.Domain.Entidades;
using Estoque.Domain.Repositorio;

namespace Estoque.Infra.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        EstoqueDataContext _db = new EstoqueDataContext();

        public void Alterar(Produto produto)
        {
            _db.Entry<Produto>(produto).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Excluir(int idProduto)
        {
            Produto produto = RetornaProduto(idProduto);
            _db.Produto.Remove(produto);
            _db.SaveChanges();
        }

        public void Incluir(Produto produto)
        {
            _db.Produto.Add(produto);
            _db.SaveChanges();
        }

        public List<Produto> ListaProduto()
        {
            return _db.Produto.ToList();
        }

        public Produto RetornaProduto(int idProduto)
        {
            return _db.Produto.FirstOrDefault(x => x.IdProduto == idProduto);
        }
    }
}
