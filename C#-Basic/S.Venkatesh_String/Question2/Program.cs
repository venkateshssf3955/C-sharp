using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the string ");
        string str=Console.ReadLine();
        char[] array=str.ToCharArray();
        for(int i =0;i<array.Length;i++)
        {
            System.Console.WriteLine(array[i]);
        }
    }
}
