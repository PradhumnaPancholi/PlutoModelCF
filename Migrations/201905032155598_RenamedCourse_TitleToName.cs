namespace PlutoCFEDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedCourse_TitleToName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String());
            //to persist data//
            Sql("UPDATE Courses SET Name = Title");
            DropColumn("dbo.Courses", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String());
            DropColumn("dbo.Courses", "Name");
        }
    }
}
