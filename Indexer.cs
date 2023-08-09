using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// An indexer allows us to access instances of a class using an index just like an array.
    /// </summary>
    internal class Indexer // Indexer i=new Indexer -> i[0] = "John"
    {
        // declare an array to store elements  
        private string[] studentName = new string[10];

        // define an indexer
        public string this[int index] // i[0]
        {
            get
            {
                // return value of stored at studentName array  
                return studentName[index]; //John
            }

            set
            {
                // assigns value to studentName  
                studentName[index] = value; //studentName[0] = "John"
            }
        }

        public static void Main()
        {
            // create instance of Program class 
            Indexer obj = new Indexer();

            int[] ints = new int[10];
            ints[0] = 10;
            Console.WriteLine("First element in ints: " + ints[0]);

            // insert values in obj[] using indexer i.e index position
            obj[0] = "Harry";
            obj[1] = "Ron";
            obj[2] = "Hermoine";

            Console.WriteLine("First element in obj: " + obj[0]); //Harry
            Console.WriteLine("Second element in obj: " + obj[1]);
            Console.WriteLine("Third element in obj: " + obj[2]);
            Console.WriteLine("************************");
            GenericIndexer.ExampleIndexer();
            Console.Read();
        }
    }

    class EmployeeInfo<T>
    {
        // declare an array to store elements  
        private T[] employee = new T[50];

        // define an indexer, 
        // T indicates return type of indexer is generic 
        public T this[int index]
        {
            get
            {
                // return value of stored at studentName array  
                return employee[index];
            }

            set
            {
                // assigns value to studentName  
                employee[index] = value;
            }

        }
        
    }
    class GenericIndexer
    {
        public static void ExampleIndexer()
        {
            // create instance of EmployeeInfo class of int type  
            EmployeeInfo<int> Id = new EmployeeInfo<int>();

            // insert integer values in Id[] using indexer i.e index position
            Id[0] = 3;
            Id[1] = 23;
            Id[2] = 10;

            Console.WriteLine("First element in Id object: " + Id[0]);

            // create instance of EmployeeInfo class of string type 
            EmployeeInfo<string> Name = new EmployeeInfo<string>();

            // insert string values in Name[] using indexer i.e index position
            Name[0] = "Harry";
            Name[1] = "Ron";
            Name[2] = "Hermoine";

            Console.WriteLine("First element in Name object: " + Name[0]);
        }
    }
}