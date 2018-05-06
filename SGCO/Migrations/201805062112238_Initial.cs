namespace SGCO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        UF = c.String(nullable: false, maxLength: 2),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.UF);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Estado");
        }
    }
}
