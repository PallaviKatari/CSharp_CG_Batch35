using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// STRUCTURES - Small applications,no inheritance(no protected access specifier)
    /// Classes - Larger applications - All OOPS concepts
    /// </summary>
    struct TraineeDetails
    {
        public int Id;
        public string Name;
        public string Designation;

        public void GetDetails()
        {
            Console.WriteLine("Enter Trainee Details");
            Id=Convert.ToInt32(Console.ReadLine());
            Name=Console.ReadLine();
            Designation=Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"{Name}'s id is {Id} from {Designation} department");
        }
    }

    internal class classStruct
    {
        static void Main(string[] args)
        {
            TraineeDetails details = new TraineeDetails();
            details.GetDetails();
            details.DisplayDetails();
            Console.ReadLine();
        }
    }
}
