using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            Arrays arrays = new Arrays();
            arrays.twoDimArray();
            arrays.jaggedArray();
            Console.WriteLine("1D Array");
            int[] a = { 11, 72, 3, 14, 55 };
            //int[] b = new int[] { 1, 2 };
            //int[] c = new int[3] { 1, 2, 3 };

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*******************");

            Console.WriteLine(a.Max());
            Console.WriteLine(a.Min());
            Console.WriteLine(a.Average());
            Console.WriteLine(a.Sum());
            Array.Sort(a);
            Array.Reverse(a);
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }

        public void twoDimArray()
        {
            int[,] a = new int[,] 
            { 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 } 
            };
            Console.WriteLine("2D Array");
            for(int i=0; i<3;i++)
            {
                for(int j=0; j<3;j++)
                {
                    Console.Write(a[i,j]);
                    Console.Write("\t");
                }
                Console.WriteLine("\n");
            }
        }

        /// <summary>
        /// Jagged Array - Array within an Array
        /// </summary>
        public void jaggedArray()
        {
            int[][] arr=new int[3][]
            {
                new int[3] {1,2,3},
                new int[5] { 4, 5, 6, 7, 8 },
                new int[2] { 9, 10 }
            };
            for(int i=0; i<arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length;j++)
                {
                    Console.Write(arr[i][j]);
                    Console.Write("\t");
                }
                Console.Write("\n");
            }

        }
    }
}
