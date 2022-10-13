using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        for (var i = 0; i < 4; i++)
        {
            for (var j= 0; j < i+1; j++)
            {
                Console.Write("*");
            }
            System.Console.WriteLine("\r");
        }
    }
}