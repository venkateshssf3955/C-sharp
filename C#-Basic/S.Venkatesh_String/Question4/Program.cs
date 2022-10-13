using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        
    
    System.Console.WriteLine(" enter the string");
    string str=Console.ReadLine();
    string[] str2=str.Split(' ',',');
    System.Console.WriteLine(str2.Length);
    
}
}