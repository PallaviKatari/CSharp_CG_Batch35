using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// Polymorphism - Overloading - add(int a),add(int a ,int b),add(float a,float b),add(double a,double b)
    /// add(T a ,T b),add(T a ,T1 b)
    /// Generic Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class Generics<T>
    {
        /// <summary>
        /// Generic Constructor
        /// </summary>
        /// <param name="id"></param>
        public Generics(T id) 
        {
            Console.WriteLine("ID is:{0}", id);
             
        }
        /// <summary>
        /// Generic Method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sno"></param>
        public void Details<T>(T sno)
        {
            Console.WriteLine("SNO is:{0}", sno);
        }
    }

    internal class Generics1<T,T1>
    {
        /// <summary>
        /// Generic Constructor
        /// </summary>
        /// <param name="id"></param>
        public Generics1(T id)
        {
            Console.WriteLine("ID is:{0}", id);

        }
   
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <param name="name"></param>
        public void Details(T1 name)
        {
            Console.WriteLine("Name is:{0}", name);
        }
    }


    public class GenericsMain
    {
        static void Main(string[] args)
        {
            Generics<int> generics = new Generics<int>(100);
            Generics<string> generics1 = new Generics<string>("E001");
            Generics1<int, string> generics2 = new Generics1<int, string>(100);
            generics.Details(1100);
            generics1.Details("S1100");
            generics2.Details("John");
            Console.WriteLine("*********************************");
            GenericsConcepts.Gen<string> gen=new GenericsConcepts.Gen<string>("John");
            GenericsConcepts.Gen<int> gen1 = new GenericsConcepts.Gen<int>(100);
            Console.WriteLine(gen1.Details(404));
            Console.WriteLine(gen.add(4));
            Console.ReadLine();

        }
    }
}

namespace GenericsConcepts
{
    /// <summary>
    /// Generic Class - What is this Generic? - <T> - For - class,constructor,method,parameter,property etc
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Gen<T>
    {
        /// <summary>
        /// generic constructor with 1 parameter
        /// </summary>
        /// <param name="id"></param>
        public Gen(T id)
        {
            Console.WriteLine(id);
        }
        /// <summary>
        /// Non-generic constructor with a parameter
        /// </summary>
        /// <param name="name"></param>
        public Gen(string name)
        {
            Console.WriteLine(name);               
        }
        /// <summary>
        /// Instance method with an int return type
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int add(int a)
        {
            return a + a;
        }
        /// <summary>
        /// Instance method with a generic return type
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public T Details(T msg)
        {
            return msg;
        }

    }
}
