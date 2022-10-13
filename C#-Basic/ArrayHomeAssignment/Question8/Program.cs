using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" Input the size of the square matrix :");
        int length=Convert.ToInt32(Console.ReadLine());
        int[,] array=new int[length,length];
        int[,] array1=new int[length,length];
        int[,] array2=new int[length,length];

        System.Console.WriteLine(" enter the first array:");
        for (var i = 0; i < length; i++)
        {
            for (var j = 0; j < length; j++)
            {
                array[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        System.Console.WriteLine(" engter the second array");
        for (var i = 0; i < length; i++)
        {
            for (var j = 0; j < length; j++)
            {
                array1[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        System.Console.WriteLine(" first matrix is:");
        for (var k = 0; k < length; k++)
        {
            for (var l = 0; l < length; l++)
            {
                Console.Write((array[k,l])+" ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine(" first second is:");
        for (var k = 0; k < length; k++)
        {
            for (var l = 0; l < length; l++)
            {
                Console.Write(array1[k,l]+" ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine(" addition matrix is:");
        for (var k = 0; k < length; k++)
        {
            for (var l = 0; l < length; l++)
            {
                Console.Write((array[k,l]+array1[k,l])+" ");
            }
            System.Console.WriteLine();
        }
    }
}