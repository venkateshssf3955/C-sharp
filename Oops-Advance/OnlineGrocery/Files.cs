using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace OnlineGrocery
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("OnlineGrocery"))
            {
                System.Console.WriteLine("creating directory");
                Directory.CreateDirectory("OnlineGrocery");
            }
            if(!File.Exists("OnlineGrocery/CustomerDetails.csv")){
                System.Console.WriteLine("Customer details file created");
                File.Create("OnlineGrocery/CustomerDetails.csv");
            }
            if(!File.Exists("OnlineGrocery/OrderDetails.csv"))
            {
                System.Console.WriteLine("Orderdetails file created");
                File.Create("OnlineGrocery/OrderDetails.csv");
            }
            if(!File.Exists("OnlineGrocery/ProductDetails.csv"))
            {
                File.Create("OnlineGrocery/ProductDetails.csv");
            }
            if(!File.Exists("OnlineGrocery/BookingDetails.csv"))
            {
                File.Create("OnlineGrocery/BookingDetails.csv");
            }
        }
        public static void ReadFiles()
        {
            string[] customer=File.ReadAllLines("OnlineGrocery/CustomerDetails.csv");
            foreach (string item in customer)
            {
                CustomerDetails customerFile=new CustomerDetails(item);
                Operation.customerList.Add(customerFile);
            }
            string[] product=File.ReadAllLines("OnlineGrocery/ProductDetails.csv");
            foreach (string item in product)
            {
                ProductDetails ProductFile=new ProductDetails(item);
                Operation.productList.Add(ProductFile);
            }

            string[] booking=File.ReadAllLines("OnlineGrocery/BookingDetails.csv");
            foreach (string item in booking)
            {
                BookingDetails bookingFile=new BookingDetails(item);
                Operation.bookingList.Add(bookingFile);
            }
            string [] order=File.ReadAllLines("OnlineGrocery/OrderDetails.csv");
            foreach (string item in order)
            {
                OrderDetails orderFile=new OrderDetails(item);
                Operation.orderList.Add(orderFile);
            }
        }
    
        public static void WriteFlies()
        {
            string[] customerWrite=new string[Operation.customerList.Count];
            for (int i = 0; i < Operation.customerList.Count; i++)
            {
                customerWrite[i]=Operation.customerList[i].CustomerId+","+Operation.customerList[i].Name+","+Operation.customerList[i].FatherName+","+Operation.customerList[i].Gender+","+Operation.customerList[i].MobileNumber+","+Operation.customerList[i].DOB.ToString("dd/MM/yyyy")+","+Operation.customerList[i].Mail+","+Operation.customerList[i].WalletBalance;         
            }
            File.WriteAllLines("OnlineGrocery/CustomerDetails.csv",customerWrite);


            string[] ProductWrite=new string[Operation.productList.Count];
            for (int i = 0; i < Operation.productList.Count; i++)
            {
                ProductWrite[i]=Operation.productList[i].ProductId+","+Operation.productList[i].ProductName+","+Operation.productList[i].QuantityAvailable+","+Operation.productList[i].PricePerQuantity;
            }
            File.WriteAllLines("OnlineGrocery/ProductDetails.csv",ProductWrite);

            string[] bookingWrite=new string[Operation.bookingList.Count];
            for (int i = 0; i < Operation.bookingList.Count; i++)
            {
                bookingWrite[i]=Operation.bookingList[i].BookingId+","+Operation.bookingList[i].CustomerId+","+Operation.bookingList[i].TotalPrice+","+Operation.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")+","+Operation.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("OnlineGrocery/BookingDetails.csv",bookingWrite);

            string[] orderWrite=new string[Operation.orderList.Count];
            for (int i = 0; i < Operation.orderList.Count; i++)
            {
                orderWrite[i]=Operation.orderList[i].OrderId+","+Operation.orderList[i].BookingId+","+Operation.orderList[i].ProductId+","+Operation.orderList[i].ProductCount+","+Operation.orderList[i].PriceOfOrder;
            }
            File.WriteAllLines("OnlineGrocery/OrderDetails.csv",orderWrite);


        }
    
    
    
    
    }
}