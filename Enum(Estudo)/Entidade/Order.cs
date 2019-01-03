using System;
using System.Collections.Generic;
using System.Text;
using Enum_Estudo_.Entidade.Enum;

namespace Enum_Estudo_.Entidade
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Momenty { get; set; }
        public OrderStatus Status { get; set;}


        public override string ToString()
        {
            return Id +
                   ", " +
                   Momenty +
                   ", " +
                   Status;
        }
    }
}
