namespace Glabgiri.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_Customer : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "Name", "Family" });
            AlterColumn("dbo.Customers", "Family", c => c.String(maxLength: 25));
            CreateIndex("dbo.Customers", new[] { "Name", "Family" });
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "Name", "Family" });
            AlterColumn("dbo.Customers", "Family", c => c.String(nullable: false, maxLength: 25));
            CreateIndex("dbo.Customers", new[] { "Name", "Family" });
        }
    }
}
