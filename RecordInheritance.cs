using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    record Person1
    {
        public string pname;
        public int age;
        public Person1()
        {
            pname = "abc";
            age = 20;
        }
        public virtual void show()
        {
            Console.WriteLine("Show() method of Person record!");
            Console.WriteLine($"Name: {pname} Age: {age}");
        }
    }
    record Employee1 : Person1
    {
        public string organization;
        public Employee1()
        {
            organization = "XYZ Ltd.";
        }
        public override void show()
        {
            base.show();
            Console.WriteLine("Show() method of Employee record!");
            Console.WriteLine($"Organization: {organization}");
        }
    }
    record Student1 : Person1
    {
        public string course;
        public Student1()
        {
            course = "MBA";
        }
        public override void show()
        {
            base.show();
            Console.WriteLine("Show() method of Student record!");
            Console.WriteLine($"Course: {course}");
        }
    }
    class RecordInheritance
    {
        static void Main(string[] args)
        {
            Person1 r;
            r = new Employee1();
            r.show();

            r = new Person1();
            r.show();

            r = new Student1();
            r.show();

            Console.WriteLine("\n");
            var v = new Employee1();
            v.show();
            Console.WriteLine("\n");
            var v1 = new Student1();
            v1.show();
            Console.ReadLine();
        }
    }
}
