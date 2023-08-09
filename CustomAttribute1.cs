using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    // Creating a custom class from Attribute class
    class CustomAttributeDemo : Attribute
    {
        // private variables declaration
        private string name;
        private string company;
        //parameterized class CustomAttribute constuctor
        public CustomAttributeDemo(string name, string company)
        {
            this.name = name;
            this.company = company;
        }
        // method to display the fields by using reflection class
        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("All the Methods of the class {0} are", classType.Name); //Employer,EmployeeA
            //methods of the class for store all the attribute values
            MethodInfo[] methods = classType.GetMethods(); //getEmployeeID(),getName()
            //looping through method attribute values by using for loop
            for (int i = 0; i < methods.GetLength(0); i++)
            {
                //create the array to recieve all the custom attribute values
                object[] attributesArray = methods[i].GetCustomAttributes(true);
                // foreach loop to read the values through all attributes of the method
                foreach (Attribute item in attributesArray)
                {
                    if (item is CustomAttributeDemo)
                    {
                        //display the custom attribute values
                        CustomAttributeDemo attributeObject = (CustomAttributeDemo)item;
                        Console.WriteLine("{0} - {1}, {2} ", methods[i].Name,
                        attributeObject.name, attributeObject.company);
                    }
                }
            }
        }
    }
    //Employer class to create employer fields
    class Employer
    {
        //employer fields declaration
        int employeeID;
        string name;
        //Parameterized Employer class constructor
        public Employer(int eID, string name)
        {
            this.employeeID = eID;
            this.name = name;
        }
        // Applying the custom attribute for CustomAttributeDemo for the  getId method
        [CustomAttributeDemo("Accessor Values", "Generates employee ID")]
        public int getEmployeeID()
        {
            return employeeID;
        }
        // Applying the custom attribute to CustomAttributeDemo for the getName method
        [CustomAttributeDemo("Accessor Values", "Generates employee Name")]
        public string getName()
        {
            return name;
        }
    }
    //create employee class
    class EmployeeA
    {
        //Declaring variables of Employee
        int employeeID;
        string name;
        //Parameterized Employee constructor
        public EmployeeA(int eID, string name)
        {
            this.employeeID = eID;
            this.name = name;
        }
        // Applying the custom attribute CustomAttributeDemo for the getEmployeeID method
        [CustomAttributeDemo("Values", "Displays employee ID")]
        public int getEmployeeID()
        {
            return employeeID;
        }
        // Applying the custom attribute CustomAttributeDemo for the getName method
        [CustomAttributeDemo("Values", "Displays employee Name")]
        public string getName()
        {
            return name;
        }
    }
    //create a class for display the output
    public class CustomAttribute1
    {
        // main method for the application
        public static void Main(string[] args)
        {
            //calling static method for display typeOf employer class
            CustomAttributeDemo.AttributeDisplay(typeof(Employer));
            Console.WriteLine();
            //calling static method for display typeOf employeeA class
            CustomAttributeDemo.AttributeDisplay(typeof(EmployeeA));
            Console.ReadLine();
        }
    }
}

