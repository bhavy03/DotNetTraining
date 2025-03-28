using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Generics
    {
        public static void generics()
        {
            List<int> integerList = new List<int>();
            integerList.Add(11);
            integerList.Add(22);
            foreach (int item in integerList)
            {
                Console.Write($"{item} ");
            }
            HashSet<int> integerHashSet = new HashSet<int>();
            //doesn't add duplicate elements

            SortedSet<int> integerSortedSet = new SortedSet<int>();
            //stores the elements in ascending order and does not store duplicate elements.

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            //It works as same as the Hashtable except that it operates on a type object,
            //It stores values on the basis of keys. It contains unique keys only.
            foreach (KeyValuePair<int, string> kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            //here var will work but object won't because
            //since a Dictionary<TKey, TValue> implements IEnumerable<KeyValuePair<TKey, TValue>>, not IEnumerable<object>.

            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();

            //bool IsEqual = ClsCalculator.AreEqual<double>(10.5, 20.5);

            //MyGenericClass<int> integerGenericClass = new MyGenericClass<int>(10);
            //int val = integerGenericClass.GenericMethod(200);
            //Console.WriteLine(val);

            //SomeClass s = new SomeClass();
            //s.GenericMethod<int, int>(10, 20);
            //s.GenericMethod<double, string>(10.5, "Hello");
            //s.GenericMethod<string, float>("Anurag", 20.5f);
        }

        //Now this method can accept any data type
        //public static bool AreEqual(object value1, object value2)
        //{
        //    return value1 == value2;
        //}
        //not good cause poor Performance due to boxing and unboxing,
        //not type-safe first parameter string second integer

        //now it is done generically
        //public static bool AreEqual<T>(T value1, T value2)
        //{
        //    return value1.Equals(value2);
        //}

        public void GenericMethod<T1, T2>(T1 Param1, T2 Param2)
        {
            Console.WriteLine($"Parameter T1 type: {typeof(T1)}: Parameter T2 type: {typeof(T2)}");
            Console.WriteLine($"Parameter 1: {Param1} : Parameter 2: {Param2}");
        }

    }

    //MyGenericClass is a Generic Class
    //Here T specifies the Data Types of the class Members
    class MyGenericClass<T>
    {
        //Generic variable
        //The data type is generic i.e. T
        private T GenericMemberVariable;

        //Generic Constructor
        //Constructor accepts one parameter of Generic type i.e. T
        public MyGenericClass(T value)
        {
            GenericMemberVariable = value;
        }

        //Generic Method
        //Method accepts one Generic type Parameter i.e. T
        //Method return type also Generic i.e. T
        public T GenericMethod(T GenericParameter)
        {
            Console.WriteLine($"Parameter type: {typeof(T).ToString()}, Value: {GenericParameter}");
            Console.WriteLine($"Return type: {typeof(T).ToString()}, Value: {GenericMemberVariable}");
            return GenericMemberVariable;
        }

        //Generic Property
        //The data type is generic i.e. T
        public T GenericProperty { get; set; }
    }
}

//GenericTypeName<T> where T : contraint1, constraint2

//where T: struct -> The type argument must be non-nullable value types such as primitive data types
//int, double, char, bool, float, etc. The struct constraint can’t be combined with the unmanaged constraint.

//where T: class => The type argument must be a reference type.
//This constraint can be applied to any class (non-nullable), interface, delegate, or array type in C#.

//where T: new() => The type argument must be a reference type that has a public parameterless (default) constructor.

//where T: < base class name> => The type of argument must be or derive from the specified base class.

//where T: <interface name> => The type argument must be or implement the specified interface.
//Also, multiple interface constraints can be specified.

//where T: U => The type argument supplied for must be or derive from the argument supplied for U.
//In a nullable context, if U is a non-nullable reference type, T must be a non-nullable reference type.
//If U is a nullable reference type, T may be either nullable or non-nullable.