using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class Files1
    {
        public static void write()
        {
            FileInfo fileInfo = new FileInfo(@"E:\Batch35.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            try
            {
                streamWriter.WriteLine("Welcome to Files Concept in C#");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamWriter.Close();
                fileStream.Close();
            }
        }
        public static void read()
        {
            FileInfo fileInfo = new FileInfo(@"E:\Batch35.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader streamReader = new StreamReader(fileStream);
            try
            {
                string data = streamReader.ReadToEnd();
                Console.WriteLine(data);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamReader.Close();
                fileStream.Close();
            }
        }
        public static void append()
        {
            FileInfo fileInfo = new FileInfo(@"E:\Batch35.txt");
            FileStream fileStream = fileInfo.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            try
            {
                streamWriter.WriteLine("I am an appended content");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamWriter.Close();
                fileStream.Close();
            }
        }

        public static void FileExists()
        {
            string path = @"E:\B35.txt";

            //Exists
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                using (StreamWriter sw = File.CreateText(@"E:\B35.txt"))
                {
                    sw.WriteLine("I am a Content created directly by a StreamWrite helper class");
                }
            }
            Console.WriteLine("-----------------------------------------");
        }
        public static void FilesDemo()
        {
            File.WriteAllText(@"E:\Batch35Files.txt", "I am a file created by WriteAllText Method");
            Console.WriteLine("***************************");
            string filePath = @"E:\Batch35Files.txt";
            FileInfo fileInfo = new FileInfo(filePath);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.CreationTime);
            Console.WriteLine(fileInfo.Extension);
            Console.WriteLine("***************************");
            foreach (string files in Directory.GetFiles(@"E:\"))
            {
                Console.WriteLine(files);
            }
            Console.WriteLine("***************************");
            foreach (string files in Directory.GetDirectories(@"E:\"))
            {
                Console.WriteLine(files);
            }
        }
        public static void helperWrite()
        {
            using (StreamWriter sw = File.CreateText(@"E:\HelperFile.txt"))
            {
                sw.WriteLine("I am a Content created directly by a StreamWrite helper class");
            }
        }

        static void Main(string[] args)
        {
            write();
            append();
            read();
            Console.WriteLine(" * **************************");
            FilesDemo();
            Console.WriteLine(" * **************************");
            helperWrite();
            Console.WriteLine(" * **************************");
            FileExists();

        }
    }
}
