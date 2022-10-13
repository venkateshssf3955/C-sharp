using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" enter the first number");
        int firstNum=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(" enter the second number");
        int secondNum=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(" enter your option\n 1.addition\n2.subtraction\n3.multiplication\n4.division\n5.exit");
        int option=Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                System.Console.WriteLine("sum of the number is "+(firstNum+secondNum));
                break;
            case 2:
                System.Console.WriteLine("subtraction of the number is "+ (firstNum-secondNum));
                break;    
            case 3:
                System.Console.WriteLine("multiplication of the number is "+ (firstNum*secondNum));
                break;
            case 4:
                System.Console.WriteLine("sum of the number is "+ (firstNum/secondNum));
                break;
            case 5:
                break;
        }
        
    }
}