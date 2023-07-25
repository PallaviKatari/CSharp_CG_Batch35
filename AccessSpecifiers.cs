using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// public,private,internal,[protected, internal protected]-inheritance(child class)
    /// OOPS - Class,Object,Abstraction,Encapsulation,Inheritance,Polymorphism
    /// </summary>
    internal class AccessSpecifiers
    {
        private int _count = 0;

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }

        }
        public AccessSpecifiers()
        {
            Console.WriteLine(_count);
        }
    }
    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            AccessSpecifiers accessSpecifiers = new AccessSpecifiers();
            accessSpecifiers.Count = 0;
            Console.WriteLine(accessSpecifiers.Count);
            Console.ReadLine();
            
        }
    }
}
