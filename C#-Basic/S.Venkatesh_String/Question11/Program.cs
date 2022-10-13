using System;
namespace Question11;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" Enter the string ");
        string str=Console.ReadLine();
        var str2= new HashSet<char>(str);
        foreach (var item in str2)
        {
            System.Console.Write(item);
        }
    }
}