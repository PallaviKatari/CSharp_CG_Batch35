using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class Pointers
    {
        static void Main(string[] args)
        {
            Example1();
            Example2();
        }

        public unsafe static void Example1()
        {
            int num = 10;
            int* ptr1 = &num;
            Console.WriteLine("Value of num:{0}", num);
            Console.WriteLine("Address of num:{0}", (int)ptr1);
        }

        public static void Example2()
        {
            unsafe
            {
                int[] num = { 1, 2, 3 };
                fixed (int* ptr = num)
                    for (int i = 0; i < num.Length; i++)
                    {
                        Console.WriteLine($"Element Value {i + 1}:{*ptr + i}");
                        Console.WriteLine($"Element Address {i + 1}:{(int)ptr + i}");
                    }
            }
        }
    }
}
