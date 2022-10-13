using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {   
    
        System.Console.WriteLine("enter the any month number [1-12]");
        int number=Convert.ToInt32(Console.ReadLine());
        
        
        switch (number)
        {
            case 1:
                System.Console.WriteLine(" month have 31 days");
                break;
            case 3:
                System.Console.WriteLine(" month have 31 days");
                break;
            case 5:
                System.Console.WriteLine(" month have 31 days");
                break;
            case 7:
                System.Console.WriteLine(" month have 31 days");
                break;
            case 8:
                System.Console.WriteLine(" month have 31 days");
                break;
            case 10:
                System.Console.WriteLine(" month have 31 days");
                break;
            case 12:
                System.Console.WriteLine(" month have 31 days");
                break;
            default:
                System.Console.WriteLine(" month have 30 days");
                break;
        }
        

        }
    }
