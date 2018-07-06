using System.Collections.Generic;

namespace Estoque.Domain.Entidades
{
    public class GrupoProduto
    {
        public GrupoProduto(int idGrupo,  string descricaoGrupo)
        {
            IdGrupo = idGrupo;
            DescricaoGrupo = descricaoGrupo;
        }

        protected GrupoProduto()
        {
        }

        public int IdGrupo { get; private set; }
        public string DescricaoGrupo { get; private set; }
        public ICollection<Produto> Produto { get; private set; }
    }
}
