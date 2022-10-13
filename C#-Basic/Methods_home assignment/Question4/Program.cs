using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" enter the input:");
        int number=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"  The fibonacci series of {number} is");
        Fibonacci(number);
        void Fibonacci(int value){
           int number1=0;
           int number2=1;
           System.Console.WriteLine(number1+"\n"+number2);
           for (var i = 0; i < value-2; i++)
           {
            
           
           int number3=number1+number2;
           number1=number2;
           number2 =number3;
           System.Console.WriteLine(number3);
           }
        }
    }
}