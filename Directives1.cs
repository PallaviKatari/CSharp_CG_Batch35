#define CSHARP
#undef JAVA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class Directives1
    {
        static void Main(string[] args)
        {
#if (!JAVA)
#pragma warning disable
#warning JAVA Symbol is undefined in Directives1.cs in line 2
#warning JAVA Symbol is undefined in Directives1.cs in line 1
#warning JAVA Symbol is undefined 
#warning JAVA Symbol is undefined in Directives1.cs

            {
                #region Display
                Console.WriteLine("CSHARP AND JAVA");
                Console.WriteLine("CSHARP AND JAVA");
                Console.WriteLine("CSHARP AND JAVA");
                Console.WriteLine("CSHARP AND JAVA");
                Console.WriteLine("CSHARP AND JAVA");
                #endregion
            }
            Console.ReadLine();
#endif        
        }

        public void LineDirective()
        {
#line 50 "Sample.cs"
            int a = 100;
            Console.ReadLine();
        }
    }

}

