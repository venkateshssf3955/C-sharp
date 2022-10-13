using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" enter the numbers");
        int input=Convert.ToInt32(Console.ReadLine());
        for (var i = 1; i < input+1; i++)
        {
            System.Console.WriteLine($"{i} and the cube of the {i} is {i*i*i}");
        }
    }
}