using System;
namespace SwitchCase;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the first number");
        int num1=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("enter the second number");
        int num2=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("enter the choice");
        System.Console.WriteLine("  +  "+"  -  "+"  *  "+"  %  "+"  /  " );
        char choice=Convert.ToChar(Console.ReadLine());
        
        switch(choice){
            case '+':
            {
            System.Console.WriteLine("Addition of two numbers "+(num1+num2));
            break;
            }
            case '-':
            {
                System.Console.WriteLine("subtraction of two numbers is "+(num1-num2));
                break;
            }
            case '*':{
            System.Console.WriteLine("multiplication of two numbers is "+(num1*num2));
            break;
            }
            case '/':{
            System.Console.WriteLine("division of two numbres "+(num1/num2));
            break;
            }
            case '%':{
                System.Console.WriteLine("Modulus of the numbers is "+(num1%num2));
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid input");
                break;
            }
    }
}}