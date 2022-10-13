using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        for (int i = 1994; i <2014; i++)        
        {
            if(DateTime.IsLeapYear(i))
            {
                DateTime currentYear=new DateTime(i,2,29);
                DateTime nextYear=currentYear.AddYears(1);
                System.Console.WriteLine($"{i} is a leap year\none year from {currentYear.ToString("MM/dd/yyyy")} to {nextYear.ToString("MM/dd/yyyy")}");
            }
        }
    }
}