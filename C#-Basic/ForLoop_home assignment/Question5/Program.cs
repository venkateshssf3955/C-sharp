using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        
    
    System.Console.WriteLine(" enter the number of terms ");
    int number=Convert.ToInt32(Console.ReadLine());
    int j=1;
    int sum=0;
    System.Console.WriteLine(" The numbers are :");
    for (int i = 0; i < number; i++)
    {
        System.Console.WriteLine(j);
        sum=sum+j;
        j=j+2;
    }
    System.Console.WriteLine(" sum of the odd natural numbers upto 10 terms: "+sum);
}
}