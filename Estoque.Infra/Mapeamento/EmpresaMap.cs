using Estoque.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Estoque.Infra
{
    public class EmpresaMap : EntityTypeConfiguration<Empresa>
    {

        public EmpresaMap()
        {
            ToTable("t_empresa");

            HasKey(x => x.IdEmpresa)
                    .Property(x => x.IdEmpresa)
                    .IsRequired();
            Property(x => x.DescricaoEmpresa)
                .IsRequired();
        }
       
    }
}
