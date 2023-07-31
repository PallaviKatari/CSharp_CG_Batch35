using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// abstract class - cannot create an instance - inherit the abstract class
    /// </summary>
    internal abstract class Abstraction
    {
        public string name;
        public int num;
        public abstract string Name { get; set; }

        public abstract int Value { get; set; }

        public abstract void Calculate(); //Declaration

        public void Display()
        {
            Console.WriteLine("Hello... I am a non-abstract method in an abstract class");
        }
    }
    internal class Addition:Abstraction
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override int Value
        {
            get
            {
                return num;
            }
            set
            {
               num = value;
            }
        }

        public override void Calculate()
        {
            Console.WriteLine($"{name} and {num+num}");
        }


    }
    internal class Sub: Abstraction
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override int Value
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }

        public override void Calculate()
        {
            Console.WriteLine($"{name} and {num - num}");
        }


    }
    public class AbstractionDemo
    {
        static void Main(string[] args)
        {
            Abstraction demo;
            demo = new Addition();
            demo.Name = "John";
            demo.Value = 10;
            demo.Calculate();
            demo=new Sub();
            demo.Name = "Peter";
            demo.Value = 20;
            demo.Calculate();
            Console.ReadLine();
            
        }
    }
}
