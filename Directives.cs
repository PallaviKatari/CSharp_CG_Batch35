#define version0
#define version1
#define version2
//Preprocessor Directives in C# tell the compiler to process the given information before actual 
//compilation of the program starts. It begins with a hashtag symbol (#) and since these 
//preprocessors are not statements so no semi-colon is appended at the end. The C# compiler 
//does not have a separate preprocessor, yet the directives are processed as if there was one. 
//There cannot be anything else in a line other than the preprocessor directive.

//#define	To define a Symbol
//#undef	Removes any definition of a symbol
//#if	Checks if the symbol evaluates to true
//#endif	Ends the conditional directive which began with #if
//#else	If the symbolic value of #if evaluates to false the #else directive statements are executed
//#elif	Creates a compound conditional directive which is executed if the symbolic value is true
//#error	Creates a user defined error
//#warning	Creates a user defined warning
//#line	Modifies the compiler’s default line numbering
//#region	Specifies a block of code that can be expanded or collapsed
//#endregion	Specifies the end of a region
//#pragma	Gives the compiler information for compilation of the file
//#pragma warning	Used for enabling or disabling warnings
//#pragma checksum	Creates checksums for source files

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    internal class Directives
    {
        static void Main(string[] args)
        {
            Int32 x = 0, y = 0;

            //Version 1 changes
            #region V1
#if (version1)
            {
                NumberOperationVersion1 objVer1 = new NumberOperationVersion1();
                Console.WriteLine("Enter Xvalue,Yvalue to check version compatibility with ADD and Sub Operation");

                Console.WriteLine("Enter Xvalue:");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Yvalue:");
                y = Convert.ToInt32(Console.ReadLine());
                objVer1.GetData(x, y);
                Console.WriteLine("AddOperation Result is:" + objVer1.AddOperation());
                Console.WriteLine("SubOperation is not working with this version \n\n\n\n");
            }
#endif
            #endregion V1

            //Version 2 changes
            #region V2                              

#if (version2)
            {
                NumberOperationVersion2 objVer2 = new NumberOperationVersion2();
                Console.WriteLine("Enter Xvalue,Yvalue to check version2 compatibility with ADD and Sub Operation");

                Console.WriteLine("Enter Xvalue:");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Yvalue:");
                y = Convert.ToInt32(Console.ReadLine());
                objVer2.GetData(x, y);
                Console.WriteLine("AddOperation Result is(Based on the default values version - 2 is):"+objVer2.AddOperation(10,12));
                Console.WriteLine("SubOperation Result is (Based on user input):" +
                objVer2.SubOperation());
            }
#else
                    {
                      Console.WriteLine("No Version found");
#pragma warning disable //Disables all the below warnings
#warning This is a warning 1
#line 60 "Directives.cs"
#warning No Version found Directives.cs on line 60
#pragma warning restore //Restores all the below warnings
#warning This is a warning 2

            }
#endif

            #endregion V2     

#if (!version0)
#warning Version0 is undefined
#error Version0 is undefined
#endif

            Console.ReadKey();
        }
    }

    public class NumberOperationVersion1
    {
        Int32 x, y;
        public void GetData(Int32 x, Int32 y)
        {
            this.x = x;
            this.y = y;
        }
        public Int32 AddOperation()
        {
            //Operation performed based on User input values 
            return x + y;
        }
        public Int32 SubOperation()
        {
            //Not implemented in this version1
            return 0;
        }
    }

    public class NumberOperationVersion2
    {
        Int32 x, y;
        public void GetData(Int32 x, Int32 y)
        {
            this.x = x;
            this.y = y;
        }

        public Int32 AddOperation(Int32 x, Int32 y)
        {
            //Operation performed based on default values passed from main program
            return x + y;
        }

        public Int32 SubOperation()
        {
            return x - y;
        }
    }


}

