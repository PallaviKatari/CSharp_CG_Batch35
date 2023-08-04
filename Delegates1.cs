using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// Delegate - reference type - holds the ref of a method - Runtime
    /// Two Types - Single-cast, Multi-cast
    /// </summary>

    //Delegate Declaration
    public delegate void Delegate1(int id, string name);

    internal class Delegates1
    {
        public void TraineeDetails(int tid,string tname)
        {
            Console.WriteLine($"{tname}'s id is {tid}");
        }
        public void ProjectDetails(int tid,string tname)
        {
            Console.WriteLine($"{tname}-{tid} is moved to client project");
        }
        public void AppraisalDetails(int tid, string tname)
        {
            Console.WriteLine($"{tname}-{tid} is eligible for appraisal");
        }
        static void Main(string[] args)
        {
            //instance of the class
            Delegates1 classinstance = new Delegates1();
            classinstance.TraineeDetails(100, "John");
            //instance for the delegate - Delegate1
            Delegate1 delegateinstance = classinstance.TraineeDetails;
            delegateinstance += classinstance.ProjectDetails;
            delegateinstance += classinstance.AppraisalDetails;
            delegateinstance(200, "Peter");
            //delegateinstance -= classinstance.ProjectDetails;
            delegateinstance(300, "Sam");
        }
    }
}
