using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{
    public class OrderDetails
    {
        private static int s_orderId=100;
        public string OrderId { get;  }
        public string BookingId { get; set; }

        public string ProductId { get; set; }

        public int ProductCount { get; set; }

        public double PriceOfOrder { get; set; }

        public OrderDetails(string bookingId,string productId,int productCount,double priceOfOrder)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            BookingId=bookingId;
            ProductId=productId;
            ProductCount=productCount;
            PriceOfOrder=priceOfOrder;
        }
    public OrderDetails(string data)
    {
        string[] values=data.Split(",");
        s_orderId=int.Parse(values[0].Remove(0,3));
        OrderId=values[0];
        BookingId=values[1];
        ProductId=values[2];
        ProductCount=int.Parse(values[3]);
        PriceOfOrder=double.Parse(values[4]);

    }
           
     }
}