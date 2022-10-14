using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MovieTicketBooking
{
    public class MovieDetails
    {
        private static int s_movieId=500;
        public string MovieId { get;}

        public string MovieName { get; set; }

        public string Language { get; set; }

        public MovieDetails(string movieName,string language )
        {
            s_movieId++;
            MovieId="MID"+s_movieId;
            MovieName=movieName;
            Language=language;
        }

        public MovieDetails(string data)
        {
            string[] values=data.Split(",");
            s_movieId=int.Parse(values[0].Remove(0,3));
            MovieId=values[0];
            MovieName=values[1];
            Language=values[2];

        }
    }
}