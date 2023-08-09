using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class StaticReadOnlyConst
    {
        public static void Main()
        {
            MyClass1 mc = new MyClass1(50);
            MyClass1 mc1=new MyClass1(100);
            //mc.ChangeVal(45);
            mc.Display();

            Console.WriteLine("MyClass.constvar = {0}", MyClass1.constvar);
            Console.WriteLine("MyClass.staticvar = {0}", MyClass1.staticvar);
            Console.WriteLine("mc.instancevar = {0}", mc.instancevar);
            Console.WriteLine("mc1.instancevar = {0}", mc1.instancevar);

            Console.Read();
        }
    }

    public class MyClass1
    {
        public readonly int readonlyvar1 = 10, readonlyvar2;
        public const int constvar = 20;

        //If we want a variable to have the same value throughout all instances of
        //the object then we can declare it as a static variable in our program.
        public static int staticvar;

        //instance variable
        public int instancevar;

        public MyClass1(int i)
        {
            readonlyvar1 = i;
            readonlyvar2 = i; // valid                            
            staticvar = i; // valid           
            //constvar= i;
            instancevar = i;
        }

        public void ChangeVal(int val)
        {
            //constvar= val;
            staticvar = val; // valid
        }

        public void Display()
        {
            Console.WriteLine("ReadOnly1:{0}",readonlyvar1);
            Console.WriteLine("ReadOnly2:{0}", readonlyvar2);
            Console.WriteLine("Static:{0}", staticvar);
            Console.WriteLine("Instance:{0}", instancevar);
            Console.WriteLine("Constant:{0}", constvar);
            int a;
            Console.WriteLine("Enter value of a");
            a=Convert.ToInt32(Console.ReadLine());
            //readonlyvar1 = a;
            //readonlyvar2 = a;
            staticvar = a;
            instancevar=a;
            Console.WriteLine(staticvar);
        }
    }
}

