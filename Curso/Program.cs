using Curso.Entities;
using Curso.Entities.Enums;
using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                ID = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}
