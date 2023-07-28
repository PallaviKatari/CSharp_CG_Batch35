using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// void details(int id, string name,int mob,string addr,string des)
    /// </summary>
    internal class PassObjasPara
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string city { get; set; }
        public string designation { get; set; }

        public PassObjasPara()
        {
            id = 100;

        }

        public void Details(PassObjasPara obj)
        {
            name=obj.name; 
            age=obj.age; 
            city=obj.city;
            Console.WriteLine($"{id} - {name} - aged {age} is from {city}");    

        }

        static void Main(string[] args)
        {
            PassObjasPara passObjasPara = new PassObjasPara();
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter values");
                passObjasPara.id++;
                passObjasPara.name= Console.ReadLine();
                passObjasPara.age=Convert.ToInt32(Console.ReadLine());
                passObjasPara.city=Console.ReadLine();
                passObjasPara.Details(passObjasPara);
            }
           
            Console.ReadLine();

        }
    }
}
