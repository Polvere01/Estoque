using Estoque.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Estoque.Infra
{
    public class GrupoProdutoMap : EntityTypeConfiguration<GrupoProduto>
    {
        public GrupoProdutoMap()
        {
            ToTable("t_grupo_produto");

            HasKey(x => x.IdGrupo)
                    .Property(x => x.IdGrupo)
                    .IsRequired();

            Property(x => x.DescricaoGrupo)
                .IsRequired();
        }
       
    }
}
