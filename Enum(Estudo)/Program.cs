using System;
using Enum_Estudo_.Entidade;
using Enum_Estudo_.Entidade.Enum;

namespace Enum_Estudo_
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Momenty = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //converção string 
            string txt = OrderStatus.PendingPayment.ToString();
            //converção para tipo enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
            
            Console.ReadLine();



        }
    }
}
