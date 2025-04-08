using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EF_CF
{
    internal class CodeFirstContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.HasDefaultSchema("Admin");

            //Map entity to table
            modelBuilder.Entity<Employee>().ToTable("EmployeeInfo");
            modelBuilder.Entity<Department>().ToTable("DepartmentInfo", "dbo");

            //modelBuilder.Entity<Student>().HasOptional(s => s.Address).WithRequired(ad => ad.Student);
            //A StudentAddress must be linked to a Student.
            //In StudentAddress, the Student property is required.
            //The StudentId in StudentAddress becomes both a Primary Key(PK) and a Foreign Key(FK).

            //protected override void OnModelCreating(DbModelBuilder modelBuilder)
            //{
            //    // configures one-to-many relationship
            //    modelBuilder.Entity<Student>()
            //        .HasRequired<Grade>(s => s.CurrentGrade)
            //        .WithMany(g => g.Students)
            //        .HasForeignKey<int>(s => s.CurrentGradeId);
            //}
        }
    }
}
