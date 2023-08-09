using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]
namespace Batch35
{
    /// <summary>
    /// EXAMPLE 1 - [Flags]
    /// </summary>
    internal class Attributes
    {
        // Enum defined without FlagsAttribute.
        enum Colours
        {
            Red = 1,
            Blue = 2,
            Pink = 4,
            Green = 8
        }

        // Enum defined with FlagsAttribute.
        [Flags]
        enum ColoursFlags
        {
            Red = 1,
            Blue = 2,
            Pink = 4,
            Green = 8
        }

        // Main Method
        public static void Main(string[] args)
        {
            Console.WriteLine(1 | 2);
            Console.WriteLine((Colours.Red | Colours.Blue).ToString());
            //The FlagsAttribute specifies that an enumeration can be used as a set of flags.
            //This is most commonly used with bitwise operators. 
            Console.WriteLine((ColoursFlags.Red | ColoursFlags.Blue).ToString());
            Console.WriteLine("*****************************");
            MyClass.NewMethod();
            //MyClass.Example2();
            Demo.CLS();
            Console.ReadLine();
        }
    }

    /// <summary>
    /// EXAMPLE 2 - [Obsolete]
    /// </summary>
    public class MyClass
    {
        [Obsolete("Don't use OldMethod, use NewMethod instead", true)]

        public static void OldMethod()
        {
            Console.WriteLine("It is the old method");
        }
        public static void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }
        //[Obsolete("Don't use OldMethod, use NewMethod instead", true)]
        public static void Example2()
        {
            //When you try to compile the program, the compiler gives an error message stating −

            //Don't use OldMethod, use NewMethod instead
            //OldMethod();

        }

    }

    //CLSCompliantAttribute applied to entire assembly
    //In order to check whether your code is following the Common Language Specifications
    //or not in .NET Framework, first, you have to enable CLS Compliant
    public class Demo
    {

        public uint z = 10;
        // Main Method
        public static void CLS()
        {
            Console.WriteLine("CLSCompliant");
            int a = Calculate();
            int b= calculate();
            Console.WriteLine(a+b);

        }


        public static int Calculate()
        {
            int a = 10, b = 20;
            int c = a + b;
            return c;
        }
        public static int calculate()
        {
            int a = 10, b = 20;
            int c = a + b;
            return c;
        }
    }
}
