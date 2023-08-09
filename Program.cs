//namespace - collection of classes

using System;

namespace Batch35
{
    /// <summary>
    /// Basics of C#
    /// internal - access specifier - default access specifier for the class - within the current assembly
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// ctor - double tab
        /// Contructor Overloading - Differ in Method signature
        /// </summary>
        public Program()
        {
            //DATATYPES - VALUE,REFERENCE
            //VALUE TYPES - int,float,double,bool
            //REFERENCE TYPES - Class,interface,delegates
            int a = 10;
            char c = 'a';
            double d = 10.5;
            string name = "John";
            bool valid=false;
            //Display the value directly
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(name);
            Console.WriteLine(valid);
            //Display - concat operator
            Console.WriteLine("Integer Value is: " + a);
            //Display - using string interpolation
            Console.WriteLine("Character Value is: {1},Integer Value is: {0}", a, c);
            //Display - using string interpolation - prefix of $
            Console.WriteLine($"Double Value is:{d}, String Value is: {name}");
            //Display - using Verbatim Strings, Escape Sequence characters
            Console.WriteLine("\\\\CG-VAK\\\\BATCH 35");
            Console.WriteLine(@"\\CG-VAK\\BATCH 35");
        }
        public void DisplayDetails()
        {
            int eid;
            string ename;
            Console.WriteLine("Employee Details");
            eid=Convert.ToInt32(Console.ReadLine());
            ename = Console.ReadLine();
            Console.WriteLine($"{ename}'s id is {eid}");    

        }
        /// <summary>
        /// svm - double tab
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program program = new Program();
            program.DisplayDetails();
            //Class.Method
            Console.WriteLine("Welcome to C#");
            Console.ReadLine();
        }
    }
}
