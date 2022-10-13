using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("input the number of elements store in the array");
        int size=Convert.ToInt32(Console.ReadLine());
        int[] array=new int[size];
        System.Console.WriteLine(" enter the elements ");
        for (var i = 0; i < size; i++)
        {
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        int max=array[0];
        for (int j = 0; j < size-1; j++)
        {
            if(max<array[j+1]){
                max=array[j+1];
            }
          
        
        }
        System.Console.WriteLine(" maximum is "+max); 
        int min=array[0];  
        for (var k = 0; k < size-1; k++)
        {
            if(min>array[k+1]){
                min=array[k+1];
            }
            
        }
        System.Console.WriteLine(" minimum is "+ min);
    }
}