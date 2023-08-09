using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// In tuple, you can add elements from 1 to 8. 
    /// If you try to add elements greater than eight, 
    /// then the compiler will throw an error. 
    /// Tuples are generally used when you want to create a 
    /// data structure which contains objects with their properties 
    /// and you don’t want to create a separate type for that.
    /// </summary>
    internal class Tuples
    {
        static void Main(string[] args)
        {
            //we create a new tuple using the old and the new way.

            //old way
            var u1 = Tuple.Create("John", "Doe", "Developer");
            Console.WriteLine($"{u1.Item1} {u1.Item2} is a {u1.Item3}");

            //new way
            var u2 = ("Roger", "Moore", "Actor");
            Console.WriteLine($"{u2.Item1} {u2.Item2} is a {u2.Item3}");

            Console.WriteLine("************************");

            //We can name our tuple fields.
            var u3 = (Name: "John Doe", Age: 34);
            Console.WriteLine($"{u3.Name} is {u3.Age} years old");

            (string Name, int Age) u4 = ("Roger Roe", 55);
            Console.WriteLine($"{u4.Name} is {u4.Age} years old");

            var name = "Jane Doe";
            var age = 26;

            var u5 = (name, age);
            Console.WriteLine($"{u5.name} is {u5.age} years old");

            Console.WriteLine("************************");

            //C# tuple deconstruction
            //We can unpackage all the items in a tuple in a single operation.
            //This is called tuple deconstruction.
            var (name1, age1) = ("John Doe", 34);
            Console.WriteLine($"{name1} is {age1} years old");

            (string name2, int age2) = ("Roger Roe", 55);
            Console.WriteLine($"{name2} is {age2} years old");

            string name3;
            int age3;

            (name3, age3) = ("Jane Doe", 26);
            Console.WriteLine($"{name3} is {age3} years old");

            Console.WriteLine("************************");

            //C# nested tuples
            var data = ((1, 2, 3), (3, 4, 5), (6, 7, 8));
            Console.WriteLine(data);

            Console.WriteLine(data.Item1);
            Console.WriteLine(data.Item2);
            Console.WriteLine(data.Item1);

            Console.WriteLine(data.Item1.Item1);
            Console.WriteLine(data.Item2.Item3);

            Console.WriteLine("************************");

            //C# tuple as function parameter
            ShowInfo(("John", "Doe", "programmer"));
            ShowInfo(("Roger", "Moore", "actor"));
            ShowInfo(("Jane", "Doe", "teacher"));

            void ShowInfo((string FirstName, string LastName, string Occupation) u)
            {
                Console.WriteLine($"{u.FirstName} {u.LastName} is a {u.Occupation}");
            }

            Console.WriteLine("************************");

            //C# tuple as return value
            var user = GetUser();
            Console.WriteLine($"{user.FirstName} {user.LastName} is a {user.Occupation}");

            (string FirstName, string LastName, string Occupation) GetUser()
            {
                return ("John", "Doe", "programmer");
            }

            Console.WriteLine("************************");

            // Creating Tuple of three values  
            var book = new Tuple<string, string, double>("C# in Depth", "Jon Skeet", 100.50);
            Console.WriteLine("-----------------Book's Record---------------------");
            Console.WriteLine("Title  " + book.Item1);
            Console.WriteLine("Author " + book.Item2);
            Console.WriteLine("Price  " + book.Item3);

            Console.Read();
        }
    }
}
