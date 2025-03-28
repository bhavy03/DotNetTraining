using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data source
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            //LINQ Query using Query Syntax to fetch all numbers which are > 5
            var QuerySyntax = from obj in integerList //Data Source
                              where obj > 5 //Condition
                              select obj; //Selection


            //Linq query for method syntax
            var MethodSyntax = integerList.Where(obj => obj > 5).ToList();
            //Where() returns an IEnumerable<int> which is a lazy - loaded collection.
            //integerList.Where(obj => obj > 5) it has type of IEnumerable<int>
            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }

            //Mixed Syntax
            var MixedSyntax = (from obj in integerList
                               where obj > 5
                               select obj).Sum();
            


        }
    }
}

//LINQ providers translate LINQ queries into the native query language of the data source.
//Execution of Queries: The LINQ provider executes the query against the data source and returns the results.
//This execution can involve translating the query into a different format, executing it,
//and then materializing the results back into .NET objects.

//2 ways to write linq -> Query syntax, method syntax and Mixed Syntax (Query + Method)

//when to use linq
//1. querying collections like arrays, lists, or any other types that implement IEnumerable
//2. Converting Data Types - converting an array to a list or vice versa.
//A query is nothing but a set of instructions applied to a data source
//query is not responsible for what will be the output rather, it is responsible for the shape of the output.
//keep in mind is, behind the scenes, the LINQ queries written using query syntax are translated into their
//lambda expressions before they are compiled. 

//LINQ Query Syntax: Under the hood, it gets translated into Method Syntax at compile time.
//LINQ Method Syntax: (also known as Fluent Syntax or Lambda Syntax) uses extension methods
//included in the System.Linq namespace and can be chained together to perform complex queries

//IEnumerable in C# is an interface that defines one method, GetEnumerator, which returns an IEnumerator object. 
//IEnumerable is an interface that represents a sequence of objects that can be iterated over using a foreach loop.
//commonly used for read-only access to a collection.
//Provides a way to iterate a collection.

//IEnumerator provides the actual logic for iterating over a collection, one item at a time.
//It maintains the current position of the pointer (cursor) using a state machine.
//It has three primary members:
//bool MoveNext() → Moves the pointer to the next element.
//object Current → Returns the current element.
//void Reset() → Resets the pointer to the initial position (before the first element).
//List<int> numbers = new List<int>() { 10, 20, 30, 40 };
//IEnumerator<int> enumerator = numbers.GetEnumerator();
//while (enumerator.MoveNext())
//{
//    Console.WriteLine(enumerator.Current);
//}

//IQueryable
//Purpose: It is intended to query data from out-of-memory sources, like a database or web service.
//It is a powerful feature for LINQ, SQL, and Entity Framework.
//IQueryable<Student> MethodSyntax = studentList.AsQueryable().Where(std => std.Gender == "Male");
//difference between IEnumerable and IQueryable
//1. Execution Context: IEnumerable executes in the client memory, whereas IQueryable executes on the data source.
//2. Suitability: IEnumerable is suitable for LINQ to Objects and working with in-memory data.
//IQueryable is suitable for LINQ to SQL or Entity Framework to interact with databases.
//3. Performance: IQueryable can perform better for large data sets as it allows the database to optimize and filter data.

//IEnumerable<T> fetches the record from the database without applying the filter.
//But IQueryable<T> fetches the record from the database by applying the filter. 

//IEnumerable: It is defined in the System.Collections namespace.
//IQueryable: It is defined in the System.Linq namespace.

//IEnumerable: Primarily used for querying and manipulating in-memory collections,
//such as arrays, lists, and IEnumerable - compatible collections.Designed for querying data that is already in memory.
//IQueryable: Used for querying data from external data sources that may not be in memory,
//such as databases, web services, or remote data stores.Designed for querying data
//that resides outside of the application’s memory.

//Where() method is implemented as an extension method on the IEnumerable<T> interface,
//and we know List<T> implements the IEnumerable<T> interface.