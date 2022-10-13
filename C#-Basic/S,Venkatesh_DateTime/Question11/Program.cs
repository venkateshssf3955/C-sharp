using System;
namespace Question11;
class Program{
    public static void Main(string[] args)
    {
        DateTime date=DateTime.Today;
        System.Console.WriteLine("months are: ");
        for (var i = 0; i < 12; i++)
        {
            System.Console.WriteLine(date.ToString("MMMM"));
            date=date.AddMonths(1);
        }
    }
}