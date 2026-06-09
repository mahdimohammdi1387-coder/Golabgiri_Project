namespace Glabgiri.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActivitiesItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActivityItem = c.Int(nullable: false),
                        ActivityId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 19, scale: 4),
                        ProductUnitId = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 19, scale: 4),
                        TotalAmount = c.Decimal(nullable: false, precision: 19, scale: 4),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .ForeignKey("dbo.Productions", t => t.ActivityId)
                .ForeignKey("dbo.ProductUnits", t => t.ProductUnitId)
                .ForeignKey("dbo.Transactions", t => t.ActivityId)
                .Index(t => t.ActivityId)
                .Index(t => t.ProductId)
                .Index(t => t.ProductUnitId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 80),
                        Value = c.Decimal(nullable: false, precision: 19, scale: 4),
                        ProductUnitId = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 19, scale: 4),
                        Description = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.ProductUnits", t => t.ProductUnitId)
                .Index(t => t.ProductName)
                .Index(t => t.ProductUnitId);
            
            CreateTable(
                "dbo.Productions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 19, scale: 4),
                        Vahed = c.String(nullable: false, maxLength: 5),
                        Value = c.Decimal(nullable: false, precision: 19, scale: 4),
                        ProductUnitId = c.Int(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 19, scale: 4),
                        Description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .ForeignKey("dbo.ProductUnits", t => t.ProductUnitId)
                .Index(t => t.ProductId)
                .Index(t => t.Date)
                .Index(t => t.ProductUnitId);
            
            CreateTable(
                "dbo.ProductUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UnitName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        TransactionType = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 19, scale: 4),
                        Vahed = c.String(nullable: false, maxLength: 5),
                        Description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId)
                .Index(t => t.Date);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Family = c.String(nullable: false, maxLength: 25),
                        PhoneNumber = c.String(nullable: false, maxLength: 11),
                        Address = c.String(nullable: false, maxLength: 250),
                        Debit = c.Decimal(nullable: false, precision: 19, scale: 4),
                        Credit = c.Decimal(nullable: false, precision: 19, scale: 4),
                    })
                .PrimaryKey(t => t.CustomerId)
                .Index(t => new { t.Name, t.Family })
                .Index(t => t.PhoneNumber, unique: true);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransactionId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 19, scale: 4),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Transactions", t => t.TransactionId)
                .Index(t => t.TransactionId)
                .Index(t => t.Date);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ActivitiesItems", "ActivityId", "dbo.Transactions");
            DropForeignKey("dbo.Payments", "TransactionId", "dbo.Transactions");
            DropForeignKey("dbo.Transactions", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.ActivitiesItems", "ProductUnitId", "dbo.ProductUnits");
            DropForeignKey("dbo.ActivitiesItems", "ActivityId", "dbo.Productions");
            DropForeignKey("dbo.ActivitiesItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductUnitId", "dbo.ProductUnits");
            DropForeignKey("dbo.Productions", "ProductUnitId", "dbo.ProductUnits");
            DropForeignKey("dbo.Productions", "ProductId", "dbo.Products");
            DropIndex("dbo.Payments", new[] { "Date" });
            DropIndex("dbo.Payments", new[] { "TransactionId" });
            DropIndex("dbo.Customers", new[] { "PhoneNumber" });
            DropIndex("dbo.Customers", new[] { "Name", "Family" });
            DropIndex("dbo.Transactions", new[] { "Date" });
            DropIndex("dbo.Transactions", new[] { "CustomerId" });
            DropIndex("dbo.Productions", new[] { "ProductUnitId" });
            DropIndex("dbo.Productions", new[] { "Date" });
            DropIndex("dbo.Productions", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "ProductUnitId" });
            DropIndex("dbo.Products", new[] { "ProductName" });
            DropIndex("dbo.ActivitiesItems", new[] { "ProductUnitId" });
            DropIndex("dbo.ActivitiesItems", new[] { "ProductId" });
            DropIndex("dbo.ActivitiesItems", new[] { "ActivityId" });
            DropTable("dbo.Logins");
            DropTable("dbo.Payments");
            DropTable("dbo.Customers");
            DropTable("dbo.Transactions");
            DropTable("dbo.ProductUnits");
            DropTable("dbo.Productions");
            DropTable("dbo.Products");
            DropTable("dbo.ActivitiesItems");
        }
    }
}
