using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    class Trainees
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class LambdaDemo
    {
        static void Main()
        {
            // statement lambda that takes two int inputs and returns the sum 
            var resultingSum = (int a, int b) =>
            {
                int calculatedSum = a + b;
                return calculatedSum;
            };

            // find the sum of 5 and 6
            Console.WriteLine("Total sum: " + resultingSum(5, 6));

            List<Trainees> trainees = new List<Trainees>() {
            new Trainees { Name = "Arun", Age = 22 },
            new Trainees { Name = "Harita", Age = 20 },
            new Trainees { Name = "Yamini", Age = 21 },
            new Trainees { Name = "Vignesh", Age = 21 },
            new Trainees { Name = "Sivabharath", Age = 20 },
            new Trainees { Name = "Hemanth", Age = 20 },
            new Trainees { Name = "Srikanth", Age = 21 },
            new Trainees { Name = "Darshan", Age = 20 },
         };
            var names = trainees.Select(x => x.Name);
            //var names = trainees.Select(x => x.Name).Where(x=>x.Equals("Harita"));
            foreach (var name in names)
            {
                Console.WriteLine(name);

            }
            var names1 = trainees.Select(x => new { TAge = x.Age, FirstLetter = x.Name[0] }); 
            foreach (var name in names1)
            {
                Console.WriteLine(name);

            }
            var names2 = trainees.OrderByDescending(x => x.Age); ;
            foreach (var name in names2)
            {
                Console.WriteLine(string.Format("Trainee {0} is {1} years old.", name.Name, name.Age));

            }
            Console.Read();
       }
    }
}
