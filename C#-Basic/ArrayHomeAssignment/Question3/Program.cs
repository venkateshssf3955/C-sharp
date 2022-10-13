using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {   
       
        System.Console.WriteLine(" size of array ");
        int size=Convert.ToInt32(Console.ReadLine());
         int[] array=new int[size];
         int sum=0;
         System.Console.WriteLine(" enter the elements are :");
        for (var i = 0; i < size; i++)
        {
            array[i]=Convert.ToInt32(System.Console.ReadLine());
            sum=sum+array[i];
        }
        System.Console.WriteLine(" sum of the elements to be stored in the array: " +sum);
    }
}