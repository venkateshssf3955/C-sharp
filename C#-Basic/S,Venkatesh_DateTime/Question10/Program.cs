using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date dd/MM/yyyy hh/mm/ss tt");
        string date=Console.ReadLine();
        DateTime date1=Convert.ToDateTime(date);
        DateTime yesterday=date1.AddDays(-1);
        DateTime tomorrow=date1.AddDays(1);
        System.Console.WriteLine(" yesterday {0:d}",yesterday);
        System.Console.WriteLine(" tomorrow {0:d}",tomorrow);
        
    }
}