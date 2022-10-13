using System;
namespace ForLoop;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("even number is");
        for(int i=0;i<=25;i++)
        {
            if(i%2==0){
               
                System.Console.WriteLine(i);
            }
        }
        System.Console.WriteLine("enter the initial value: ");
        int firstNum=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("enter the final value: ");
        int finalNum=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        for(int j=firstNum;j<=finalNum;j++)
        {
            sum=sum+j*j;
        }
        System.Console.WriteLine("Sum of the square the number is "+sum);

        

    }    
}