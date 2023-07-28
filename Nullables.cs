using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// Value Type dataypes = cannot accept null values
    /// null values to be assigned to a value type - Nullables
    /// C# 2.0 - Nullable<int> , ?
    /// Windows Application - Database(employee - designation
    /// </summary>
    internal class Nullables
    {
        int? a = null;
        int? b = 100;
        int? c;
        int d = 200;
        Nullable<int> num = null;

        public void Example1()
        {
            c = a ?? b;
            Console.WriteLine(c);
        }

        public void Example2()
        {
            if (num.HasValue)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Null Value");
            }
        }

        public void Example3()
        {
            if (a == d)
            {
                Console.WriteLine(a);
            }
            else if(b>d)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("Cannot Compare Null with Relational Operators");
            }
        }

            static void Main(string[] args)
            {
                Nullables nullables = new Nullables();
                nullables.Example1();
                nullables.Example2();
                nullables.Example3();
                Console.ReadLine();

            }
        }
    }
