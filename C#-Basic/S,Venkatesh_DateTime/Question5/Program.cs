using System;
namespace Question5;
class Progrma{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date dd/MM/yyyy hh/mm/ss tt");
        string date=Console.ReadLine();
        DateTime date1=Convert.ToDateTime(date);
        int year=date1.Year;
        System.Console.WriteLine("Enter the date dd/MM/yyyy hh/mm/ss tt");
        string date2=Console.ReadLine();
        DateTime date3=Convert.ToDateTime(date2);
        int year1=date3.Year;
        int minus=year1-year;
        for (int i = 0; i < minus; i++)
        {
            DateTime newDate=date1.AddYears(i);
            System.Console.WriteLine("{0:d}: day {1} {2} {3}",newDate,newDate.DayOfYear,newDate.Year,DateTime.IsLeapYear(newDate.Year) ?"(Leap year)":"");
        }
    }
}