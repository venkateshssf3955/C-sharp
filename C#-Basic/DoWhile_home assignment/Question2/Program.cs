using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {   int sum=0;
        int input;
        System.Console.WriteLine(" enter the number of inputs");
        input=Convert.ToInt32(Console.ReadLine());
        do{
            
            System.Console.WriteLine(" enter the number ");
            int number=Convert.ToInt32(Console.ReadLine());
            if(number>0){
                sum=sum+number;
            }
            input--;
        }while(0<input);
    System.Console.WriteLine(" sum is "+sum);
    }

}