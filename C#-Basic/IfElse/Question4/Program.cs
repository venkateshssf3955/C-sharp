using System;
namespace Question;
class program{
    public static void Main(string[] args)
    {
     Console.WriteLine("enter the radius:");
     int radius=Convert.ToInt32(Console.ReadLine());
     System.Console.WriteLine("enter the height");
     int height=Convert.ToInt32(Console.ReadLine());
     float Volume=(float)(3.14*radius*radius*height);
     System.Console.WriteLine("Voloume "+Volume);
    }
}