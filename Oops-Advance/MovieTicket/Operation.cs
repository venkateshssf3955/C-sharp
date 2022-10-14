using System;
using System.Collections.Generic;
namespace MovieTicketBooking;

public delegate void EventManager();                       //delegate declared
public static class Operation
{
    public static List<UserDetails> userList=new List<UserDetails>();
    public static List<BookingDetails> bookingList=new List<BookingDetails>();
    public  static  List<TheatreDetails> theatreList=new List<TheatreDetails>();
    public static List<MovieDetails> movieList=new List<MovieDetails>();
    public static  List<ScreeningDetails> screeningList=new List<ScreeningDetails>();
    static UserDetails currentUser=null;

    public static event EventManager eventLink=null;

    static void Subscribe()
    {
    
    eventLink+=new EventManager(Files.Create);
    eventLink+=new EventManager(Files.ReadFiles);
    eventLink+=new EventManager(Operation.MainMenu);
    eventLink+=new EventManager(Files.WriteFiles);
    

    }


   public  static void StartEvent()
     {
        Subscribe();
        eventLink();
     }
    public static void MainMenu()
    {
    
   
   // AddDefault();

    System.Console.WriteLine("welcome to the online ticket booking site");
     
    string choice="yes";
    do
    {
        System.Console.WriteLine("Please select the option:\n1.Registration\n2.Login\n3.Exit");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
                Registration();
                break;
            case 2:
                Login();
                break;
            case 3:
                System.Console.WriteLine("Exit");
                choice="no";
                break;
        }
    }while(choice=="yes");

   static void Registration()
   {
    System.Console.WriteLine("Enter your name");
    string name=Console.ReadLine();
    
    System.Console.WriteLine("Enter your age");
    int age=int.Parse(Console.ReadLine());

    System.Console.WriteLine("Enter your phone number" );
    long phoneNumber=long.Parse(Console.ReadLine());

    System.Console.WriteLine("Please enter youe wallet balance");
    double walletBalance=double.Parse(Console.ReadLine());

    PersonalDetails personal=new PersonalDetails(name,age,phoneNumber);
    UserDetails user=new UserDetails(name,age,phoneNumber,walletBalance);
    userList.Add(user);
    System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    System.Console.WriteLine("Your Userid is "+user.UserId);
    System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

   }
   System.Console.WriteLine("\n");

   static void Login()
   {
    System.Console.WriteLine("Enter your UserId");
    string userId=Console.ReadLine();
    foreach (UserDetails user in userList)
    {
        if(userId==user.UserId)
        {
            System.Console.WriteLine("Login successfull.......");
            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            currentUser=user;
            SubMenu();

        }
    }
   }
   System.Console.WriteLine("\n");

   static void SubMenu()
   {
    string choice="yes";
    do
    {
        System.Console.WriteLine("Please select the option:\n1.Ticketbooking\n2.ticket cancellation\n3.Booking history\n4.Wallet recharge\n5.Exit");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
                TicketBooking();
                break;
            case 2:
                TicketCancellation();
                break;

            case 3:
                BookingHistory();
                break;
            case 4:
                currentUser.RechargeWallet();
                break;
            case 5:
                System.Console.WriteLine("Exit");
                choice="no";
                break;
        }
    }while(choice=="yes");
   }



   static void TicketBooking()
   {
    int flag=0;
    int flag1=0;
    ShowTheatre();
    System.Console.WriteLine("please enter  the theatre id");
    string theatreId=Console.ReadLine().ToUpper();
    foreach (TheatreDetails theatre in theatreList)
    {
        if(theatreId==theatre.TheatreId)
        {   
            flag1=1;
            ShowMovie();
            System.Console.WriteLine("please select the movie id");
            string movieId=Console.ReadLine().ToUpper();
            foreach (MovieDetails movie in movieList)
            {
                if(movieId==movie.MovieId)
                {
                    flag=1;
                    foreach (ScreeningDetails screen in screeningList)
                    {
                        if(theatreId==screen.TheatreId && movieId==screen.MovieId)
                        {
                            
                            System.Console.WriteLine("please enter the counts of tickets");
                            int count=int.Parse(Console.ReadLine());
                            if(count<=screen.NoOfSeatsAvailable)
                            {
                                double price=(double)count*screen.TicketPrice;
                                double total=price+price*0.18;
                                while(true)
                                {
                                    if(currentUser.WalletBalance>=total)
                                    {
                                        System.Console.WriteLine("ticket booking successfull.....");
                                        BookingDetails booked=new BookingDetails(currentUser.UserId,movieId,theatreId,count,total,BookingStatus.Booked);
                                        bookingList.Add(booked);
                                        currentUser.WalletBalance-=total;
                                        screen.NoOfSeatsAvailable-=count;
                                        break;
                                    }
                                    else
                                    {   
                                        System.Console.WriteLine("insufficient balance");
                                        currentUser.RechargeWallet();
                                    }
                                }

                            }
                        }
                    }
                    
                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("Invalid Movie id");
            }
        }
    if(flag1==0)
    {
        System.Console.WriteLine("invalid theatre id");
    }
            
    
}
    

    

   }
   static void TicketCancellation()
   {
    BookingHistory();
    System.Console.WriteLine("please Enter your booking id");
    string bookId=Console.ReadLine().ToUpper();
    foreach (BookingDetails book in bookingList)
    {
        if(bookId==book.BookingId)
        {
            book.BookingStatus=BookingStatus.Cancelled;
            foreach (ScreeningDetails item in screeningList)
            {
                if(book.MovieId==item.MovieId && book.TheatreID==item.TheatreId)
                {
                    item.NoOfSeatsAvailable=item.NoOfSeatsAvailable+book.SeatCount;
                }
            }
            System.Console.WriteLine("ticket cancelled successfully...");
            currentUser.WalletBalance+=book.TotalAmount;
        }
    }

   }

   static void BookingHistory()
   {
     foreach (BookingDetails booking in bookingList)
     {
        if(currentUser.UserId==booking.UserId)
        {
            System.Console.WriteLine($"booking id is    {booking.BookingId}");
            System.Console.WriteLine($"User id is       {booking.UserId}");
            System.Console.WriteLine($"movie id is      {booking.MovieId}");
            System.Console.WriteLine($"theatre id is    {booking.TheatreID}");
            System.Console.WriteLine($"seatcount is     {booking.SeatCount}");
            System.Console.WriteLine($"total amount     {booking.TotalAmount}");
            System.Console.WriteLine($"booking status is{booking.BookingStatus}");
            System.Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        }
     }
   }

   //static void AddDefault()
   {
    //user default data

    UserDetails user1=new UserDetails("Ravichandran",30,8599488003,1000);
    userList.Add(user1);
    UserDetails user2=new UserDetails("Baskaran",30,9857747327,2000);
    userList.Add(user2);

    //booking default data
    BookingDetails book1=new BookingDetails("UID1001","MID501","TID301",1,200,BookingStatus.Booked);
    bookingList.Add(book1);
    BookingDetails book2=new BookingDetails("UID1001","MID504","TID302"	,1,400,BookingStatus.Booked);
    bookingList.Add(book2);
    BookingDetails book3=new BookingDetails("UID1002","MID505","TID302",1,300,BookingStatus.Booked);
    bookingList.Add(book3);


    //theatre default data

    TheatreDetails theatre1=new TheatreDetails("Inox","Anna Nagar");
    theatreList.Add(theatre1);
     TheatreDetails theatre2=new TheatreDetails("EgaTheatre","Chetpet");
    theatreList.Add(theatre2);
     TheatreDetails theatre3=new TheatreDetails("Kamala","Vadapalani");
    theatreList.Add(theatre3);

    //movie default data
    MovieDetails movie1=new MovieDetails("Bagubali 2","Telugu");
    movieList.Add(movie1);
     MovieDetails movie2=new MovieDetails("PonniyinSelvan","Tamil");
    movieList.Add(movie2);
     MovieDetails movie3=new MovieDetails("Cobra","Tamil");
    movieList.Add(movie3);
     MovieDetails movie4=new MovieDetails("Vikram","Hindi(Dubbed)");
    movieList.Add(movie4);
     MovieDetails movie5=new MovieDetails("Vikram","Tamil");
    movieList.Add(movie5);
    MovieDetails movie6=new MovieDetails("Beast","English");
    movieList.Add(movie6);

    //screening default data

    ScreeningDetails screen1=new ScreeningDetails("MID501",	"TID301",200,5);
    screeningList.Add(screen1);
     ScreeningDetails screen2=new ScreeningDetails("MID502","TID301",300,2);
    screeningList.Add(screen2);
     ScreeningDetails screen3=new ScreeningDetails("MID502","TID301",300,2);
    screeningList.Add(screen3);
     ScreeningDetails screen4=new ScreeningDetails("MID501","TID302",400,11);
    screeningList.Add(screen4);
     ScreeningDetails screen5=new ScreeningDetails("MID501","TID302",400,11);
    screeningList.Add(screen5);
     ScreeningDetails screen6=new ScreeningDetails("MID504","TID302",500,2);
    screeningList.Add(screen6);
     ScreeningDetails screen7=new ScreeningDetails("MID505","TID303",100,11);
    screeningList.Add(screen7);
     ScreeningDetails screen8=new ScreeningDetails("MID502","TID303",200,20);
    screeningList.Add(screen8);
     ScreeningDetails screen9=new ScreeningDetails("MID504","TID303",350,2);
    screeningList.Add(screen9);



}


  static void ShowTheatre()
  { 
    System.Console.WriteLine("TheatreID   TheatreNmae  Location");
    foreach (TheatreDetails theatre in theatreList)
    {
        System.Console.WriteLine($" {theatre.TheatreId}  {theatre.TheatreName}  {theatre.TheatreLocation} ");
    }
  }


static void ShowMovie()
{
    System.Console.WriteLine("MovieId   MovieName  Language");
    foreach (MovieDetails movie in movieList)
    {
        System.Console.WriteLine($"{movie.MovieId}  {movie.MovieName}  {movie.Language}");
    }
}
}
}