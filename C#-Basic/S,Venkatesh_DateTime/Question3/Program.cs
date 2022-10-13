using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date dd/MM/yyyy hh/mm/ss tt");
        string date=Console.ReadLine();
        DateTime date1=Convert.ToDateTime(date);
        System.Console.WriteLine(date1.Year+"\n"+date1.Month+"\n"+date1.Day+"\n"+date1.Hour+"\n"+date1.Minute+"\n"+date1.Second+"\n"+date1.Millisecond);
    }
}