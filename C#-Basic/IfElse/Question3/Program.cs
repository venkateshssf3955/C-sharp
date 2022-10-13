using System;
namespace Question;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the celsius");
        double celsius=Convert.ToDouble(Console.ReadLine());
        double kelvin=celsius+273.15;
        double fahrenheit=(celsius*9/5)+32;
        System.Console.WriteLine("Kelvin "+kelvin);
        System.Console.WriteLine("fahrenheit "+fahrenheit);

    }
    
}