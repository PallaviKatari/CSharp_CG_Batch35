using Batch35;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Batch35.CustomBugFixingAttribute;
using System.Runtime.InteropServices;

namespace Batch35
{
    class CustomBugFixingAttribute
    {
        [AttributeUsage(AttributeTargets.Class
            | AttributeTargets.Constructor
            | AttributeTargets.Field
            | AttributeTargets.Method
            | AttributeTargets.Property, AllowMultiple = true)]

        //STEP 1 - Creation of Custom Attribute
        public class BugFixingAttribute : Attribute
        {
            private int bugno;
            private string developer;
            private string datefixed;
            public string remarks;

            public BugFixingAttribute(int BugNo, string Developer, string DateFixed)
            {
                this.bugno = BugNo;
                this.developer = Developer;
                this.datefixed = DateFixed;
            }
            public int BugNo
            {
                get
                {
                    return bugno;
                }
            }
            public string DateFixed
            {
                get
                {
                    return datefixed;
                }
            }
            public string Developer
            {
                get
                {
                    return developer;
                }
            }
            public string Marks
            {
                get
                {
                    return remarks;
                }
            }
        }


        [BugFixing(1, "John", "08 / 01 / 1986", remarks = "Return object not specified")]
        //[BugFixing(2, "Mark", "09 / 02 / 2010", remarks = "Data Type not matched")]
        public class Calculate
        {
            public double Add(double no1, double no2)
            {
                return no1 + no2;
            }
            public double Substract(double no3, double no4)
            {
                return no3 - no4;
            }
            [BugFixing(6, "John", "9 / 02 / 2010")]
            public double Multiply(double no5, double no6)
            {
                return no5 * no6;
            }
            //[BugFixing(7, "Mark", "07 / 05 / 2011")]
            public double Divide(double no7, double no8)
            {
                return no7 / no8;
            }
        }
    }

    public class EntryPoint
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            //CustomBugFixingAttribute p = new CustomBugFixingAttribute();
            double result = c.Add(10.0, 10.0);
            Console.WriteLine("The sum of two nos is : {0}", result);
            
            //REFLECTION
            Type type = typeof(Calculate);

            foreach (Object attributes in type.GetCustomAttributes(true))
            {
                BugFixingAttribute myobj = (BugFixingAttribute)attributes;
                if (null != myobj)
                {
                    Console.WriteLine("\nBug#:{0}", myobj.BugNo);
                    Console.WriteLine("Developer:{0}", myobj.Developer);
                    Console.WriteLine("Fixed Date:{0}", myobj.DateFixed);
                    Console.WriteLine("Remarks:{0}", myobj.remarks);
                }
            }

            foreach (MethodInfo method in type.GetMethods())
            {
                foreach (var attributes in method.GetCustomAttributes(true))
                {
                    BugFixingAttribute myobj = (BugFixingAttribute)attributes;
                    if (null!=myobj)
                    {
                        Console.WriteLine("\n Bug#:{0} for Method:{1}", myobj.BugNo, method.Name);
                        Console.WriteLine("Developer:{0}", myobj.Developer);
                        Console.WriteLine("Date Fixed:{0}", myobj.DateFixed);
                        Console.WriteLine("Remarks:{0}", myobj.remarks);
                    }
                   
                }
                Console.Read();
            }
            Console.Read();
        }
    }
}



