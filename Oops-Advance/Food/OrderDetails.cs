using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food
{
    public class OrderDetails
    {
        private static int s_orderId=100;
        public string OrderId { get; set; }
        public string  BookingId { get; set; }
        public string FoodId { get; set; }

        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }

        public OrderDetails(string bookingId,string foodId,int purchaseCount,double priceOfOrder)
        {
            OrderId="OID"+(++s_orderId);
            BookingId=bookingId;
            FoodId=foodId;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;

        }
        public OrderDetails(String item)
        {
            string[] values=item.Split(",");
            s_orderId=int.Parse(values[0].Remove(0,3));
            OrderId=values[0];
            BookingId=values[1];
            FoodId=values[2];
            PurchaseCount=int.Parse(values[3]);
            PriceOfOrder=double.Parse(values[4]);
        }


        public void ShowOrderDetails()
        {
            System.Console.WriteLine("----OrderDetails----");
            System.Console.WriteLine($"Order is           {OrderId}");
            System.Console.WriteLine($"BookingId is       {BookingId}");
            System.Console.WriteLine($"FoodId is          {FoodId}");
            System.Console.WriteLine($"Purchasecount is   {PurchaseCount}");
            System.Console.WriteLine($"PpriceOfOrder is   {PriceOfOrder}");
        }
    }
}