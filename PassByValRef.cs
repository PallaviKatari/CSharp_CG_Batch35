using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class PassByValRef
    {
        static void Main(string[] args)
        {
            PassByValRef passByValRef = new PassByValRef();
            int x = 10; // 1002
            int y = 20; // 1006
            Console.WriteLine("Value of x any y before Swap");
            Console.WriteLine($"Value of x:{x}, Value of y:{y}");
            passByValRef.Swap( ref x,ref  y );
            Console.WriteLine("Value of x any y after Swap");
            Console.WriteLine($"Value of x:{x}, Value of y:{y}");
            Console.ReadLine();

        }

        public void Swap(ref int a,ref int b) //1002 1006
        {

            Console.WriteLine("Value of a any b before Swap");
            Console.WriteLine($"Value of a:{a}, Value of b:{b}");
            int temp;
            temp= a;
            a= b;
            b= temp;
            Console.WriteLine("Value of a any b after Swap");
            Console.WriteLine($"Value of a:{a}, Value of b:{b}");
        }
    }
}
