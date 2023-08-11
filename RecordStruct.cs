using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    record Item
    {
        public int ItemNo { get; set; }
        public string ItemName { get; set; }
        public double price { get; set; }
    }
    class RecordStruct
    {
        static void GetDiscount(Item c)
        {
            double discount = 0.12;
            double p = c.price;
            var r = c with { price = p - p * discount };
            //Inside the function
            Console.WriteLine("Record Inside the function...");
            Console.WriteLine($"Item No.: {r.ItemNo}  Item Name: {r.ItemName} Item Price: {r.price}");
        }
        static void Main(string[] args)
        {
            Item ob = new Item();
            ob.ItemNo = 11;
            ob.ItemName = "Fan";
            ob.price = 1600;

            //Before Discount
            Console.WriteLine("Record before calling the function...");
            Console.WriteLine($"Item No.: {ob.ItemNo}  Item Name: {ob.ItemName} Item Price: {ob.price}");
            GetDiscount(ob);
            //After Discount
            //The change is not reflected in the Main() method since the records are passed by value.
            Console.WriteLine("Record after calling the function...");
            Console.WriteLine($"Item No.: {ob.ItemNo}  Item Name: {ob.ItemName} Item Price: {ob.price}");
            Console.ReadLine();
        }
    }
}
