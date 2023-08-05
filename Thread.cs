using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Batch35
{
    internal class Threads
    {
        public static void Example1()
        {
            Thread t = Thread.CurrentThread;
            //By Default, the Thread does not have any name
            //if you want then you can provide the name explicitly
            t.Name = "Main Thread";
            Console.WriteLine("Current Executing Thread Name :" + t.Name);
            Console.WriteLine("Current Executing Thread Name :" + Thread.CurrentThread.Name);
        }
        /// <summary>
        /// Creating Threads:
        /// Threads are created by extending the Thread class. 
        /// The extended Thread class then calls the Start() method to begin the child thread execution.
        /// </summary>
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Every program has a Main Thread");
            Example1();
            Console.WriteLine("*********************************");
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadLine();
        }
    }
}
