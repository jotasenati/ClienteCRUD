namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "DataCadastro", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "DataCadastro", c => c.DateTime(nullable: false));
        }
    }
}
