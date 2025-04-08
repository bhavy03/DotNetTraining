using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF_Migrations
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int DeptId { get; set; }
        public Department Departments { get; set; }

        public void Temp(Temp obj)
        {
            return;
        }
    }
}
