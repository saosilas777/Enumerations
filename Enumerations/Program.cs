using System;
using Enumerations.Entities;
using Enumerations.Entities.Enums;
namespace Enumerations {
    class Program {
        static void Main(string[] args) {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);

        }
    }
}
