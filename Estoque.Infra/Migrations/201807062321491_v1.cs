namespace Estoque.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.t_empresa",
                c => new
                    {
                        IdEmpresa = c.Int(nullable: false, identity: true),
                        DescricaoEmpresa = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdEmpresa);
            
            CreateTable(
                "dbo.t_produto",
                c => new
                    {
                        IdProduto = c.Int(nullable: false, identity: true),
                        DescricaoProduto = c.String(nullable: false, maxLength: 10),
                        IdEmpresa = c.Int(nullable: false),
                        IdGrupoProduto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProduto)
                .ForeignKey("dbo.t_empresa", t => t.IdEmpresa, cascadeDelete: true)
                .ForeignKey("dbo.t_grupo_produto", t => t.IdGrupoProduto, cascadeDelete: true)
                .Index(t => t.IdEmpresa)
                .Index(t => t.IdGrupoProduto);
            
            CreateTable(
                "dbo.t_grupo_produto",
                c => new
                    {
                        IdGrupo = c.Int(nullable: false, identity: true),
                        DescricaoGrupo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdGrupo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.t_produto", "IdGrupoProduto", "dbo.t_grupo_produto");
            DropForeignKey("dbo.t_produto", "IdEmpresa", "dbo.t_empresa");
            DropIndex("dbo.t_produto", new[] { "IdGrupoProduto" });
            DropIndex("dbo.t_produto", new[] { "IdEmpresa" });
            DropTable("dbo.t_grupo_produto");
            DropTable("dbo.t_produto");
            DropTable("dbo.t_empresa");
        }
    }
}
