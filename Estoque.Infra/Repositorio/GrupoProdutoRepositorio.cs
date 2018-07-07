using Estoque.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Domain.Entidades;
using System.Data.Entity;

namespace Estoque.Infra.Repositorio
{
    public class GrupoProdutoRepositorio : IGrupoProdutoaRepositorio
    {
        EstoqueDataContext _db = new EstoqueDataContext();

        public void Alterar(GrupoProduto grupoProduto)
        {
            _db.Entry<GrupoProduto>(grupoProduto).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Excluir(int idGrupoProduto)
        {
            GrupoProduto grupoProduto = RetornaGrupoProduto(idGrupoProduto);
            _db.GrupoProduto.Remove(grupoProduto);
            _db.SaveChanges();
        }

        public void Incluir(GrupoProduto grupoProduto)
        {
            _db.GrupoProduto.Add(grupoProduto);
            _db.SaveChanges();
        }

        public List<GrupoProduto> ListaGrupoProduto()
        {
            return _db.GrupoProduto.ToList();
        }

        public GrupoProduto RetornaGrupoProduto(int idGrupoProduto)
        {
            return _db.GrupoProduto.FirstOrDefault(x => x.IdGrupo == idGrupoProduto);
        }
    }
}
