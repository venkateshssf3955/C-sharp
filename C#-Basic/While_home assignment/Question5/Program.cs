using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" enter the number:");
        int number=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        while (number>0)
        {
           int rem=number%10;
            sum=sum+rem;
            number=number/10;
        }
        System.Console.WriteLine(" sum of the digit is " +sum);
    }
}