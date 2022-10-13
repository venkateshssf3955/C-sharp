using System;
namespace String;
class Program{
    public static void Main(string[] args)
    {
        
    System.Console.WriteLine("enter the string :");
    string name=Console.ReadLine();
    System.Console.WriteLine("enter the substring:");
    string subString=Console.ReadLine();
    string[] split=name.Split(new string[] {subString},StringSplitOptions.None);
    System.Console.WriteLine(split.Length-1);
}
}