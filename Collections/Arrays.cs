using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Arrays
    {
        public static void arrays()
        {
            //int[] arr = { 1, 2, 3, 4 };
            //Console.WriteLine(arr); //System.Int32[]
            //foreach (int Number in arr)
            //{
            //    Console.WriteLine($"{Number}");
            //}
            //Console.WriteLine("\n");
            int[,] RectangleArray = new int[4, 5];
            foreach (int i in RectangleArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < RectangleArray.GetLength(0); i++)
            {
                for (int j = 0; j < RectangleArray.GetLength(1); j++)
                {
                    Console.Write(RectangleArray[i, j] + " ");
                }
            }

            //Creating An jagged array with four Rows
            int[][] arr = new int[4][];
            //Initializing each row with different column size
            //Uisng one dimensional array
            arr[0] = new int[5];
            arr[1] = new int[6];
            arr[2] = new int[4];
            arr[3] = new int[5];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                //arr[i].Length: Returns the Length of Each Row
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
            }
        }
    }
}
//int[] arr = new int[5];
//int[] A = { 1, 2, 3, 4, 5 };
//it is the syntax
//The Arrays in C# are reference types that are derived from the System.Array class.
//for loop refers to index of array whereas in foreach loop,
//the loop variable refers to the values of the array.
//if you have a string array then the loop variable must be of type string in case of the for-each loop
//var Numbers = new[] { 10, 20, 30, 40, 50 }; these are implicitely typed arrays (used var keyword here)
//int[,] matrix = new int[3, 3]; for 2d array
//int[,] A = { { 2, 5, 9 }, { 6, 9, 15 } };
//the arrays in C# are derived from the System.Array class
//which implements the IEnumerable, so we can use the for-each loop


//Collections are nothing but groups of records that can be treated as one logical unit.
//The Collections in C# are a set of predefined classes that are present in the System.Collections namespace

//Non - Generic Collection Classes are defined under the System.Collections namespace.
//contains following classes - arraylist,stack,queue,hashtable,sortedlist

//Generic Collection Classes are defined under the System.Collection.Generic namespace
//It provides a generic implementation and are type-safe
//It contains following classes -
//List<T>, Stack<T>, Queue<T>, HashSet<T>
//Dictionary<TKey, TValue>, SortedList<TKey, TValue>
//SortedSet<T>, SortedDictionary<TKey, TValue>, LinkedList<T>:

//Concurrent Collection Classes provides various threads-safe collection classes
//that are used in place of the corresponding types in the System.Collections
//and System.Collections.Generic namespaces,
//when multiple threads are accessing the collection simultaneously.
//The System.Collections.Concurrent namespace provides classes for thread-safe operations.
//these are BlockingCollection<T>, ConcurrentBag<T>, ConcurrentStack<T>, ConcurrentQueue<T>, ConcurrentDictionary<TKey, TValue>