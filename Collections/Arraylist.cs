using Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections
{
    class Arraylist
    {
        public static void arraylist()
        {
            ArrayList arrayList = new ArrayList();
            // or
            //var arrayList = new ArrayList();
            //Adding Elements to ArrayList using object initializer syntax
            var arrayList2 = new ArrayList()
            {
                102, "Smith", "Smith", true, 15.6
            };
            Console.WriteLine(arrayList2[0]);

            //can access this but not like this had to typecast it
            //int firstElement = (int)arrayList2[0];
            //or can simply use the var keyword
            //var firsItem = arrayList1[0];
            //Console.WriteLine(firsItem.GetType());

            //this is to insert at any index
            //arrayList.Insert(0, "First Element");


            Hashtable hashtable = new Hashtable();
            hashtable.Add("EId", 1001); 
            hashtable.Add("Name", "James"); 
            hashtable.Add("Salary", 3500); 
            hashtable.Add("Location", "Mumbai"); 
            hashtable.Add("EmailID", "a@a.com");
            Console.WriteLine("Printing Hashtable using Foreach Loop");
            foreach (object obj in hashtable.Keys)
            {
                Console.WriteLine(obj + " : " + hashtable[obj]);
            }
            //Or
            //foreach (DictionaryEntry de in hashtable)
            //{
            //    Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
            //}
            //A Hashtable stores data as DictionaryEntry objects,
            //where each object has both a Key and a Value.
            Console.WriteLine("\nPrinting Hashtable using Keys");
            Console.WriteLine("Location : " + hashtable["Location"]);
            Console.WriteLine("Emaild ID : " + hashtable["EmailID"]);

            //Assigning Values to a Hashtable with Indexer
            //hashtable[key] = value;
            //hashtable[1] = "One";
            //hashtable[5] = "Five";
            //hashtable[30] = "Thirty";
            //DictionaryEntry is used with non-generic collection i.e. hashtable
            //foreach (DictionaryEntry de in hashtable)
            //{
            //    Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
            //}


            //Stack stack = new Stack();
            //stack.Push(10);
            //stack.Push("Hello");
            //stack.Push(3.14f);
            //stack.Push(true);
            //stack.Push(67.8);
            //stack.Push('A');
            //foreach (object item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Enqueue(object obj):

        }
    }
}
//ArrayList is not guaranteed to be sorted.
//capacity of an ArrayList is the number of elements the ArrayList can hold.
//arraylist has 3 constructors-  ArrayList(), ArrayList(ICollection c), ArrayList(int capacity)

//now arraylist is loosely typed
//ArrayList numberArray = new ArrayList();
//numberArray.Add(10);
//numberArray.Add(200);
////No CompileTime Error
//numberArray.Add("Pranaya");
//We Get Runtime Error, when we access the 3rd Element
//foreach (int no in numberArray)
//{
//    Console.WriteLine(no);
//}
//but not in this
//for (int i = 0; i < numberArray.Count; i++)
//{
//    Console.WriteLine(numberArray[i]);
//}
//and this
//foreach (var no in numberArray)
//{
//    Console.WriteLine(no);
//}

//arrayList1.InsertRange(2, arrayList2);
//used to insert another collection in other collection at specified index
//arrayList.Clear(); to remove all elements from arraylist
//arrayList.Contains("India") to check if it contains an element or not
//ArrayList cloneArrayList = (ArrayList)arrayList.Clone();
//this is how to clone a arraylist

//this is to copy an arraylist into an array 
//object[] arrayListCopy = new object[arrayList.Count];
//arrayList.CopyTo(arrayListCopy);
//CopyTo(Array array, int arrayIndex)
//CopyTo(int index, Array array, int arrayIndex, int count)
//we used object array cause arryalist can have various object types

//hashtable implements the IDictionary interface.
//The Hashtable accepts both null and duplicate values.
//Hashtable hashtable = new Hashtable();
//hashtable.Add(“EId”, 1001);
//hashtable.Add(“Name”, “James”);
//var cities = new Hashtable(){
//        {“UK”, “London, Manchester, Birmingham”},
//        {“USA”, “Chicago, New York, Washington”},
//        {“India”, “Mumbai, Delhi, BBSR”}
//};

//The Non-Generic SortedList Collection Class in C# represents a collection
//of key/value pairs that are sorted by the keys and are accessible by key and by index.
//By default, it sorts the key/value pairs in ascending order. 
//he key cannot be null, but the value can be null. And one more, it does not allow duplicate keys.
//Console.WriteLine($”Key: 1, Value: { sortedList[1]}”); using keys
//Console.WriteLine($”Key: 1, Index: 0, Value: { sortedList.GetByIndex(0)}”); using index
//for (int x = 0; x < sortedList.Count; x++)
//{
//    Console.WriteLine($”Key: { sortedList.GetKey(x)}, Value: { sortedList.GetByIndex(x)}”);
//}
//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine($”Key: { item.Key}, Value: { item.Value}”);
//}

//problem with non generic is 
//may occur type mismatch
//boxing and unboxing produces overhead