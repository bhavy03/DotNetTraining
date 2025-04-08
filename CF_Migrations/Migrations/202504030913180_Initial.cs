namespace CF_Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        DepartmentDescription = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        DeptId = c.Int(nullable: false),
                        Departments_DepartmentID = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Departments", t => t.Departments_DepartmentID)
                .Index(t => t.Departments_DepartmentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Departments_DepartmentID", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Departments_DepartmentID" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
