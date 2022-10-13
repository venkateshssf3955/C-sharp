using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" enter the first number:");
        int number1=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(" enter the second number:");
        int number2=Convert.ToInt32(Console.ReadLine());
        Swap(number1,number2);
         

        void Swap(int value1,int value2){
            int temp=value1;
            value1=value2;
            value2=temp;
            System.Console.WriteLine($" now the 1st number is:{value1},and the 2nd number is {value2}");
        }
    }
}