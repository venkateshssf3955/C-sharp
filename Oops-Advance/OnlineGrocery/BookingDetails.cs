using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    
    public class BookingDetails
    {
        private static int s_bookingId=3000;
        public string  BookingId { get; }
        public string CustomerId { get; set; }
        public double  TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }

        public BookingStatus BookingStatus { get; set; }

        public BookingDetails(string customerId,double totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            CustomerId=customerId;
            TotalPrice=totalPrice;
            
        }

        public BookingDetails(string data)
        {
            string[] values=data.Split(",");
            s_bookingId=int.Parse(values[0].Remove(0,3));
            BookingId=values[0];
            CustomerId=values[1];
            TotalPrice=double.Parse(values[2]);
        }

    }
}