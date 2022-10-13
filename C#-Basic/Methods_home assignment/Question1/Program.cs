using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the first number");
        int number1=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("enter the second number");
        int number2=Convert.ToInt32(Console.ReadLine());
        Addition (number1,number2);
        Subtraction(number1,number2);
        Multiplication(number1,number2);
        Division(number1,number2);
        void Addition( int value1,int value2){
            System.Console.WriteLine("addition "+(value1+value2));
        }
        void Subtraction( int value1,int value2){
            System.Console.WriteLine("suntraction "+(value1-value2));
        }
        void Multiplication( int value1,int value2){
            System.Console.WriteLine("multiply"+(value1*value2));
        }
        void Division( int value1,int value2){
            System.Console.WriteLine("Division "+(value1/value2));
        }
    }
}