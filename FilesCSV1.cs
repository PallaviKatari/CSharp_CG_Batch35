using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Batch35
{
    internal class Details
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }

        //public Details(int id, string name, double salary, double bonus)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.salary = salary;
        //    this.bonus = bonus;
        //}

        static void Csv(List<Details> trainee)
        {
            string file = @"E:\Book.csv";
            string comma = ",";
            StringBuilder output = new StringBuilder();

            string[] head = new string[] { "Id", "Name", "Salary", "Bonus" };
            output.AppendLine(string.Join(comma, head));

            foreach (Details d in trainee)
            {
                d.Bonus = d.Salary * 0.1;
                string newLine = string.Join(comma, d.Id.ToString(), d.Name, d.Salary, d.Bonus.ToString());
                output.AppendLine(newLine);
            }

            try
            {
                File.WriteAllText(file, output.ToString());
                Console.WriteLine("Data written to CSV successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Content couldn't be added to the CSV file.");
            }
        }


        public static void Main(string[] args)
        {
            //Details[] trainee = {
            //    new Details(101, "harita", 200000, 0),
            //    new Details(102, "ranita", 400000, 0)
            //};

            List<Details> trainee = new List<Details>()
            {
             new Details {Id = 101 , Name = "harita" ,Salary = 200000 , Bonus = 0 }
            };


            Csv(trainee);

            //string csvBookContent = File.ReadAllText(@"E:\Book.csv");

            var reader = new StreamReader(@"E:\Book.csv");

            var conf = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
                TrimOptions = TrimOptions.Trim,
                MissingFieldFound = null,
                HeaderValidated = null
            };

            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var recods = csv.GetRecords<Details>();

            foreach (var r in recods)
            {
                Console.WriteLine($"{r.Id,-15}{r.Name,-10}{r.Salary,15}{r.Bonus,15}");
                Console.WriteLine("helo");
            }


            Console.ReadLine();
        }
    }
}
