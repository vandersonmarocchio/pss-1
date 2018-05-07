namespace SGCO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produtos : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Estado");
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Estado_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estado", t => t.Estado_Id, cascadeDelete: true)
                .Index(t => t.Estado_Id);
            
            CreateTable(
                "dbo.Logradouro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        CEP = c.Int(nullable: false),
                        Numero = c.Int(nullable: false),
                        Bairro = c.String(nullable: false),
                        Referencia = c.String(),
                        Complemento = c.String(),
                        Cidade_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cidade", t => t.Cidade_Id, cascadeDelete: true)
                .Index(t => t.Cidade_Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        Nome = c.String(nullable: false),
                        Sobrenome = c.String(nullable: false),
                        CPF = c.Long(nullable: false),
                        Telefone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Nascimento = c.DateTime(nullable: false),
                        Logradouro_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Logradouro", t => t.Logradouro_Id, cascadeDelete: true)
                .Index(t => t.Logradouro_Id);
            
            AddColumn("dbo.Estado", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Produto", "Tag", c => c.String());
            AlterColumn("dbo.Estado", "Nome", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Estado", "Id");
            DropColumn("dbo.Produto", "Tags");
            DropColumn("dbo.Produto", "Teste");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produto", "Teste", c => c.String());
            AddColumn("dbo.Produto", "Tags", c => c.String());
            DropForeignKey("dbo.Usuario", "Logradouro_Id", "dbo.Logradouro");
            DropForeignKey("dbo.Logradouro", "Cidade_Id", "dbo.Cidade");
            DropForeignKey("dbo.Cidade", "Estado_Id", "dbo.Estado");
            DropIndex("dbo.Usuario", new[] { "Logradouro_Id" });
            DropIndex("dbo.Logradouro", new[] { "Cidade_Id" });
            DropIndex("dbo.Cidade", new[] { "Estado_Id" });
            DropPrimaryKey("dbo.Estado");
            AlterColumn("dbo.Estado", "Nome", c => c.String());
            DropColumn("dbo.Produto", "Tag");
            DropColumn("dbo.Estado", "Id");
            DropTable("dbo.Usuario");
            DropTable("dbo.Logradouro");
            DropTable("dbo.Cidade");
            AddPrimaryKey("dbo.Estado", "UF");
        }
    }
}
