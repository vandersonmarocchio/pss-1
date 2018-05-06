namespace SGCO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produto1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "Teste", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produto", "Teste");
        }
    }
}
