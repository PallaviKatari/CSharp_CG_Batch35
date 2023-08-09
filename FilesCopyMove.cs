using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class FilesCopyMove
    {
        static void Main(string[] args)
        {
            CopyFileMethod();
            MoveFileMethod();
        }
        public static void CopyFileMethod()
        {
            string sourceFile = @"E:\Batch35.txt";
            string CopyFile = @"E:\Batch35Copy.txt";
            try
            {
                File.Copy(sourceFile, CopyFile);
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
            Console.WriteLine("File Contents Copied Successfully");
        }
        public static void MoveFileMethod()
        {
            string CopyFile = @"E:\Batch35Copy.txt";
            string MoveFile = @"E:\Batch35CopyMove.txt";
            try
            {
                File.Move(CopyFile, MoveFile);
            }
            catch (Exception e3)
            {
                Console.WriteLine(e3.Message);
            }
            Console.WriteLine("File Contents Moved Successfully");
        }
    }
}
