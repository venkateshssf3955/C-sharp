using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {   
        int number1=0;
        int number2=1;
        System.Console.WriteLine(" number of terms to display ");
        int input=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"here is the fibonacci series upto 10 terms {number1}\n{number2}" );
        int i=0;
        while (i<input-2)
        {
            int number3=number1+number2;
            number1=number2;
            number2=number3;
            System.Console.WriteLine(number3);
            i++;
        }
    }
}