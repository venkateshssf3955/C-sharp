using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Food
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Food"))
            {
                System.Console.WriteLine("creating folder");
                Directory.CreateDirectory("Food");

            }
            if(!File.Exists("Food/CustomerRegistration.csv"))
            {
                System.Console.WriteLine("Creating customer details file");
                File.Create("Food/CustomerRegistration.csv");
            }
            if(!File.Exists("Food/FoodDetails.csv"))
            {
                System.Console.WriteLine("creating food details file");
                File.Create("Food/FoodDetails.csv");
            }
             if(!File.Exists("Food/OrderDetails.csv"))
            {
                System.Console.WriteLine("creating order details file");
                File.Create("Food/Orderdetails.csv");
            }
             if(!File.Exists("Food/BookingDetails.csv"))
            {
                System.Console.WriteLine("creating order details file");
                File.Create("Food/BookingDetails.csv");
            }

        }

        public static void ReadFiles()
        {
            string[] userFile=File.ReadAllLines("Food/CustomerRegistration.csv");
            foreach (string item in userFile)
            {
                CustomerRegistration customer =new CustomerRegistration(item);   
                Operation.list.Add(customer);   
             }

            string[] foodFile=File.ReadAllLines("Food/FoodDetails.csv") ;
            foreach (string item in foodFile)
            {
                FoodDetails food=new FoodDetails(item);
                Operation.list1.Add(food);
            }
            string[] bookingfile=File.ReadAllLines("Food/BookingDetails.csv");
            foreach (string item in bookingfile)
            {
                BookingDetails book=new BookingDetails(item);
                Operation.list3.Add(book);
            }
            string[] orderfile=File.ReadAllLines("Food/OrderDetails.csv");
            foreach (string item in orderfile)
            {
                OrderDetails order=new OrderDetails(item);
                Operation.list2.Add(order);
            }


        }


        public static void WriteFiles()
        {
            
        }

    }
}