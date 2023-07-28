using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    class OrderEventArgs : EventArgs
    {
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    class Order
    {
        public event EventHandler<OrderEventArgs> OnCreated;

        int count = 0;
        
        public void Create(string email, string phone ,int amount)
        {

                if (OnCreated != null)
                {

                    Console.WriteLine("Order created");
                    Console.WriteLine($"Order ID {++count} created with amount {amount}");
                    OnCreated(this, new OrderEventArgs { Email = email, Phone = phone });
                }
        }
    }

    class Email
    {
        public static void Send(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Send an email to {e.Email}");
        }
    }

    class SMS
    {
        public static void Send(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Send an SMS to {e.Phone}");
        }
    }

    class ProgramEvents
    {
        static void Main(string[] args)
        {
            var order = new Order();

            order.OnCreated += Email.Send;
            order.OnCreated += SMS.Send;
            int orders;
            string mail;
            string phone;
            int amount;
            Console.WriteLine("Enter no of orders placed");
            orders = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < orders; i++)
            {
                Console.WriteLine("Enter customer details");
                mail = Console.ReadLine();
                phone = Console.ReadLine();
                amount = Convert.ToInt32(Console.ReadLine());
                order.Create(mail, phone, amount);
            }
            Console.ReadLine();
        }
    }
}
