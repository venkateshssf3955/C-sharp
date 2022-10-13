using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {   
        int sum=0;
       
        for (var i = 0; i < 10; i++)
        {   
            System.Console.WriteLine(" enter the number:");
            int number=Convert.ToInt32(Console.ReadLine());
            sum=sum+number;
            
        }
         float average=(float)sum/10;
        System.Console.WriteLine("sum is "+sum);
        System.Console.WriteLine("average is "+average);
    }
}