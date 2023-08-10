using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class Indexers1
    {
        static void Main(string[] args)
        {
            //Create an Instance of the Company class
            Company company = new Company();
            //Accessing the Name of the Employee using Integer Indexer of Company Object
            Console.WriteLine("Name of Employee with Id = 101: " + company[101]);
            Console.WriteLine("Name of Employee with Id = 105: " + company[105]);
            Console.WriteLine("Name of Employee with Id = 107: " + company[107]);

            Console.WriteLine();
            Console.WriteLine("Changing the names of employees with Id = 101,105,107");
            //Setting the Name of the Employee using Integer Indexer of Company Object
            company[101] = "Sharon";
            company[105] = "Ranita";
            company[107] = "Harshan";
            Console.WriteLine();
            //Accessing the Name of the Employee using Integer Indexer of Company Object
            Console.WriteLine("Name of Employee with Id = 101: " + company[101]);
            Console.WriteLine("Name of Employee with Id = 105: " + company[105]);
            Console.WriteLine("Name of Employee with Id = 107: " + company[107]);
            Console.ReadLine();
        }
    }
    public class Employee35
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
    }
    public class Company
    {
        //Create a varibale to hold list of Employees
        private List<Employee35> listEmployees = new List<Employee35>();
        //Through the constructor initialize the listEmployees variable
        public Company()
        {
            listEmployees.Add(new Employee35 { EmployeeId = 101, Name = "Arun", Gender = "Male", Salary = 1000 });
            listEmployees.Add(new Employee35 { EmployeeId = 102, Name = "Harita", Gender = "Female", Salary = 2000 });
            listEmployees.Add(new Employee35 { EmployeeId = 103, Name = "Vignesg", Gender = "Male", Salary = 5000 });
            listEmployees.Add(new Employee35 { EmployeeId = 104, Name = "Yamini", Gender = "Female", Salary = 4000 });
            listEmployees.Add(new Employee35 { EmployeeId = 105, Name = "Harishmitha", Gender = "Female", Salary = 3000 });
            listEmployees.Add(new Employee35 { EmployeeId = 106, Name = "Siva", Gender = "Male", Salary = 6000 });
            listEmployees.Add(new Employee35 { EmployeeId = 107, Name = "Srikanth", Gender = "Male", Salary = 8000 });
            listEmployees.Add(new Employee35 { EmployeeId = 108, Name = "Hemanth", Gender = "Male", Salary = 7000 });
            listEmployees.Add(new Employee35 { EmployeeId = 109, Name = "Darshan", Gender = "Male", Salary = 5000 });
            listEmployees.Add(new Employee35 { EmployeeId = 110, Name = "Karthi", Gender = "Male", Salary = 5000 });
        }
        // Integer Indexer
        // The indexer takes an employeeId as parameter and returns the employee name
        public string this[int employeeId]
        {
            get
            {
                //Using get accessor return the name of the Employee
                return listEmployees.FirstOrDefault(x => x.EmployeeId == employeeId).Name;
            }
            set
            {
                //Using set accessor return the name of the Employee
                listEmployees.FirstOrDefault(x => x.EmployeeId == employeeId).Name = value;
            }
        }
    }
}
