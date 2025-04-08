using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EFModel1Container container = new EFModel1Container();
            //container.Classes.Add(new Class()
            //{
            //    ClassName = "Nursery"
            //});
            ICollection<Student> students = new List<Student> {
            new Student() {
            Name = "Mark"
            },
            new Student() {
            Name = "Joe"
            },
            new Student() {
            Name = "Allen"
            }
            };
            container.Classes.Add(new Class()
            {
                ClassName = "KG",
                Students = students
            });
            container.SaveChanges();
        }
    }
}


//Microsoft Entity Framework is an ORM (Object-relational mapping).
//Object - relational mapping(ORM, O / RM, and O / R mapping tool) in computer science is a programming
//technique for converting data between incompatible type systems using object-oriented programming languages.
//This creates, in effect, a "virtual object database" that can be used from within the programming language.
//t is built over traditional ADO.NET and acts as a wrapper over ADO.NET and is an enhancement over ADO.NET
//that provides the data access in a more automated way
//Three approaches provided - 1.Model first  2.Database first 3.Code first