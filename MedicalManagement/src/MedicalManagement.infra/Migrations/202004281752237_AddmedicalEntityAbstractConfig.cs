﻿namespace MedicalManagement.infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddmedicalEntityAbstractConfig : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Bairro", newName: "TLB_Bairro");
            RenameTable(name: "dbo.Cidade", newName: "TLB_Cidade");
            RenameTable(name: "dbo.Uf", newName: "TLB_Uf");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TLB_Uf", newName: "Uf");
            RenameTable(name: "dbo.TLB_Cidade", newName: "Cidade");
            RenameTable(name: "dbo.TLB_Bairro", newName: "Bairro");
        }
    }
}
