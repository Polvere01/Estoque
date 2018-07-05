using Estoque.Domain.Entidades;
using System;
using System.Collections.Generic;

namespace Estoque.Domain.Repositorio
{
    public interface IEmpresaRepositorio : IDisposable
    {
        Empresa RetornaEmpresa(int idEmpresa);
        List<Empresa> ListaEmpresa();
        void Incluir(Empresa empresa);
        void Excluir(int idEmpresa);
        void Alterar(Empresa empresa);
    }
}
