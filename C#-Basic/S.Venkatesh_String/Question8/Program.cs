using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the first string ");
        string str1=Console.ReadLine();
        System.Console.WriteLine("enter the position ");
        int position=int.Parse(Console.ReadLine());
        System.Console.WriteLine("enter the end position ");
        int endPosition=int.Parse(Console.ReadLine());
        string newString =str1.Substring(position,endPosition);
        System.Console.WriteLine("substring is "+newString);
        
    }
}