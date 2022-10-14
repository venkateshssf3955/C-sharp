using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class TheatreDetails
    {

        /// <summary>
        /// it's a field of a]theatre deatils auto increament;
        /// </summary>
        private static int s_theatreId=300;
        public string TheatreId { get;  }
        public string  TheatreName { get; set; }

        /// <summary>
        /// it's string value .it's refers the theatre current location;
        /// </summary>
        /// <value></value>
        public string TheatreLocation { get; set; }

        public TheatreDetails(string theatreName,string theatreLocation)
        {
            s_theatreId++;
            TheatreId="TID"+s_theatreId;
            TheatreName=theatreName;
            TheatreLocation=theatreLocation;

        }

        public TheatreDetails(string data)
        {
            string[] values=data.Split(",");
            s_theatreId=int.Parse(values[0].Remove(0,3));
            TheatreId=values[0];
            TheatreName=values[1];
            TheatreLocation=values[2];
        }
    }
}