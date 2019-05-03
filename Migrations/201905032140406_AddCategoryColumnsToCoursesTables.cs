namespace PlutoCFEDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryColumnsToCoursesTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "DatePublished", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "Category_CategoryID", c => c.Int());
            CreateIndex("dbo.Courses", "Category_CategoryID");
            AddForeignKey("dbo.Courses", "Category_CategoryID", "dbo.Categories", "CategoryID");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Category_CategoryID", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Category_CategoryID" });
            DropColumn("dbo.Courses", "Category_CategoryID");
            DropColumn("dbo.Courses", "DatePublished");
        }
    }
}
