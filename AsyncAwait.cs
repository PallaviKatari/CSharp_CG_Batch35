using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// C# and .NET Framework (4.5 & Core) supports asynchronous programming 
    /// using some native functions, classes, and reserved keywords.
    /// </summary>
    public class AsyncAwait
    {
        public static async Task Main()
        {
            Console.WriteLine("Main Method Started......");
            //FirstMethod();
            //FirstMethod1();
            //SecondMethod();
            Task<int> result = LongProcess(); //10
            ShortProcess();
            var val = await result; // wait until we get the return value
            Console.WriteLine("Result: {0}", val);
            FuncTask();
            Console.WriteLine("Main Method End");
            Console.ReadKey();
        }

        //Example 1 - synchronous programming
        //public static void FirstMethod()
        //{
        //    Console.WriteLine("First Method Started......");
        //    Thread.Sleep(TimeSpan.FromSeconds(10));
        //    Console.WriteLine("\n");
        //    Console.WriteLine("First Method End");
        //}
        //public static void FirstMethod1()
        //{
        //    Console.WriteLine("First Method 1 Started......");
        //    //Thread.Sleep(TimeSpan.FromSeconds(10));
        //    Console.WriteLine("\n");
        //    Console.WriteLine("First Method 1 End");
        //}

        //Example 2 - Asynchronous programming - async await Task
        /// <summary>
        /// In asynchronous programming, the code gets executed in a thread 
        /// without having to wait for an I/O-bound or long-running task to finish.
        /// </summary>
        public async static void FirstMethod()
        {
            Console.WriteLine("First Method Started......");
            //Thread.Sleep(TimeSpan.FromSeconds(10));
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\n");
            Console.WriteLine("First Method End");
        }

        //Example 3 - Asynchronous programming - async await Task(in Wait())
        public async static void SecondMethod()
        {
            Console.WriteLine("Second Method Started......");
            //Wait();
            await Wait();
            Console.WriteLine("Second Method End");
        }
        private static async Task Wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\n10 Seconds wait Completed in Some Method 1 \n");
        }

        /// <summary>
        /// Example 4 - Asynchronous programming - async await Task returning a value
        /// Use async along with await and Task if the async method returns a value back to the calling code.
        /// </summary>
        /// <returns></returns>

        static async Task<int> LongProcess() // Main()
        {
            Console.WriteLine("LongProcess Started");

            await Task.Delay(4000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess Completed");

            return 10;
        }

        static void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");

            //do something here

            Console.WriteLine("ShortProcess Completed");
        }

        /// <summary>
        /// Task with Func delegate
        /// </summary>
        public static async void FuncTask()
        {
            Func<int, int, Task<int>> delaySum = async (a, b) =>
            {
                await Task.Delay(100);
                return a + b;
            };
            int sum = await delaySum(10, 10);
            Console.WriteLine("Func Delegate returning a Task:{0}", sum);
        }


    }
}
