using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class CmdLineArgument
    {
        static void Main(string[] args)
        {
            //convert into integer type
            int argument1 = Convert.ToInt32(args[0]);
            Console.WriteLine("Argument in Integer Form : " + argument1);
            //convert into double type
            double argument2 = Convert.ToDouble(args[1]);
            Console.WriteLine("Argument in Double Form : " + argument2);
            Console.Read();
        }
    }
}
