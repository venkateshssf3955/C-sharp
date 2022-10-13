using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the number");
        int number=Convert.ToInt32(Console.ReadLine());
        int check=number;
        int rem;
        int sum=0;
        for(;;){
            if(number>0){
            rem=number%10;
            sum=sum+rem*rem*rem;
            number=number/10;
            
            }
            else{
                break;
            }
        if(check==sum){
            System.Console.WriteLine($"{sum} is a amstrong number");
        }    

        }
    }
}