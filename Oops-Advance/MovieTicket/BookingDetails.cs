using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public enum BookingStatus{Default,Booked,Cancelled}
    /// <summary>
    /// its a booking details class for ticketbooking
    /// </summary>
    public class BookingDetails
    {

        /// <summary>
        /// auto increament booking id
        /// </summary>
        private static int s_bookingId=7000;
        public string  BookingId { get;  }

        /// <summary>
        /// CurrentUser Id 
        /// </summary>
        /// <value></value>
        public string  UserId { get; set; }

        /// <summary>
        /// in this property makes
        /// </summary>user Movie id
        /// <value></value>
        public string MovieId { get; set; }
        /// <summary>
        /// theatre id for the user
        /// </summary>
        /// <value></value>
        public string TheatreID { get; set; }

        /// <summary>
        /// total count of seats in the threatre
        /// </summary>
        /// <value></value>

        public int SeatCount { get; set; }
        public double  TotalAmount { get; set; }
        public BookingStatus BookingStatus{get;set;}


        public BookingDetails(string userId,string movieId,string theatreId,int seatCount,double totalAmount,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            UserId=userId;
            MovieId=movieId;
            TheatreID=theatreId;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStatus=bookingStatus;
        }

        public BookingDetails(string data)
        {
            string[] values=data.Split(",");
            s_bookingId=int.Parse(values[0].Remove(0,3));
            BookingId=values[0];
            UserId=values[1];
            MovieId=values[2];
            TheatreID=values[3];
            SeatCount=int.Parse(values[4]);
            TotalAmount=double.Parse(values[5]);
            BookingStatus=Enum.Parse<BookingStatus>(values[6],true);
        }
    }
}