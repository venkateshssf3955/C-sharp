using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {   
        System.Console.WriteLine(" 2d array :");
        System.Console.WriteLine("enter the elements:");
        int[,] array=new int[3,3];
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                array[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        System.Console.WriteLine("the matrix is");
        for (var k = 0;  k< 3; k++)
        {
            for (var l = 0; l < 3; l++)
            {
                Console.Write(array[k,l]+" ");
            }
            System.Console.WriteLine();
        }

    }
}