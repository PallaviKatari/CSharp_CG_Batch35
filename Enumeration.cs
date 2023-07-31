using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    enum days
    {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday = 10,
        Thursday,
        Friday,
        Saturday
    }

    enum employees
    {
        trainee,
        developer,
        tester,
        trainer,
        leads
    }

    enum Fruits { Apple, Banana, Orange, Grape }

    enum Animals { Dog, Cat, Bird, Fish }

    internal class Enumeration
    {
        static void Main(string[] args)
        {
            Enumeration enumeration = new Enumeration();
            enumeration.bonus(employees.trainee);
            enumeration.bonus(employees.developer);
            //Console.WriteLine((int)days.Sunday);

            foreach (Fruits fruit in Enum.GetValues(typeof(Fruits)))
            {
                if (fruit == 0)
                {
                    Console.WriteLine(fruit);
                }
            }

            Method();

            Console.ReadLine();
        }

        public void bonus(employees emp)
        {
            int value;
            value = (int)emp;
            if (value == 0)
            {
                Console.WriteLine("No Bonus");
            }
            else if (value == 1)
            {
                Console.WriteLine("Developer Bonus");
            }

        }

        public unsafe static void Method()
        {
            int x = 10;
            int y = 20;
            int* ptr1 = &x;
            int* ptr2 = &y;
            Console.WriteLine((int)ptr1);
            Console.WriteLine((int)ptr2);
            Console.WriteLine(*ptr1);
            Console.WriteLine(*ptr2);
            char x1 = 'a';
            char* ptr3 = &x1;
            Console.WriteLine((int)ptr3);
            Console.WriteLine(*ptr3);
            int[] array = { 10, 20, 30, 40, 50 };    // declaring array
            fixed (int* ptr = array)                 // fixed for pinning the object
                /* let us have array address in pointer */
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Value of array[{0}]={1}", i, *(ptr + i));
                    Console.WriteLine("Address of array[{0}]={1}", i, (int)(ptr + i));
                }

            int myNumber = 10;

            int* myPointer;
            int** myPointerPointer;
            myPointer = &myNumber;
            myPointerPointer = &myPointer;
            Console.WriteLine($"The value of " +
                $"{nameof(myNumber)} is {myNumber}, " +
                $"the address of {nameof(myPointer)} is {(int)myPointer}, " +
                $"and address of {nameof(myPointerPointer)} is {(int)myPointerPointer}...{(int)&myPointer}!");
        }

    }
}
