using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
         System.Console.WriteLine("Enter the date dd/MM/yyyy hh/mm/ss tt");
        string date=Console.ReadLine();
        DateTime date1=Convert.ToDateTime(date);
        System.Console.WriteLine(date1.DayOfWeek);
    }
}