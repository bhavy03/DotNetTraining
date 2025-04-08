namespace E_Commerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Categories_CategoriesId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Categories_CategoriesId" });
            RenameColumn(table: "dbo.Products", name: "Categories_CategoriesId", newName: "CategoriesId");
            AlterColumn("dbo.Products", "CategoriesId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CategoriesId");
            AddForeignKey("dbo.Products", "CategoriesId", "dbo.Categories", "CategoriesId", cascadeDelete: true);
            DropColumn("dbo.Products", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "CategoriesId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoriesId" });
            AlterColumn("dbo.Products", "CategoriesId", c => c.Int());
            RenameColumn(table: "dbo.Products", name: "CategoriesId", newName: "Categories_CategoriesId");
            CreateIndex("dbo.Products", "Categories_CategoriesId");
            AddForeignKey("dbo.Products", "Categories_CategoriesId", "dbo.Categories", "CategoriesId");
        }
    }
}
