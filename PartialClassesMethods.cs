using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    class PartialClassesMethods
    {
    }
    public partial class Record
    {
        private int h;
        private int w;
        public Record(int h, int w)
        {
            this.h = h;
            this.w = w;
        }
    }
    public partial class Car
    {
        public partial void InitializeCar();
        public void BuildRim() { }
        public void BuildWheels() { }
    }
    class Partial
    {
        static void Main(string[] args)
        {
            Record myRecord = new Record(10, 15);
            myRecord.PrintRecord();
            Car c = new Car();
            c.InitializeCar();
            Console.ReadLine();
        }
    }
}
