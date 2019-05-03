namespace PlutoCFEDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            Sql("INSERT into Categories VALUES('Web Developnment')");
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
