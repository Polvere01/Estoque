using Estoque.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Estoque.Infra
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("t_produto");

            HasKey(x => x.IdProduto)
                .Property(x => x.IdProduto)
                .IsRequired();

            Property(x => x.DescricaoProduto)
                .HasMaxLength(10)
                .IsRequired();

            HasRequired(x => x.Empresa);

            HasRequired(x => x.GrupoProduto);
        }
    }
}
