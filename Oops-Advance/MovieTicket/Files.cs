using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace  MovieTicketBooking
{
    public static class Files
    {
        public static void Create()
        {    // directory created
            if(!Directory.Exists("TicketBooking"))
            {
                System.Console.WriteLine("directory created");
                Directory.CreateDirectory("TicketBooking");
            }

            //user file
            if(!File.Exists("TicketBooking/UserDetails.csv"))
            {
                File.Create("TicketBooking/UserDetails.csv");
            }

            //booking file
             if(!File.Exists("TicketBooking/BookingDetails.csv"))
            {
                File.Create("TicketBooking/BookingDetails.csv");
            }

            //movie file
             if(!File.Exists("TicketBooking/MovieDetails.csv"))
            {
                File.Create("TicketBooking/MovieDetails.csv");
            }

            //Theatre file
             if(!File.Exists("TicketBooking/TheatreDetails.csv"))
            {
                File.Create("TicketBooking/TheatreDetails.csv");
            }

            //screening details
             if(!File.Exists("TicketBooking/ScreenDetails.csv"))
            {
                File.Create("TicketBooking/ScreenDetails.csv");
            }
        }
/// <summary>
/// read the file and transfer the particular list
/// </summary>
        public static void ReadFiles()
        {
            string[] user=File.ReadAllLines("TicketBooking/UserDetails.csv");
            foreach (string item in user)
            {
                UserDetails tempUser=new UserDetails(item);
                Operation.userList.Add(tempUser);
            }

            //booking
            string[] booking=File.ReadAllLines("TicketBooking/BookingDetails.csv");
            foreach (string item in booking)
            {
                BookingDetails tempBook=new BookingDetails(item);
                Operation.bookingList.Add(tempBook);
            }

            //movie
            string[] movie =File.ReadAllLines("TicketBooking/MovieDetails.csv");
            foreach (string item in movie)
            {
                MovieDetails tempMovie=new MovieDetails(item);
                Operation.movieList.Add(tempMovie);

            }
            //theatre
            string[] theatre=File.ReadAllLines("TicketBooking/TheatreDetails.csv");
            foreach (string item in theatre)
            {
                TheatreDetails tempTheatre=new TheatreDetails(item);
                Operation.theatreList.Add(tempTheatre);

            }

            //screening data

            string[] screen=File.ReadAllLines("TicketBooking/ScreenDetails.csv");
            foreach (string item in screen)
            {
                ScreeningDetails tempScreen=new ScreeningDetails(item);
                Operation.screeningList.Add(tempScreen);
            }


        }

        /// <summary>
        /// write the file 
        /// </summary>
    public static void WriteFiles()
    {
        string[] user=new string[Operation.userList.Count];
        for (int i = 0; i < Operation.userList.Count; i++)
        {
            user[i]=Operation.userList[i].UserId+","+Operation.userList[i].Name+","+Operation.userList[i].Age+","+Operation.userList[i].PhoneNumber+","+Operation.userList[i].WalletBalance;
        }
        File.WriteAllLines("TicketBooking/UserDetails.csv",user);

        //booking
        string[] booking=new string[Operation.bookingList.Count];
        for (int i = 0; i <Operation.bookingList.Count; i++)
        {
            booking[i]=Operation.bookingList[i].BookingId+","+Operation.bookingList[i].UserId+","+Operation.bookingList[i].MovieId+","+Operation.bookingList[i].TheatreID+","+Operation.bookingList[i].SeatCount+","+Operation.bookingList[i].TotalAmount+","+Operation.bookingList[i].BookingStatus;
        }
        File.WriteAllLines("TicketBooking/BookingDetails.csv",booking);

        //movies
        string[] movie =new string[Operation.movieList.Count];
        for (int i = 0; i < Operation.movieList.Count; i++)
        {
            movie[i]=Operation.movieList[i].MovieId+","+Operation.movieList[i].MovieName+","+Operation.movieList[i].Language;
        }
        File.WriteAllLines("TicketBooking/MovieDetails.csv",movie);

        //theatre

        string[] theatre=new string[Operation.theatreList.Count];
        for (int i = 0; i < Operation.theatreList.Count; i++)
        {
            theatre[i]=Operation.theatreList[i].TheatreId+","+Operation.theatreList[i].TheatreName+","+Operation.theatreList[i].TheatreLocation;
        }
        File.WriteAllLines("TicketBooking/TheatreDetails.csv",theatre);


        //ScreeningDetails writefile

        string[] screen=new string[Operation.screeningList.Count];
        for (int i = 0; i < Operation.screeningList.Count; i++)
        {
            screen[i]=Operation.screeningList[i].MovieId+","+Operation.screeningList[i].TheatreId+","+Operation.screeningList[i].NoOfSeatsAvailable+","+Operation.screeningList[i].TicketPrice;
        }
        File.WriteAllLines("TicketBooking/ScreenDetails.csv",screen);

    }
    

    


    }
}