using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class StringDemo
    {
        public void stringDemo()
        {
            //String - immutable - cannot be changed
            string name = "John";
            Console.WriteLine(name);

            char[] chars = { 'a', 'b', 'c' };
            Console.WriteLine(chars);

            String s=new String(chars);
            Console.WriteLine(s);

            string s1=new string(chars);
            Console.WriteLine(s1);

            char[] chars1 = { 'a', 'b', 'c', 'd', 'e' };

            foreach(char c in chars1)
            {
                Console.WriteLine(c);   
            }
        }

        public void stringDemo2()
        {
            //mutable
            StringBuilder sb = new StringBuilder("Welcome");
            Console.WriteLine(sb.ToString());
            sb.Append(" Trainees");
            Console.WriteLine(sb.ToString());
            sb.Insert(8, "to StringBuilder Concept....");
            Console.WriteLine(sb.ToString());
            sb.Remove(8,2);
            Console.WriteLine(sb.ToString());

        }
        static void Main(string[] args)
        {
            StringDemo stringDemo = new StringDemo();
            stringDemo.stringDemo();
            stringDemo.stringDemo2();
            Console.ReadLine();
        }
    }
}
