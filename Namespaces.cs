using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class Namespaces
    {
        static void Main(string[] args)
        {
            Name1.Class1 class1 = new Name1.Class1();
            Name2.Class2 class2 = new Name2.Class2();
            Name3.Name33.Class3 class3=new Name3.Name33.Class3();
            Console.ReadLine();
        }
    }
}

namespace Name1
{
    public class Class1
    {
        public Class1()
        {
            Console.WriteLine("NameSpace 1");    
        }
    }
}

namespace Name2
{
    public class Class2
    {
        public Class2()
        {
            Console.WriteLine("NameSpace 2");
        }
    }
}

namespace Name3
{
    namespace Name33
    {
        public class Class3
        {
            public Class3()
            {
                Console.WriteLine("NameSpace 3");
            }
        }
    }
}
