using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Batch35
{
    internal class Exceptions
    {

        public static void Example1()
        {
            var trainees = new List<string> { "Harita", null, "Yamini", "Vignesh", "Sivabharath",
    "Arun", "Srikanth", "Darshan", "Hemanth" };

            foreach (var letter in trainees)
            {
                int n = 0;

                try
                {
                    n = CountLtr(letter, 'a');
                    Console.WriteLine($"{letter}: {n}");
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine($"{e.Message}");
                }
            }

            int CountLtr(string name, char c)
            {
                if (name is null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                return name.Count(e => e.Equals(c));
            }
            Console.WriteLine("***********");

        }

        public static void Example2()
        {
            var trainees = new List<string> { "Harita@gmail.com", "Yamini@gmail.com", "Vignesh", "Sivabharath",
    "Arun", "Srikanth", "Darshan", "Hemanth" };
            trainees.ForEach(x => Console.WriteLine(Regex.IsMatch(x, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")));
            Console.WriteLine("***********");
        }

        public static void Example3()
        {
            var words = new List<string> {"Dog", "Cat", "Rat" };
            words.ForEach(x => Console.WriteLine(Regex.IsMatch(x, @"at") + " " + x));
            Console.WriteLine("***********");

        }

        public static void Example4()
        {
            string str = "CSharp is a modern cSharp language and CSharp is easy CSharp to learn";
            //Console.WriteLine("Match the word starting with C and ending with p");
            MatchCollection match = Regex.Matches(str, @"\b[c|C]\S*p\b");
            int count = 0;
            foreach (Match word in match)
            {
                count++;
                Console.WriteLine($"{word}");
            }
            Console.WriteLine($"Total: {count}");
            Console.WriteLine("***********");
        }

        public static void Example5()
        {
            var mobile = new List<string> { "983567287", "8745638287" };
            mobile.ForEach(x => Console.WriteLine(Regex.IsMatch(x, @"(^[0-9]{10}$)") + " " + x));
            //foreach (string m in mobile)
            //{
            //    Console.WriteLine(m);
            //    Console.WriteLine(checkMobile(m)); //False
            //}
            //Console.WriteLine("***********");
        }

        //public static bool checkMobile(string mobile)
        //{
        //    string mregexp = @"(^[0-9]{10}$)"; //983567287
        //    Regex r = new Regex(mregexp);
        //    if (r.IsMatch(mobile)) //983567287
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        static void Main(string[] args)
        {
            Example1();
            Example2();
            Example3();
            Example4();
            Example5();

        }
    }
}
