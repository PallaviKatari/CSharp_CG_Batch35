using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    interface IInterface1
    {
        string Name { get; set; }
    }
    interface IInterface2 
    {
        void Method();
    }
    interface IInterface3
    {
        void Method1();
    }
    interface IInterface4
    {
        void Method1();
    }
    public class Derived:IInterface1, IInterface2, IInterface3, IInterface4,IDisposable
    {
        public string Name { get; set; }
        public void Method()
        {
            Console.WriteLine("I am from Interface2");
        }
        void IInterface3.Method1()
        {
            Console.WriteLine("I am from Interface3");
        }
        void IInterface4.Method1()
        {
            Console.WriteLine("I am from Interface4");
        }
        /// <summary>
        /// Files,Databases,API,Services etc
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine("I am a Dispose method");
        }
    }
    internal class InterfaceDemo
    {
        static void Main(string[] args)
        {
            IInterface3 i3;
            i3=new Derived();
            i3.Method1();
            IDisposable id;
            id=new Derived();
            id.Dispose();
        }
    }
}

//Destructors in C# - Finalize(),Dispose()
//~InterfaceDemo(){} - Finalize() - CLR - Garbage Collection - END
//Running - File f; 
