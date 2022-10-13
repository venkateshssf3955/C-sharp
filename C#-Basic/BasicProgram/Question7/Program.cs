using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the a value:");
        int a=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("enter the b value:");
        int b=Convert.ToInt32(Console.ReadLine());
        /*int first=(int)(a*a);
        int second=(int)(b*b);
        int third=(int)(2*a*b);*/
        int c=(int) (a*a+2*a*b+b*b);
        System.Console.WriteLine(" a+b**2 is ="+c);
    }
}