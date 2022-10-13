using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the choices\n1.india\n2.pakistan\n3.bangladesh");
        int option=Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                System.Console.WriteLine("1.dhoni\n2.kohli\n3.rohit");
                break;
            case 2:
                System.Console.WriteLine("1.babar\n2.rizwan\n3.ali");
                break;
            case 3:
                System.Console.WriteLine("1.rahman\n2.mohamad\n3.sami");
                break;

            default:
                System.Console.WriteLine("invalid option");
                break;
        }
        
    }
}