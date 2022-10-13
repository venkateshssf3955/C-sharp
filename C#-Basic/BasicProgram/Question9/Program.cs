using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the kilometer:");
        int kilometer=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("enter the seconds:");
        int seconds=Convert.ToInt32(Console.ReadLine());
        int distanceTravelled=kilometer*seconds*5/18;
        System.Console.WriteLine("Distance travelled "+distanceTravelled);
    }
}