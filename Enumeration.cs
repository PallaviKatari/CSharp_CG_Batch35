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
            //Console.WriteLine((int)days.Sunday);

            foreach (Fruits fruit in Enum.GetValues(typeof(Fruits)))
            {
                if (fruit == 0)
                {
                    Console.WriteLine(fruit);
                }
            }

            Console.ReadLine();
        }

        public void bonus(employees emp)
        {
            if (emp == 0)
            {
                Console.WriteLine("No Bonus");
            }

        }

    }
}
