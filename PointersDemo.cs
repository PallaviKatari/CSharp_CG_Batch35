using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class MainPointers
    {
        static void Main(string[] args)
        {
            string[] details = { "harita", "ranita", "savitha", "harish" };

            char char1 = 'a';
            char char2 = 'b';

            Console.WriteLine("ADDITION OF TWO MATRIXES");

            Console.WriteLine("Enter rows:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter cols:");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];
            int[,] result = new int[rows, cols];

            Console.WriteLine("Enter the elements for matrix 1");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Elements are:");

            //loop through elements
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix1[i, j] + " \t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Enter the elements for matrix 2");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Elements are:");

            //loop through elements
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix2[i, j] + " \t");
                }
                Console.WriteLine();
            }

            Addition(matrix1, matrix2, result, rows, cols);
            TraineeDetails(details);
            Swapping(char1, char2);

            Console.ReadLine();

        }

        public static unsafe void Addition(int[,] matrix1, int[,] matrix2, int[,] result, int rows, int cols)
        {
            fixed (int* p1 = matrix1, p2 = matrix2, res = result)
            {
                int* ptr1 = p1;
                int* ptr2 = p2;
                int* resPtr = res;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        *resPtr = *ptr1 + *ptr2;

                        ptr1++;
                        ptr2++;
                        resPtr++;
                    }
                }

                Console.WriteLine("Result is :");

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(result[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

            }
        }

        public unsafe static void TraineeDetails(string[] details)
        {
            fixed (string* p1 = details)
            {
                string* ptrs = p1;

                Console.WriteLine("\t");
                for (int i = 0; i < details.Length; i++)
                {
                    Console.WriteLine(details[i]);
                    Console.WriteLine((int)ptrs + i);

                    Console.WriteLine("\n");

                }
            }

        }

        public unsafe static void Swapping(char char1, char char2)
        {
            char* ptr1 = &char1;
            char* ptr2 = &char2;

            Console.WriteLine($"Strings abefore swapping: char 1 is...{char1} ...char2 is...{char2}");

            *ptr1 = Convert.ToChar(*ptr1 + *ptr2);
            *ptr2 = Convert.ToChar(*ptr1 - *ptr2);
            *ptr1 = Convert.ToChar(*ptr1 - *ptr2);

            Console.WriteLine($"Strings abefore swapping: char 1 is...{char1} ...char2 is...{char2}");
        }

    }
}

