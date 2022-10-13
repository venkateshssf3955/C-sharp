using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {   System.Console.WriteLine(" enter the elements ");
        int[] array=new int[10];
        for (var i = 0; i < 10; i++)
        {
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        for (var j = 0; j < 10; j++)
        {
            System.Console.WriteLine(" elemment are "+array[j]);
        }
    }
}