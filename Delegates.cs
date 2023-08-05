using System;
using System.Collections.Generic;

namespace Batch35
{
    internal class Delegates
    {
        //Single cast Delegate
        // Declare Delegate
        public delegate void SampleDelegate(int a, int b);
        class MathOperations
        {
            public void Add(int a, int b)
            {
                Console.WriteLine("Add Result: {0}", a + b);
            }
            public void Subtract(int x, int y)
            {
                Console.WriteLine("Subtract Result: {0}", x - y);
            }
        }

        //Multicast Delegates
        // Declare Delegate
        public delegate void SampleDelegate1(int a, int b);
        class MathOperations1
        {
            public void Add(int a, int b)
            {
                Console.WriteLine("Add Result: {0}", a + b);
            }
            public void Subtract(int x, int y)
            {
                Console.WriteLine("Subtract Result: {0}", x - y);
            }
            public void Multiply(int x, int y)
            {
                Console.WriteLine("Multiply Result: {0}", x * y);
            }
        }

        //Pass Method as Parameter using Delegate
        //By using delegates in c#, we can pass methods as the parameter.
        public delegate void SampleDelegate2(int a, int b);
        class MathOperations2
        {
            public void Add(int a, int b)
            {
                Console.WriteLine("Add Result: {0}", a + b);
            }
            public void Subtract(int x, int y)
            {
                Console.WriteLine("Subtract Result: {0}", x - y);
            }
            public void Multiply(int x, int y)
            {
                Console.WriteLine("Multiply Result: {0}", x * y);
            }
            public static void SampleMethod(SampleDelegate2 dlgt, int a, int b)
            {
                dlgt(a, b);
            }
        }

        class DelegateDemo
        {
            public static void Example1()
            {
                //create list
                List<int> nums = new List<int>();
                //add elements to the list
                nums.Add(56);
                nums.Add(82);
                nums.Add(94);

                //list - foreach element x=>
                nums.ForEach(delegate (int num)
                {
                    Console.WriteLine(num);
                });
                //The Action (delegate function) is executed for each element in the list.
                //The body of the function is just a single statement to print the element to console.
            }

            public delegate bool isPromote(Employee emp); // -> promote(Employee emp)

            public class Employee
            {
                public int ID { get; set; }
                public string Name { get; set; }
                public int Salary { get; set; }
                public float Experience { get; set; }

                /// <summary>
                /// Iterate thro the Employee class - check the delgate ref
                /// </summary>
                /// <param name="EmployeeList">List Generic - properties from the Employee class</param>
                /// <param name="IsEligible">instance of the delegate - reference of promote method</param>
                public static void PromoteEmp(List<Employee> EmployeeList, isPromote IsEligible)
                {
                    foreach (Employee emp in EmployeeList)
                    {
                        if (IsEligible(emp))//logic condition  
                        {
                            Console.WriteLine(emp.Name + " Promoted");
                        }
                        else
                        {
                            Console.WriteLine(emp.Name + " Not Promoted");

                        }
                    }
                }

                public static bool promote(Employee emp)
                {
                    if (emp.Experience >= 5) //3
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                public static void Example2()
                {
                    List<Employee> empl = new List<Employee>();
                    empl.Add(new Employee() { ID = 101, Name = "John", Salary = 35000, Experience = 3 });
                    empl.Add(new Employee() { ID = 102, Name = "Peter", Salary = 30000, Experience = 5 });
                    empl.Add(new Employee() { ID = 103, Name = "Roger", Salary = 38000, Experience = 8 });
                    empl.Add(new Employee() { ID = 104, Name = "Sam", Salary = 32000, Experience = 2 });

                    isPromote pro = new isPromote(promote);
                    Employee.PromoteEmp(empl, pro);
                }
            }
        }

        /// <summary>
        /// C# - Func Delegate
        /// <summary>
        class FuncDelegate
        {
            //C# includes built-in generic delegate types Func and Action,
            //so that you don't need to define custom delegates manually in most cases.
            //Func is a generic delegate included in the System namespace.
            //It has zero or more input parameters and one out parameter.
            //The last parameter is considered as an out parameter.
            //The Func delegate that takes one input parameter and one out parameter
            //is defined in the System namespace
            static int Sum(int x, int y)
            {
                return x + y;
            }

            public static void Example1()
            {
                Func<int, int, int> add = Sum;

                int result = add(10, 10);

                Console.WriteLine(result);
            }
            /// <summary>
            /// A Func delegate type can include 0 to 16 input parameters of different types. 
            /// However, it must include an out parameter for the result. 
            /// For example, the following Func delegate doesn't have any input parameter, 
            /// and it includes only an out parameter.
            /// C# Func with an Anonymous Method
            /// You can assign an anonymous method to the Func delegate by using the delegate keyword.
            /// </summary>
            public static void Example2()
            {
                Func<int> getRandomNumber = delegate ()
                {
                    Random rnd = new Random();
                    return rnd.Next(1, 100);
                };
                int a = getRandomNumber();
                Console.WriteLine(a);

            }
            /// <summary>
            /// Func with Lambda Expression
            /// A Func delegate can also be used with a lambda expression
            /// </summary>
            public static void Example3()
            {
                Func<int> getRandomNumber = () => new Random().Next(1, 100);

                Func<int, int, int> Sum = (x, y) => x + y;

                Console.WriteLine(getRandomNumber());

                Console.WriteLine(Sum(10, 20));

            }
        }
        /// <summary>
        /// C# - Action Delegate
        /// </summary>
        class ActionDelegate
        {
            /// <summary>
            /// Action is a delegate type defined in the System namespace.
            /// An Action type delegate is the same as Func delegate except that the Action delegate doesn't return a value. 
            /// In other words, an Action delegate can be used with a method that has a void return type.
            /// </summary>
            /// <param name="val"></param>
            public delegate void Print(int val);

            static void ConsolePrint1(int i)
            {
                Console.WriteLine(i);
            }

            public static void ConsolePrint2(int i)
            {
                Console.WriteLine(i);
            }

            public static void Example1()
            {
                Print prnt = ConsolePrint1;
                prnt(10);
                Action<int> printActionDel = ConsolePrint2;
                //Action<int> printActionDel = new Action<int>(ConsolePrint2);
                printActionDel(10);
            }

            /// <summary>
            /// An Action delegate can take up to 16 input parameters of different types.
            /// An Anonymous method can also be assigned to an Action delegate
            /// </summary>
            public static void Example2()
            {
                Action<int> printActionDel = delegate (int i)
                {
                    Console.WriteLine(i);
                };

                printActionDel(10);
            }
            /// <summary>
            /// A Lambda expression also can be used with an Action delegate
            /// </summary>
            public static void Example3()
            {
                Action<int> printActionDel = i => Console.WriteLine(i);

                printActionDel(10);
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                //EXAMPLE 1 - SINGLE CAST DELEGATE
                Console.WriteLine("****Single Cast Delegate Example****");
                MathOperations m = new MathOperations();
                // Instantiate delegate with add method
                SampleDelegate dlgt = m.Add;
                dlgt(10, 90);
                // or
                //dlgt.Invoke(10, 90);
                // Instantiate delegate with subtract method
                dlgt = m.Subtract;
                dlgt(100, 90);
                Console.WriteLine("**********************************");

                //EXAMPLE 2 - MULTICAST DELEGATE
                Console.WriteLine("****Multicast Delegate Example****");
                MathOperations1 m1 = new MathOperations1();
                // Instantiate delegate with add method
                SampleDelegate1 dlgt1 = m1.Add;
                dlgt1 += m1.Subtract;
                dlgt1 += m1.Multiply;
                dlgt1(10, 90);
                dlgt1 -= m1.Subtract;
                dlgt1(10, 10);
                Console.WriteLine("**********************************");

                //EXAMPLE 3 - Pass Method as Parameter using Delegate
                MathOperations2 m2 = new MathOperations2();
                MathOperations2.SampleMethod(m2.Add, 10, 90); //dlgt(10,90)
                MathOperations2.SampleMethod(m2.Subtract, 100, 90);//dlgt(100,90)
                MathOperations2.SampleMethod(m2.Multiply, 10, 10);//dlgt(10,10)
                Console.WriteLine("**********************************");

                //EXAMPLE 4 - DELEGATE DEMOS
                DelegateDemo.Example1();
                Console.WriteLine("**********************************");
                //Nested Class
                DelegateDemo.Employee.Example2();
                Console.WriteLine("**********************************");

                //EXAMPLE 5 - FUNC DELEGATE
                //Func is built-in delegate type.
                //Func delegate type must return a value.
                //Func delegate type can have zero to 16 input parameters.
                //Func delegate does not allow ref and out parameters.
                //Func delegate type can be used with an anonymous method or lambda expression.
                FuncDelegate.Example1();
                FuncDelegate.Example2();
                FuncDelegate.Example3();
                Console.WriteLine("**********************************");

                //EXAMPLE 6 - ACTION DELEGATE
                //Action delegate is same as func delegate except that it does not return anything.
                //Return type must be void.
                //Action delegate can have 0 to 16 input parameters.
                //Action delegate can be used with anonymous methods or lambda expressions.

                //Advantages of Action and Func Delegates
                //Easy and quick to define delegates.
                //Makes code short.
                //Compatible type throughout the application.
                ActionDelegate.Example1();
                ActionDelegate.Example2();
                ActionDelegate.Example3();

                Console.ReadLine();
            }
        }
    }
}



