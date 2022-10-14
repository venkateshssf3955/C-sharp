using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food
{
    public enum BookingStatus{Default,Booked,Cancelled,Initiated}
    public class BookingDetails
    {
        private static int s_bookingId=3000;

        public string BookingId { get; set; }
        public string RegistrationId{ get; set; }
        public double  TotalPrice { get; set; }
        public DateTime  DateOfBooking{ get; set; }
        public  BookingStatus BookingStatus { get; set; }

        public BookingDetails(string registrationId,double totalPrice,DateTime dobook,BookingStatus bookingStatus)
        {
            BookingId="BID"+(++s_bookingId);
            RegistrationId=registrationId;
            TotalPrice=totalPrice;
            DateOfBooking=dobook;
            BookingStatus=bookingStatus;
        }

        public BookingDetails(string item)
        {
            string[] values=item.Split(",");
            s_bookingId=int.Parse(values[0].Remove(0,3));
            BookingId=values[0];
            RegistrationId=values[1];
            TotalPrice=double .Parse(values[2]);
            DateOfBooking=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            BookingStatus=Enum.Parse<BookingStatus>(values[4]);
        }
    }
}