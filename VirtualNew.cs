using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class VirtualNew
    {
        static void Main(string[] args)
        {
            var employee = new Employee()
            {
                Name = "John Doe",
                JobTitle = "C# Developer"
            };
            Console.WriteLine(employee.Introduce());
            //The override modifier instructs the C# compiler to use the
            //last defined implementation of a method; even if you call the method on a reference of the base class.
            Person person = employee;
            Console.WriteLine(person.Introduce());

            //The new modifier instructs the C# compiler to use the method defined in the subclass. 
            //However, if you call the method on an instance of the base class, 
            //the compiler will use the method defined in the base class instead, not the one defined in the subclass.
            Person person1 = new Person()
            {
                Name = "Peter Pan"
            };
            Console.WriteLine(person1.Introduce());
        }
    }

    class Person
    {
        public string Name { get; set; }

        public virtual string Introduce() => $"Hi, I'm {Name}.";
        //public string Introduce() => $"Hi, I'm {Name}.";
    }

    class Employee : Person
    {
        public string JobTitle { get; set; }

        public override string Introduce() => $"Hi, I'm {Name}. I'm a {JobTitle}.";
        //public new string Introduce() => $"Hi, I'm {Name}. I'm a {JobTitle}.";
    }
}
