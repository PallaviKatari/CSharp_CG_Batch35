﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class PassByOut
    {
        static void Main(string[] args)
        {
            int result=multiply(5, 5);
            Console.WriteLine(result);
            int a, b;
            Add(out a, out b);
            Console.WriteLine($"Added value of a:{a} and added value of b:{b}");
            int id = 100;
            string name = "John";
            int salary = 12000;
            int bonus;
            Details(id, name, salary, out bonus);
            Console.WriteLine($"{name}'s bonus is: {bonus}");
            Console.ReadLine();

        }

        public static int multiply(int x, int y)
        {
            Console.WriteLine("Multiplication");
            return x * y;

        }

        public static void Add(out int x, out int y)
        {
            Console.WriteLine("Addition");
            x = 10;
            y = 20;
            x += x;
            y += y;
        }

        public static void Details(int id,string name,int salary,out int bonus)
        {
            Console.WriteLine("Trainee Details");
            bonus = (int)(salary * .10);

        }
    }
}
