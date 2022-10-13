using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" size of array ");
        int size=Convert.ToInt32(Console.ReadLine());
         int[] array=new int[size];
         //int sum=0;
         System.Console.WriteLine(" enter the elements are :");
        for (var i = 0; i < size; i++)
        {
            array[i]=Convert.ToInt32(System.Console.ReadLine());
        }
        System.Console.WriteLine(" even numbers are :");
        for (int j = 0; j <size; j++)
        {
         if(array[j]%2==0)  {
            System.Console.WriteLine(array[j]);
         } 
        }
        System.Console.WriteLine(" the odd numbers are : ");
        for (int k = 0; k < size; k++)
        {
            if(array[k]%2==1){
                System.Console.WriteLine(array[k]);
            }
        }
    }
}