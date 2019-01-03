using System;
using System.Collections.Generic;
using System.Text;


namespace Enum_Estudo_.Entidade.Enum
{
    enum OrderStatus : int//o order status e derivado de um tipo int
    {
        PendingPayment = 0,
        processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
