using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{
    public class ProductDetails
    {
        private static int s_productId=100;
        public string ProductId { get; set; }
        public string  ProductName { get; set; }

        public int QuantityAvailable { get; set; }
        public double PricePerQuantity{get;set;}

        public ProductDetails(string productName,int quantityAvailable,double pricePerQuantity)
        {
            s_productId++;
            ProductId="PID"+s_productId;
            ProductName=productName;
            QuantityAvailable=quantityAvailable;
            PricePerQuantity=pricePerQuantity;
        }
        public void  ShowProductDetails()
        {
            System.Console.WriteLine($"Product id is {ProductId}   product name {ProductName} product available {QuantityAvailable} price per Quantity {PricePerQuantity}");
        }

        public ProductDetails(string data)
        {
            string[] values=data.Split(",");
            s_productId=int.Parse(values[0].Remove(0,3));
            ProductId=values[0];
            ProductName=values[1];
            QuantityAvailable=int.Parse(values[2]);
            PricePerQuantity=double.Parse(values[3]);

        }
    }
}