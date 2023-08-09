using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// In a single-threaded application, 
    /// all the logic or code present in the program will be 
    /// executed by a single thread only i.e. the Main thread.
    /// </summary>
    internal class Thread1
    {
        static void Main(string[] args)
        {
            //WITHOUT THREADS
            //Console.WriteLine("WITHOUT THREADS");
            //Method1();
            //Method2();
            //Method3();
            //Console.WriteLine("*********************************");
            //Console.WriteLine("WITH THREAD SLEEP");
            //Method4();
            //Method5();
            //Method6();
            //Console.WriteLine("*********************************");
            //Console.WriteLine("MULTI-THREADING");
            //MultiThreading();
            Console.WriteLine("*********************************");
            Console.WriteLine("MULTI-THREADING CONSOLE");
            MultiThreadingConsole();
            Console.Read();
        }
        /// <summary>
        /// WITHOUT THREADS - Method1,2,3
        /// </summary>
        static void Method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }

        static void Method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method2 :" + i);
            }
        }
        static void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
        }
        /// <summary>
        /// WITH THREAD.SLEEP Method3,4,5
        /// </summary>
        static void Method4()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method4 :" + i);
            }
        }
        static void Method5()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method5 :" + i);
                if (i == 3)
                {
                    Console.WriteLine("Performing the Database Operation Started");
                    //Sleep for 10 seconds
                    Thread.Sleep(10000);
                    Console.WriteLine("Performing the Database Operation Completed");
                }
            }
        }
        static void Method6()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method6 :" + i);
            }
        }
        /// <summary>
        /// MULTI-THREADING
        /// </summary>
        public static void MultiThreading()
        {
            Console.WriteLine("Main Thread Started");
            //Creating Threads
            Thread t1 = new Thread(Method7)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(Method8)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(Method9)
            {
                Name = "Thread3"
            };
            // Set the priority of threads
            //t3.Priority = ThreadPriority.Highest;
            //t2.Priority = ThreadPriority.Lowest;
            //t1.Priority = ThreadPriority.Lowest;
            //Executing the methods
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread Ended");
            Console.Read();
        }
        static void Method7()
        {
            Console.WriteLine("Method7 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method7 :" + i);
            }
            Console.WriteLine("Method7 Ended using " + Thread.CurrentThread.Name);
        }
        static void Method8()
        {
            Console.WriteLine("Method8 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method8 :" + i);
                if (i == 3)
                {
                    Console.WriteLine("Performing the Database Operation Started");
                    //Sleep for 10 seconds
                    Thread.Sleep(10000);
                    Console.WriteLine("Performing the Database Operation Completed");
                }
            }
            Console.WriteLine("Method8 Ended using " + Thread.CurrentThread.Name);
        }
        static void Method9()
        {
            Console.WriteLine("Method9 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method9 :" + i);
            }
            Console.WriteLine("Method9 Ended using " + Thread.CurrentThread.Name);
        }
        public static void MultiThreadingConsole()
        {
            Console.WriteLine("Main Thread Started");
            //Creating Threads
            Thread t4 = new Thread(Method10)
            {
                Name = "Thread4"
            };
            Thread t5 = new Thread(Method11)
            {
                Name = "Thread5"
            };

            //Executing the methods
            t4.Start();
            t5.Start();

            Console.WriteLine("Main Thread Ended");
            Console.Read();
        }
        static void Method10()
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Method10 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method10 :" + i);
            }
            Console.WriteLine("Method10 Ended using " + Thread.CurrentThread.Name);
        }
        static void Method11()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Method11 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method11 :" + i);
            }
            Console.WriteLine("Method11 Ended using " + Thread.CurrentThread.Name);
        }

    }
}
