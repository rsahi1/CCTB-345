namespace MyCompany.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.ContactDetails",
                c => new
                    {
                        CustomerId = c.Int(nullable: false),
                        HomePhone = c.String(),
                        OfficeNumber = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.LineItems",
                c => new
                    {
                        LineItemId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LineItemId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        description = c.String(nullable: false, maxLength: 75),
                        name = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContactDetails", "CustomerId", "dbo.Customers");
            DropIndex("dbo.ContactDetails", new[] { "CustomerId" });
            DropTable("dbo.Products");
            DropTable("dbo.LineItems");
            DropTable("dbo.ContactDetails");
            DropTable("dbo.Categories");
        }
    }
}
