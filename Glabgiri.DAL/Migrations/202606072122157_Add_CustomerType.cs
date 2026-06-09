namespace Glabgiri.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_CustomerType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Customertype", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Customertype");
        }
    }
}
