namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "BlogImage", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "BlogImage", c => c.String(maxLength: 100));
        }
    }
}
