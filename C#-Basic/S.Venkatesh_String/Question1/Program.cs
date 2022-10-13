using System;
namespace Question;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the String");
        string str=Console.ReadLine();
        int count =0;
        foreach(char str2 in str)
        {
            count ++;
        }
    
       System.Console.WriteLine(" length of the string is "+count);
    }
}