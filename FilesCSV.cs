using CsvHelper;
using System.Globalization;
using System.IO;
using System;
using CsvHelper.Configuration;
using System.Text;

namespace Batch35
{
    internal class FilesCSV
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader(@"E:\data.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            // read CSV file
            var records = csv.GetRecords<dynamic>();

            // output
            foreach (var r in records)
            {
                Console.WriteLine($"{r.FirstName,-10}{r.LastName,-5}{r.Date,-15}{r.Day,-15}");
            }
            Console.WriteLine("************************************");
            ReadCsv();
            Console.WriteLine("************************************");
            WriteCsv();
            Console.WriteLine("************************************");
            Culture();
            Console.WriteLine("************************************");
            CultureTypesDemo();

        }
#nullable enable
        class EmployeeDetails
        {
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public DateTime? Date { get; set; }
            public string? Day { get; set; }
        }
        /// <summary>
        /// Reading a CSV file into a collection of specific objects
        /// </summary>
        static void ReadCsv()
        {
            using var reader = new StreamReader(@"E:\data.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            // Read CSV file
            var employees = csv.GetRecords<EmployeeDetails>();


            // Output
            foreach (var e in employees)
            {
                Console.WriteLine($"{e.FirstName,-15}{e.LastName,-10}{e.Date,15}{e.Day,15}");
            }

        }

        public class Student
        {
            public int StudentId;
            public string FirstName;
            public string LastName;
            public string Dob;

            public Student(int StudentId, string FirstName, string LastName, string Dob)
            {
                this.StudentId = StudentId;
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Dob = Dob;
            }
        }

        static void WriteCsv()
        {
            // Create an array with a list of students
            Student[] students =
            {
        new Student(1, "John", "Smith", "03/04/1990"),
        new Student(2, "Adam", "Van Houten", "07/07/1991"),
        new Student(3, "Joey", "Richardson", "01/02/1992"),
        new Student(4, "Matt", "Adams", "05/05/1992"),
        new Student(5, "Jake", "Smith", "04/04/1994"),
    };

            String file = @"E:\Student.csv";
            String separator = ",";
            StringBuilder output = new StringBuilder();
            String[] headings = { "StudentID", "First Name", "Last Name", "Date Of Birth" };
            output.AppendLine(string.Join(separator, headings));

            foreach (Student student in students)
            {
                //String[] newLine = { student.StudentId.ToString(), student.FirstName, student.LastName, student.Dob };
                //output.AppendLine(string.Join(separator, newLine));
                string newLine = string.Format("{0}, {1}, {2}, {3}", student.StudentId.ToString(), student.FirstName, student.LastName, student.Dob);
                output.AppendLine(string.Join(separator, newLine));
            }
            try
            {
                File.AppendAllText(file, output.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Data could not be written to the CSV file.");
                return;
            }
            Console.WriteLine("The data has been successfully saved to the CSV file");

        }

        static void Culture()
        {
            // Persist the date and time data.
            StreamWriter sw = new StreamWriter(@"E:\data1.csv");

            // Create a DateTime value.
            DateTime dtIn = DateTime.Now;
            // Retrieve a CultureInfo object.
            CultureInfo invC = CultureInfo.InvariantCulture;

            // Convert the date to a string and write it to a file.
            //d is short date
            sw.WriteLine(dtIn.ToString("f", invC));
            sw.Close();

            // Restore the date and time data.
            StreamReader sr = new StreamReader(@"E:\data1.csv");
            string input;
            while ((input = sr.ReadLine()) != null)
            {
                Console.WriteLine("Stored data: {0}\n", input);

                // Parse the stored string.
                DateTime dtOut = DateTime.Parse(input, invC, DateTimeStyles.RoundtripKind);

                // Create a French (France) CultureInfo object.
                CultureInfo frFr = new CultureInfo("fr-FR");
                // Displays the date formatted for the "fr-FR" culture.
                Console.WriteLine("Date formatted for the {0} culture: {1}",
                                  frFr.Name, dtOut.ToString("f", frFr));

                // Creates a German (Germany) CultureInfo object.
                CultureInfo deDe = new CultureInfo("de-De");
                // Displays the date formatted for the "de-DE" culture.
                Console.WriteLine("Date formatted for {0} culture: {1}",
                                  deDe.Name, dtOut.ToString("f", deDe));

                // Creates a Spanish (Spain) CultureInfo object.
                CultureInfo es = new CultureInfo("es-ES");
                // Displays the date formatted for the "es-ES" culture.
                Console.WriteLine("Date formatted for {0} culture: {1}",
                                  es.Name, dtOut.ToString("f", es));

            }
            sr.Close();
        }

        static void CultureTypesDemo()
        {
            // Get and enumerate all cultures.
            var allCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (var ci in allCultures)
            {
                // Display the name of each culture.
                Console.Write($"{ci.EnglishName} ({ci.Name}): ");
                // Indicate the culture type.
                if (ci.CultureTypes.HasFlag(CultureTypes.NeutralCultures))
                    Console.Write(" NeutralCulture");
                if (ci.CultureTypes.HasFlag(CultureTypes.SpecificCultures))
                    Console.Write(" SpecificCulture");
                Console.WriteLine();
            }
        }
    }
}



