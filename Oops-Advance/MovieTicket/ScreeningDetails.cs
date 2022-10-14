using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class ScreeningDetails
    {   
        /// <summary>
        /// it's the property of screening Details
        /// </summary>
        /// <value></value>
        public string MovieId { get; set; }
        public string TheatreId { get; set; }
        
        /// <summary>
        /// it's a remaining seats
        /// </summary>
        /// <value></value>
        public int NoOfSeatsAvailable  { get; set; }

        public double  TicketPrice { get; set; }

        public ScreeningDetails(string movieId,string theatreId,int noOfSeatsAvailable,double ticketPrice )
        {
            MovieId=movieId;
            TheatreId=theatreId;
            NoOfSeatsAvailable=noOfSeatsAvailable;
            TicketPrice=ticketPrice;
        }

        public ScreeningDetails(string data)
        {
            string[] values=data.Split(",");
            MovieId=values[0];
            TheatreId=values[1];
            NoOfSeatsAvailable=int.Parse(values[2]);
            TicketPrice=double.Parse(values[3]);
        }

    }
}