namespace MedicalManagement.infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEntityTypeConfigurationWithFluentApi : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bairro", "CidadeId", "dbo.Cidade");
            AddColumn("dbo.Bairro", "Cidade_CidadeId", c => c.Int());
            AlterColumn("dbo.Bairro", "Descricao", c => c.String(nullable: false, maxLength: 70, unicode: false));
            AlterColumn("dbo.Cidade", "Descricao", c => c.String(nullable: false, maxLength: 70, unicode: false));
            AlterColumn("dbo.Uf", "Sigla", c => c.String(nullable: false, maxLength: 2, unicode: false));
            AlterColumn("dbo.Uf", "Estado", c => c.String(nullable: false, maxLength: 100, unicode: false));
            CreateIndex("dbo.Bairro", "Cidade_CidadeId");
            AddForeignKey("dbo.Bairro", "Cidade_CidadeId", "dbo.Cidade", "CidadeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bairro", "Cidade_CidadeId", "dbo.Cidade");
            DropIndex("dbo.Bairro", new[] { "Cidade_CidadeId" });
            AlterColumn("dbo.Uf", "Estado", c => c.String(maxLength: 80, unicode: false));
            AlterColumn("dbo.Uf", "Sigla", c => c.String(maxLength: 80, unicode: false));
            AlterColumn("dbo.Cidade", "Descricao", c => c.String(maxLength: 80, unicode: false));
            AlterColumn("dbo.Bairro", "Descricao", c => c.String(maxLength: 80, unicode: false));
            DropColumn("dbo.Bairro", "Cidade_CidadeId");
            AddForeignKey("dbo.Bairro", "CidadeId", "dbo.Cidade", "CidadeId");
        }
    }
}
