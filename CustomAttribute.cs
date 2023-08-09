using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    // C# program to demonstrate Custom Attributes

    // AttributeUsage specifies the usage
    // of InformationAttribute
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor |
                            AttributeTargets.Method, AllowMultiple = true)]

    // InformationAttribute is a custom attribute class
    // that is derived from Attribute class
    class InformationAttribute : Attribute
    {
        public string InformationString { get; set; }
    }

    // InformationAttribute is used in student class
    [Information(InformationString = "Class")]
    public class student
    {

        private int rollno;
        private string name;

        //[Information(InformationString = "Class")]
        //public int Name { get; set; }

        [Information(InformationString = "Constructor")]
        public student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }

       [Information(InformationString = "Method")]
        public void display()
        {
            Console.WriteLine("Roll Number: {0}", rollno);
            Console.WriteLine("Name: {0}", name);
        }
    }

    // Driver Class
    public class CustomAttribute
    {

        // Main Method
        public static void Main(string[] args)
        {
            student s = new student(1001, "John Doe");
            s.display();
            Console.ReadLine();
        }
    }
}
