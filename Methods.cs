using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// STATIC METHODS
    /// INSTANCE METHODS
    /// </summary>
    internal class Methods
    {
        public void instanceMethod()
        {
            Console.WriteLine("I am an instance method");
        }
        public static void staticMethod() 
        {
            Console.WriteLine("I am a static method");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Methods Class");
            Methods methods = new Methods();
            methods.instanceMethod();
            staticMethod();
            Methods1 methods1 = new Methods1();
            methods1.instanceMethod1();
            Methods1.staticMethod1();
            Console.ReadLine();

        }
    }

    internal class Methods1
    {
        public void instanceMethod1()
        {
            Console.WriteLine("I am an instance method1");
        }
        public static void staticMethod1()
        {
            Console.WriteLine("I am a static method1");

        }

    }
}
