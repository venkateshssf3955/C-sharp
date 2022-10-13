using System;
using System.Globalization;
namespace Question12;
class Program
{
    public static void Main(string[] args)
    {
        //DateTime date1=new DateTime(2022,10,14);
        //System.Console.WriteLine(date1.ToString("MMM"));
        System.Console.WriteLine("please Enter the  month");
        int month=int.Parse(Console.ReadLine());
        System.Console.WriteLine("please Enter the year");
        int year=int.Parse(Console.ReadLine());
        DateTimeFormatInfo tempmonth=new DateTimeFormatInfo();
        int days=DateTime.DaysInMonth(year,month);
        string month1=tempmonth.GetMonthName(month);
        System.Console.WriteLine($"the number of days in the month {month1} is {days} ");
        
        
    }
}