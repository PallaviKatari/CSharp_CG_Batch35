using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// Errors - Developer(Syntax,Logical,Compile-time), Runtime(Exception Handling)
    /// Exception Handling - try(doubtful codes),catch(error message),finally(optional)close the DB connection
    /// throw, multiple catch, Custom Exception Class
    /// EXCEPTION CLASS - BASE CLASS
    /// PRE-DEFINED-Exception class,SystemException class
    /// USER-DEFINED/CUSTOM-Exception/ApplicationException class
    /// </summary>
    internal class Exceptions1
    {
        float result = 0;
        public void DivideByZero(float a, float b)
        {
            try
            {
                result = a / b;
                if (float.IsInfinity(result))
                {
                    Console.WriteLine("Cannot Divide by 0");
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Source);
            }
            finally
            {
                Console.WriteLine("I am a finally block");
            }
        }
        public void MultipleCatch()
        {
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 1, 0, 3 };
            for(int i=0; i<numbers1.Length; i++)
            {
                try
                {
                    Console.WriteLine(numbers1[i] / numbers2[i]);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(IndexOutOfRangeException e1)
                {
                    Console.WriteLine(e1.Message);
                }
            }
        }
    }

    public class Exceptions2
    {
        static void Main(string[] args)
        {
            Exceptions1 ex = new Exceptions1();
            ex.DivideByZero(1.30f, 0);
            ex.MultipleCatch();
            Console.ReadLine();

        }
    }
}
