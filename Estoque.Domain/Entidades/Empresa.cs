using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Entidades
{
    public class Empresa
    {
        public Empresa(int idEmpresa, string descricaoEmpresa )
        {
            IdEmpresa = idEmpresa;
            DescricaoEmpresa = descricaoEmpresa;
            Produto = new List<Produto>();
        }

        protected Empresa()
        {
        }

        public int IdEmpresa { get; private set; }
        public string DescricaoEmpresa { get; private set; }
        public ICollection<Produto> Produto { get; private set; }
    }
}
