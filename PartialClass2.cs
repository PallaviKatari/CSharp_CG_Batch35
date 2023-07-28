using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    class PartialClass2
    {
    }
    public partial class Car
    {
        public void BuildEngine() { }
        public partial void InitializeCar()
        {
            string str = "Car";
            Console.WriteLine(str);
        }
    }
    public partial class Record
    {
        public void PrintRecord()
        {
            Console.WriteLine("Height:" + h);
            Console.WriteLine("Weight:" + w);
        }
    }
}
