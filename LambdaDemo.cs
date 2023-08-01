using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    class EmployeeDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
    }

    internal class LambdaExpDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expression");
            var traineeDetail = (int id, string name) =>
            {
                Console.WriteLine($"{name}'s id is {id}");
            };
            traineeDetail(100, "John");
            Console.WriteLine("***************************");

            List<EmployeeDetails> list = new List<EmployeeDetails>()
            {
                new EmployeeDetails{Id=1,Name="John",Designation="Developer"},
                new EmployeeDetails{Id=2,Name="Jamie",Designation="Designer"},
                new EmployeeDetails{Id=3,Name="Jancy",Designation="Developer"},
                new EmployeeDetails{Id=4,Name="Joanna",Designation="Designer"},
                new EmployeeDetails{Id=5,Name="Johnny",Designation="Developer"},
            };

            foreach (var item in list)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Designation);
                Console.WriteLine("***");
            }

            var list1 = list.Select(x => x.Name);
            foreach(var item in list1) 
            { 
                Console.WriteLine(item); 
            }

            var list2 = list.Select(x => x.Designation).Where(x => x.Equals("Developer"));
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
