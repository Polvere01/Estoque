using Estoque.Domain.Entidades;
using System.Data.Entity;

namespace Estoque.Infra
{
    public class EstoqueDataContext : DbContext
    {
        public EstoqueDataContext()
            : base(@"Data Source=localhost;Initial Catalog=Estoque;Integrated Security = SSPI;")
        {

        }

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<GrupoProduto> GrupoProduto { get; set; }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmpresaMap());
            modelBuilder.Configurations.Add(new GrupoProdutoMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
        }
    }
}
