using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Batch35
{
    internal class ThreadLifeCycle
    {
        public static void CallToChildThread() // Running 
        {
            try
            {
                Console.WriteLine("Child thread starts");

                // do some work, like counting to 10
                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500); // Not Runnable
                    Console.WriteLine(counter);
                }

                Console.WriteLine("Child Thread Completed");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread Abort Exception");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }
        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");

            Thread childThread = new Thread(childref); // Unstarted
            childThread.Start(); // Runnable

            //stop the main thread for some time
            Thread.Sleep(1000);

            //now abort the child
            Console.WriteLine("In Main: Aborting the Child thread");

            childThread.Abort();

            Console.ReadKey();
        }
    }
}
