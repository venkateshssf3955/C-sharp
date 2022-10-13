using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the meter: ");
        int meter=Convert.ToInt32(Console.ReadLine());
        int centiMeter=meter*100;
        int milliMeter=centiMeter*10;
        float inch=(float)39.3*meter;
        int foot=12*meter;
        double mile=(double)0.0006213715277778*meter;
        System.Console.WriteLine($"{meter} meter is equal to {centiMeter}centiMeter ");
        System.Console.WriteLine($"{meter} meter is equal to {milliMeter} millimeter ");
        System.Console.WriteLine($"{meter} meter is equal to {inch} inch ");
        System.Console.WriteLine($"{meter} meter is equal to {foot} foot");
        System.Console.WriteLine($"{meter} meter is equal to {mile} mile");
    }

}