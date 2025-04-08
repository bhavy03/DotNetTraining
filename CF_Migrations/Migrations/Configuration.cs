namespace CF_Migrations.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CF_Migrations.CodeFirstContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CF_Migrations.CodeFirstContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            Department department = new Department
            {
                DepartmentName = "Technology",
                Employees = new List<Employee>
                {
                    new Employee() {EmployeeName = "Jack"},
                    new Employee() {EmployeeName = "Kim"},
                    new Employee() {EmployeeName = "Shen"}
                }
            };

            Employee employee = new Employee
            {
                EmployeeName = "Akhil Mittal",
                DeptId = 1
            };

            context.Departments.AddOrUpdate(department);
            context.Employees.AddOrUpdate(employee);
        }
    }
}
