using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Estoque.Domain.Entidades;
using Estoque.Domain.Repositorio;

namespace Estoque.Infra.Repositorio
{
    public class EmpresaRepositorio : IEmpresaRepositorio
    {
        EstoqueDataContext _db = new EstoqueDataContext();

        public void Alterar(Empresa empresa)
        {
            _db.Entry<Empresa>(empresa).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Excluir(int idEmpresa)
        {
            Empresa empresa = RetornaEmpresa(idEmpresa);
            _db.Empresa.Remove(empresa);
            _db.SaveChanges();
        }

        public void Incluir(Empresa empresa)
        {
            _db.Empresa.Add(empresa);
            _db.SaveChanges();
        }

        public List<Empresa> ListaEmpresa()
        {
            List<Empresa> ListaEmpresa = _db.Empresa.Include(x => x.Produto).ToList();

            return ListaEmpresa;

        }

        public Empresa RetornaEmpresa(int idEmpresa)
        {
            return _db.Empresa.FirstOrDefault(x => x.IdEmpresa == idEmpresa);
        }
    }
}
