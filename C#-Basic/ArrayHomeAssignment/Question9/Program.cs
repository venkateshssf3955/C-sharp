using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" first's row");
        int firstRow=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(" first's column");
        int firstColumn=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(" second's row");
        int secondRow=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(" second's row");
        int secondcolumn=Convert.ToInt32(Console.ReadLine());
        if(firstColumn==secondRow){
            int[,] array=new int[firstRow,firstColumn];
        int[,] array1=new int[secondRow,secondcolumn];
        int[,] array2=new int[firstColumn,secondRow];
        

        System.Console.WriteLine(" enter the first array:");
        for (var i = 0; i < firstRow; i++)
        {
            for (var j = 0; j < firstColumn; j++)
            {
                array[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        System.Console.WriteLine(" engter the second array");
        for (var i = 0; i < secondRow; i++)
        {
            for (var j = 0; j < secondcolumn; j++)
            {
                array1[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        System.Console.WriteLine(" first matrix is:");
        for (var k = 0; k < firstRow; k++)
        {
            for (var l = 0; l < firstColumn; l++)
            {
                Console.Write((array[k,l])+" ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine(" first second is:");
        for (var k = 0; k < secondRow; k++)
        {
            for (var l = 0; l < secondcolumn; l++)
            {
                Console.Write(array1[k,l]+" ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine(" addition matrix is:");
        for (var i = 0; i < firstColumn; i++)
        {
            
        
        for (var k = 0; k < firstColumn; k++)
        {   array2[i,k]=0;
            for (var l = 0; l < secondRow; l++)
            {
                array2[i,k]+=(array[i,l]*array1[l,k]);
                
            }
            
           
            
           
        }
        }
        for (var k = 0; k < firstColumn; k++)
        {
            for (var l = 0; l < secondRow; l++)
            {
               System.Console.Write(array2[k,l]+" ");
            }
           System.Console.WriteLine();
        }
        }
    }
}