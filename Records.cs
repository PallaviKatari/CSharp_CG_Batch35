using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using static Batch35.Records;

namespace Batch35
{
    /// <summary>
    /// Class
    /// </summary>
    public class ClassPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsStudent { get; set; }
    }
    /// <summary>
    /// This is a small bug in Visual Studio 2019 that hasn't been fixed yet. 
    /// To solve the init error, you need to add a dummy class named IsExternalInit 
    /// with the namespace System.Runtime.CompilerServices anywhere in your project. 
    /// namespace System.Runtime.CompilerServices
    /// {
    ///     internal static class IsExternalInit { }
    /// }
    /// OR in csproj file change to net5.0
    /// <PropertyGroup>
    /// <OutputType>Exe</OutputType>
    /// <TargetFramework>net5.0</TargetFramework>
    /// </PropertyGroup>
    /// </summary>
    public class ClassPerson1
    {
        public string Name { get; init; }
        public int Age { get; init; }
        public bool IsStudent { get; init; }
    }

    /// <summary>
    /// Record
    /// Records are the new data type introduced in 2021 with C# 9 and .NET Core 5.
    /// Records are similar to classes. There is a difference in the way it saves data.
    /// Records seem to be very useful when we want to ignore duplicated data or records.
    /// 8 things about Records in C# you probably didn't know:
    /// 1- Records are immutable
    /// 2- Records implement equality
    /// 3- Records can be cloned or updated using ‘with’
    /// 4- Records can be structs and classes
    /// 5- Records are actually not immutable
    /// 6- Records can have subtypes
    /// 7- Records can be abstract
    /// 8- Record can be sealed
    /// </summary>
    public record RecordPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsStudent { get; set; }
    }

    internal class Records
    {
        static void Main(string[] args)
        {
            //Example1Class();
            //WriteLine("****************************");
            //Example1Record();
            //WriteLine("****************************");
            //Example2Init();
            //WriteLine("****************************");
            //Example3Clone();
            //WriteLine("****************************");
            Example4Struct();
            ReadLine();

        }

        /// <summary>
        /// 2- Records implement equality
        /// The object identifier is different when we use class, 
        /// even all the properties of class have the same value. 
        /// But in record it is not like this, we even created 2 instance and as properties are the same, 
        /// records are  pointing to the same identification. 
        /// This is the main difference between record and class. 
        /// Record is best here for in memory management in this case.
        /// So depending on our need/requirement, we need to make a decision
        /// as to whether we need to use class or record.
        /// Both are best in their own place.
        /// </summary>
        /// Example 1 - CLASS VS RECORDS - MEMORY MANAGEMENT
        public static void Example1Class()
        {
            WriteLine("Class usage");
            ClassPerson classPersonA = new ClassPerson
            {
                Name = "John",
                Age = 25,
                IsStudent = true
            };
            WriteLine($"classPersonA Name: {classPersonA.Name}");
            WriteLine($"classPersonA Age: {classPersonA.Age}");
            WriteLine($"classPersonA IsStudent: {classPersonA.IsStudent}");
            WriteLine();

            ClassPerson classPersonB = new ClassPerson
            {
                Name = "John",
                Age = 25,
                IsStudent = true
            };
            WriteLine($"classPersonB Name: {classPersonB.Name}");
            WriteLine($"classPersonB Age: {classPersonB.Age}");
            WriteLine($"classPersonB IsStudent: {classPersonB.IsStudent}");
            WriteLine();
            WriteLine($"classPersonA Object Identification Value: {classPersonA.GetHashCode()}");
            WriteLine($"classPersonB Object Identification Value: {classPersonB.GetHashCode()}");
            WriteLine($"classPersonA and classPersonB identfication are not same");

        }
        public static void Example1Record()
        {
            WriteLine("Record usage");
            RecordPerson RecordPersonA = new RecordPerson
            {
                Name = "Peter",
                Age = 20,
                IsStudent = true
            };
            WriteLine($"RecordPersonA Name: {RecordPersonA.Name}");
            WriteLine($"RecordPersonA Age: {RecordPersonA.Age}");
            WriteLine($"RecordPersonA IsStudent: {RecordPersonA.IsStudent}");
            WriteLine();

            RecordPerson RecordPersonB = new RecordPerson
            {
                Name = "Peter",
                Age = 20,
                IsStudent = true
            };
            WriteLine($"RecordPersonB Name: {RecordPersonB.Name}");
            WriteLine($"RecordPersonB Age: {RecordPersonB.Age}");
            WriteLine($"RecordPersonB IsStudent: {RecordPersonB.IsStudent}");
            WriteLine();
            WriteLine($"RecordPersonA Object Identification Value: {RecordPersonA.GetHashCode()}");
            WriteLine($"RecordPersonB Object Identification Value: {RecordPersonB.GetHashCode()}");
            WriteLine($"RecordPersonA and RecordPersonB identfication are same");

        }

        /// <summary>
        /// Init only property - Class can be initialized with default property values but cannot be modified later
        /// </summary>
        public static void Example2Init()
        {
            var c = new ClassPerson1
            {
                Name = "Peter",
                Age = 20,
                IsStudent = true
            };
            WriteLine($"Person details: Name={c.Name}, Age={c.Age}, IsStudent={c.IsStudent}");
            //1 - Records are immutable
            //c.Name = "John";
            WriteLine($"Person details: Name={c.Name}");
            ReadKey();
        }
        public record Member
        {
            public int Id { get; init; }
            public string FirstName { get; init; }
            public string LastName { get; init; }
            public string Address { get; init; }
        }

        /// <summary>
        /// 3- Records can be cloned or updated using ‘with’
        /// </summary>
        public static void Example3Clone()
        {
            var member = new Member
            {
                Id = 1,
                FirstName = "John",
                LastName = "J",
                Address = "London"
            };

            WriteLine($"{member.Id}-{member.FirstName}-{member.LastName}-{member.Address}");

            var newMember = new Member
            {
                Id = member.Id, //1
                FirstName = member.FirstName,//John
                LastName = member.LastName,//J
                Address = "Bangalore"
            };

            WriteLine($"{newMember.Id}-{newMember.FirstName}-{newMember.LastName}-{newMember.Address}");

            var member1 = new Member
            {
                Id = 2,
                FirstName = "Peter",
                LastName = "P",
                Address = "Dubai"
            };

            WriteLine($"{member1.Id}-{member1.FirstName}-{member1.LastName}-{member1.Address}");

            var newMember1 = member1 with { Address = "Chennai" };

            WriteLine($"{newMember1.Id}-{newMember1.FirstName}-{newMember1.LastName}-{newMember1.Address}");

            //5- Records are actually not immutable if we don't use init
            //newMember1.Address = "Coimbatore";

            WriteLine($"{newMember1.Address}");

        }
        /// <summary>
        /// Records - Record Class and Record Struct
        /// </summary>
        public record struct Product
        {
            public string Name { get; init; }

            public int CategoryId { get; init; }
        }

        public struct Product1
        {
            public string Name { get; init; }

            public int CategoryId { get; init; }
        }
        /// <summary>
        /// To avoid confusion between a record class and a record struct. 
        /// A record struct is a struct with all its struct properties - Value type.
        /// A record class is a class with all its class properties - Reference type.
        /// In terms of performance, structs offer performance benefits. 
        /// Using record structs is 20 times faster than a regular struct according to benchmarks.
        /// </summary>
        public static void Example4Struct()
        {
            var product1 = new Product
            {
                Name = "VideoGame",
                CategoryId = 1
            };

            //product1.Name = ""; //Error Init-only
            var newProduct = product1 with { CategoryId = 2 }; // with expression
            WriteLine(newProduct);

            var product2 = new Product
            {
                Name = "VideoGame",
                CategoryId = 1
            };

            //2- Records implement equality
            WriteLine(product1.Equals(product2)); // Returns true

            WriteLine(product1 == product2); // Returns true. Only allowed on record structs, not allowed on regular structs

            WriteLine(product1); // Will output: Product { Name= VideoGame, CategoryId = 1 } but not for a regular struct

            //Regular Struct
            var product3 = new Product1
            {
                Name = "VideoGame",
                CategoryId = 1
            };
            var product4 = new Product1
            {
                Name = "VideoGame",
                CategoryId = 1
            };

            var newProduct1 = product3 with { CategoryId = 2 }; //with works with regular struct
            WriteLine(product3.Name);
            WriteLine(newProduct1); // Will output: Product { Name= VideoGame, CategoryId = 2 } only for a record struct
            //WriteLine(product4 == product3); // == Not allowed on regular structs
        }
    }

}


