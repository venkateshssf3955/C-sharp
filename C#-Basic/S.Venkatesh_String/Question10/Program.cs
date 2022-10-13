using System;
namespace Question10;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" Enter the username:");
        string str=Console.ReadLine().ToLower();
        System.Console.WriteLine(" Enter the password");
        string  str2=Console.ReadLine().ToLower();
        if(str=="user" && str2=="pass"){
            System.Console.WriteLine("password enterted successfully");
        }

    }
}