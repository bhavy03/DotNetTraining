using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public static class Properties
    {
        public static void properties()
        {
            //A Property in C# is a member of a class that is used to set and get
            //the data from a data field (i.e. variable) of a class. 
            //The most important point that you need to remember is that a property in C#
            //is never used to store any data, 
            //it just acts as an interface or medium to transfer the data.
            //We use the Properties as they are public data members of a class,
            //but they are actually special methods called accessors.

            //The Assessors are nothing but special methods which are used to set and get
            //the values from the underlying data member(i.e.variable) of a class. 
            //Assessors are of two types.

            //The default accessibility specifier of the accessor is the same as the accessibility specifier of the property.

            //symmetric accessors are those which have same accessibility specifier of the property
            //asymmetric accessors are those which don't have same accessibility specifier of the property

            //Convert read only accessorr into read write accessor by simply making one accessor as private


            Employee1 employee = new Employee1();
            //We cannot access the private data members
            //So, using public properties (SET Accessor) we are setting 
            //the values of private data members
            employee.accessEmpId = 101;
            employee.accessEmpName = "Pranaya";
            employee.Age = 23;
            //Using public properties (Get Accessor) we are Getting 
            //the values of private data members
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Employee id:" + employee.accessEmpId);
            Console.WriteLine("Employee name:" + employee.accessEmpName);
            Console.WriteLine("Employee age:" + employee.Age);
        }
    }
    public class Employee1
    {
        private int _EmpId;
        private string _EmpName;
        private int age;

        //Public Properties
        public int accessEmpId
        {
            set
            {
                _EmpId = value;
            }
            get
            {
                return _EmpId;
            }
        }
        public string accessEmpName  //-> this line is property
        {
            set //->these are accessors
            {
                _EmpName = value;
            }
            get
            {
                return _EmpName;
            }
        }
        public int Age { get; set; }
    }
}


