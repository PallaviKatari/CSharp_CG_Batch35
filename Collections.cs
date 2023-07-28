using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// Collections - Dynamic memory allocation - Stack,Queue,List
    /// using System.Collections.Generic;
    /// using System.Collections;
    /// using System.Collections.Concurrent;
    /// Arrays - Static memory
    /// </summary>
    internal class Collections
    {
        /// <summary>
        /// ArrayList
        /// </summary>
        public static void ArrayList()
        {
            ArrayList arr = new ArrayList();
            arr.Add(null);
            arr.Add(100);
            arr.Add("John");
            arr.Add(36000.00);
            arr.Remove("John");
            arr.Insert(1, "Welcome");
            arr.RemoveAt(2);

            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }

        }

        public static void List()
        {
            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }
        }

        public static void sortedList()
        {
            SortedList<int, string> keyValuePairs = new SortedList<int, string>();
            keyValuePairs.Add(1, "Harita");
            keyValuePairs.Add(2, "Yamini");
            keyValuePairs.Add(3, "Vignesh");
            keyValuePairs.Add(1, "Sivabharath");
            foreach (var a in keyValuePairs)
            {
                Console.WriteLine(a);
            }

        }

        public static void Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            foreach (var a in stack)
            {
                Console.WriteLine(a);
            }
            stack.Pop();
            foreach (var a in stack)
            {
                Console.WriteLine(a);
            }

        }

        public static void Dictionary()
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "Arun");
            keyValuePairs.Add(2, "Srikanth");
            keyValuePairs.Add(3, "Hemanth");
            keyValuePairs.Add(4, "Darshan");
            foreach (var a in keyValuePairs)
            {
                Console.WriteLine(a);
            }
            //Console.WriteLine($"Is this key present in a Dictionary:{keyValuePairs[5]}");
        }

        public static void hashtable()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "John");
            ht.Add(2, 100);
            ht.Add(3, 36.54);
            ICollection collection = ht.Keys;
            foreach (var a in collection)
            {
                Console.WriteLine(a);
            }
            ICollection values = ht.Values;
            foreach (var a in values)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine($"Is this key present in a hashtable:{ht[3]}");

        }

        static void Dictionary1()
        {
            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();

            //Adding elements to the Hash table using key value pair
            hashtable.Add("EId", 1001); //Here key is Eid and value is 1001
            hashtable.Add("Name", "James"); //Here key is Name and value is James
            hashtable.Add("Salary", 3500); //Here key is Salary and value is 3500
            hashtable.Add("Location", "Mumbai"); //Here key is Location and value is Mumbai
            hashtable.Add("EmailID", "a@a.com"); //Here key is EmailID and value is a@a.com

            //Printing the keys and their values using foreach loop
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

            Console.WriteLine("\nPrinting Hashtable using Keys");
            //I want to print the Location by using the Location key
            Console.WriteLine("Location : " + hashtable["Location"]);

            //I want to print the Email ID by using the EmailID key
            Console.WriteLine("Emaild ID : " + hashtable["EmailID"]);

            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            ArrayList();
            List();
            sortedList();
            Stack();
            Dictionary();
            hashtable();
            Dictionary1();
            Console.ReadLine();

        }


    }
}
