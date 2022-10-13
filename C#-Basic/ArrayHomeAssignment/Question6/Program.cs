using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" size of array ");
        int size=Convert.ToInt32(Console.ReadLine());
         int[] array=new int[size];
         int temp=0;
         System.Console.WriteLine(" enter the elements are :");
        for (var i = 0; i < size; i++)
        {
            array[i]=Convert.ToInt32(System.Console.ReadLine());
        }
        for (var j = 0; j < size; j++)
        {
            for (var k = j+1; k < size; k++)
            {
                if(array[j]>array[k]){
                    temp=array[j];
                    array[j]=array[k];
                    array[k]=temp;
                }
            }
        }
        System.Console.WriteLine(" sorted array ");
        for(int l=0;l<size;l++){
            System.Console.WriteLine(array[l]);
        }
    }

}