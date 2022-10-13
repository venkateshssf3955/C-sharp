using System;
namespace Question1;
class program
{
    public static void Main(string[] args)
   {
    Console.WriteLine("enter your name:");
    string name=Console.ReadLine();
    Console.WriteLine("concatenation");
    Console.WriteLine("Hello " +name);
    System.Console.WriteLine("Place Holder");
    Console.WriteLine("hello {0}",name);
    System.Console.WriteLine("interpolation");
    Console.WriteLine($"Hello {name}");
   } 
}
