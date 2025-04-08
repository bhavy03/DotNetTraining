namespace E_Commerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableAdded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderProducts", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderProducts", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.OrderProducts", new[] { "Order_OrderId" });
            DropIndex("dbo.OrderProducts", new[] { "Product_ProductId" });
            CreateTable(
                "dbo.OrderProductMappings",
                c => new
                    {
                        OrderProductMappingId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderProductMappingId)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.OrderId);
            
            DropColumn("dbo.Orders", "Quantity");
            DropTable("dbo.OrderProducts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OrderProducts",
                c => new
                    {
                        Order_OrderId = c.Int(nullable: false),
                        Product_ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Order_OrderId, t.Product_ProductId });
            
            AddColumn("dbo.Orders", "Quantity", c => c.Int(nullable: false));
            DropForeignKey("dbo.OrderProductMappings", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderProductMappings", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderProductMappings", new[] { "OrderId" });
            DropIndex("dbo.OrderProductMappings", new[] { "ProductId" });
            DropTable("dbo.OrderProductMappings");
            CreateIndex("dbo.OrderProducts", "Product_ProductId");
            CreateIndex("dbo.OrderProducts", "Order_OrderId");
            AddForeignKey("dbo.OrderProducts", "Product_ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
            AddForeignKey("dbo.OrderProducts", "Order_OrderId", "dbo.Orders", "OrderId", cascadeDelete: true);
        }
    }
}
