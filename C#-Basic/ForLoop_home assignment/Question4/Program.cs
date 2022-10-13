using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("input the number");
        int number=Convert.ToInt32(Console.ReadLine());
        for (var i = 1; i < 11; i++)
        {
            System.Console.WriteLine("15*{0}={1}",i,15*i);
        }
    }
}