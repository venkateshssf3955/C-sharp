using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" enter the date .this format dd/MM/yyyy hh:mm:ss");
        string date=Console.ReadLine();
        DateTime dateTime=Convert.ToDateTime(date);
        System.Console.WriteLine(dateTime.ToString("dddd MMMMM,yyyy"));
        System.Console.WriteLine(dateTime.ToString( "dd/MM/yyyy hh:mm:ss tt"));
        System.Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
        System.Console.WriteLine(dateTime.ToString("hh:mm:ss"));
    }
}