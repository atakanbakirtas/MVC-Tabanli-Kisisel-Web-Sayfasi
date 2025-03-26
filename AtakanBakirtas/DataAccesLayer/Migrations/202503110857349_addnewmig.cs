namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewmig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "BlogDetails", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "BlogDetails", c => c.String(maxLength: 500));
        }
    }
}
