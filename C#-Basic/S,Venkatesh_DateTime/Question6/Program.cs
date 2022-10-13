using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date dd/MM/yyyy hh/mm/ss tt");
        string date=Console.ReadLine();
        DateTime date1=Convert.ToDateTime(date);
        DateTime date2=date1.AddDays(40);
        System.Console.WriteLine("day of date is :"+date2.DayOfWeek);
    }
}