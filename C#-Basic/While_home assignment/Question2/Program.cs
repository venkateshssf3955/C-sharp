using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the count of inputs " );
        int count =Convert.ToInt32(Console.ReadLine());
        int i=0;
        int sum=0;
        while (i<5)
        {   
            System.Console.WriteLine(" enter the number");
            int number=Convert.ToInt32(Console.ReadLine());
            sum=sum+number*number;
            i++;
        }
        System.Console.WriteLine("output is "+sum);
    }
}