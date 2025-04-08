using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        //public int DepartmentID { get; set; }
        public List<Department> Departments { get; set; }

        //public class1 data { get; set; }
    }
}
