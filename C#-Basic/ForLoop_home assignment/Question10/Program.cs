using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the number");
        int number=Convert.ToInt32(Console.ReadLine());
        int flag=0;
        for (var i = 2; i < number/2; i++)
        {
            if(number%i==0){
                flag=1;
                break;
            }
        }
        if(flag==1){
            System.Console.WriteLine($"{number} is not a prime number ");
        }
        else
        {
            System.Console.WriteLine($"{number} is a prime number ");
        }
    }
}