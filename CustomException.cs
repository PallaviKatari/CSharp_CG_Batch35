using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// STEP 1 - Create a user-defined exception class
    /// </summary>
    internal class InValidNameException : ApplicationException
    {
        public InValidNameException(string message) : base($"Invalid Name:{message} (must contain only characters)")
        { }
    }
    public class Trainee
    {
        public string Name { get; set; }
    }
    internal class CustomException
    {
        static void Main(string[] args)
        {
            Trainee t;
            try
            {
                t = new Trainee();
                t.Name = "John123";
                Validate(t);
                Console.WriteLine(t.Name);
            }
            catch (InValidNameException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Validate(Trainee trainee)
        {
            Regex regex = new Regex("[A-Z][a-z]+$");
            if (!regex.IsMatch(trainee.Name))
            {
                throw new InValidNameException(trainee.Name);
            }
        }
    }
}
