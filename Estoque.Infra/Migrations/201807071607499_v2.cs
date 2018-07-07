namespace Estoque.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.t_produto", name: "IdEmpresa", newName: "Empresa_IdEmpresa");
            RenameColumn(table: "dbo.t_produto", name: "IdGrupoProduto", newName: "GrupoProduto_IdGrupo");
            RenameIndex(table: "dbo.t_produto", name: "IX_IdEmpresa", newName: "IX_Empresa_IdEmpresa");
            RenameIndex(table: "dbo.t_produto", name: "IX_IdGrupoProduto", newName: "IX_GrupoProduto_IdGrupo");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.t_produto", name: "IX_GrupoProduto_IdGrupo", newName: "IX_IdGrupoProduto");
            RenameIndex(table: "dbo.t_produto", name: "IX_Empresa_IdEmpresa", newName: "IX_IdEmpresa");
            RenameColumn(table: "dbo.t_produto", name: "GrupoProduto_IdGrupo", newName: "IdGrupoProduto");
            RenameColumn(table: "dbo.t_produto", name: "Empresa_IdEmpresa", newName: "IdEmpresa");
        }
    }
}
