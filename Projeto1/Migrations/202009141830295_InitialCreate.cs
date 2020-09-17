namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        CodCliente = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CPF = c.String(),
                        Endereco = c.String(),
                        Telefone = c.String(),
                        Celular = c.String(),
                        Email = c.String(),
                        Sexo = c.String(),
                        EstadoCivil = c.String(),
                        Salario = c.String(),
                        DataCadastro = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(),
                        DataExcluido = c.DateTime(),
                    })
                .PrimaryKey(t => t.CodCliente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
