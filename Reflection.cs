using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class Reflection
    {
        static void Main(string[] args)
        {
            Type t = typeof(String);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.BaseType);
            Console.WriteLine(t.IsClass);
            Console.WriteLine(t.IsEnum);
            Console.WriteLine(t.IsInterface);
            Console.WriteLine(t.Assembly);
            Console.WriteLine("Constructors of {0} type...", t);
            Console.WriteLine("******************************");
            ConstructorInfo[] ci = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            foreach (ConstructorInfo c in ci)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("******************************");
            MethodInfo[] mi = t.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            foreach (MethodInfo m in mi)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("******************************");
            FieldInfo[] fi = t.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);
            foreach (FieldInfo f in fi)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("******************************");
            int a = 10;
            Type type = a.GetType();
            Console.WriteLine(type);
            Console.WriteLine("******************************");
            Type files = typeof(Files1);
            MethodInfo[] mt = files.GetMethods();
            for (int i = 0; i < mt.GetLength(0); i++)
            {
                Console.WriteLine(mt[i].Name);
            }
            Console.Read();
        }
    }
}
