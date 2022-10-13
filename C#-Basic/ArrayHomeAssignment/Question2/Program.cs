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
        System.Console.WriteLine(" elements are ");
        for (var j = 0; j < size ; j++)
        {
            System.Console.WriteLine(array[j]);

        }
        System.Console.WriteLine(" reversed elements are");
        for (int k= size-1; k>=0; k--)
        {
            System.Console.WriteLine(array[k]);   
        }
    }
}