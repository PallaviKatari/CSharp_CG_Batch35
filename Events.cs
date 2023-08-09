using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    /// <summary>
    /// An event is a notification sent by an object to signal the occurrence of an action. 
    /// Events in .NET follow the observer design pattern.
    /// The class who raises events is called Publisher, 
    /// and the class who receives the notification is called Subscriber.
    /// There can be multiple subscribers of a single event. 
    /// Typically, a publisher raises an event when some action occurred. 
    /// The subscribers, who are interested in getting a notification when an action occurred,
    /// should register with an event and handle it.
    /// In C#, an event is an encapsulated delegate. 
    /// It is dependent on the delegate. 
    /// The delegate defines the signature for the event handler method 
    /// of the subscriber class.
    /// </summary>

    //OrderEventArgs - Publisher 
    class OrderEventArgs : EventArgs
    {
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    //Order - Subscriber
    class Order
    {
        public event EventHandler<OrderEventArgs> OnCreated;

        int count = 0;

        public void Create(string email, string phone, int amount)
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
            Console.WriteLine($"Sent an email to {e.Email}");
        }
    }

    class SMS
    {
        public static void Send(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Sent an SMS to {e.Phone}");
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
                Console.WriteLine("Enter mail id");
                mail = Console.ReadLine();
                Console.WriteLine("Enter phone number");
                phone = Console.ReadLine();
                Console.WriteLine("Enter amount");
                amount = Convert.ToInt32(Console.ReadLine());
                order.Create(mail, phone, amount);
            }
            Console.ReadLine();
        }
    }
}
