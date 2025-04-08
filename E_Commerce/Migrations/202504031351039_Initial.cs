namespace E_Commerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProductOrders", newName: "OrderProducts");
            DropPrimaryKey("dbo.OrderProducts");
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoriesId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoriesId);
            
            AddColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Categories_CategoriesId", c => c.Int());
            AddPrimaryKey("dbo.OrderProducts", new[] { "Order_OrderId", "Product_ProductId" });
            CreateIndex("dbo.Products", "Categories_CategoriesId");
            AddForeignKey("dbo.Products", "Categories_CategoriesId", "dbo.Categories", "CategoriesId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Categories_CategoriesId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Categories_CategoriesId" });
            DropPrimaryKey("dbo.OrderProducts");
            DropColumn("dbo.Products", "Categories_CategoriesId");
            DropColumn("dbo.Products", "CategoryId");
            DropTable("dbo.Categories");
            AddPrimaryKey("dbo.OrderProducts", new[] { "Product_ProductId", "Order_OrderId" });
            RenameTable(name: "dbo.OrderProducts", newName: "ProductOrders");
        }
    }
}
