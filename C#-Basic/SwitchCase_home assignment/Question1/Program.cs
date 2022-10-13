using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the grade");
        string grade=(Console.ReadLine()).ToUpper();
        switch (grade)
        {
            case "E":
                System.Console.WriteLine("Excellent");
                break;
            case "V":
                System.Console.WriteLine("Very good");
                break;
            case "G":
                System.Console.WriteLine("Good");
                break;
            case "A":
                System.Console.WriteLine(" Average");
                break;
            case "F":
                System.Console.WriteLine("Fail");
                break;
            default:
                System.Console.WriteLine("invalid option");
                break;
        }
        
        
    }
}