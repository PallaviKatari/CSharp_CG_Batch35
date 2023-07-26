using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// Param Array - params - when you are not sure of how many parameters are going to be passed to the function
    /// </summary>
    internal class ParamArray
    {
        static void Main(string[] args)
        {
            ParamArray paramArray = new ParamArray();
            //int size;
            //Console.WriteLine("Enter the size of the array");
            //size=Convert.ToInt32(Console.ReadLine());
            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 1,2, 3 ,4,5,6,7}; 
            paramArray.Sum();
            paramArray.Sum(b);
            Console.ReadLine();

        }

        public void Sum(params int[] elements)//3,7
        {
            int sum = 0;
            foreach (int element in elements)
            {
                sum += element;
            }
            Console.WriteLine(sum);
        }

    }
}
