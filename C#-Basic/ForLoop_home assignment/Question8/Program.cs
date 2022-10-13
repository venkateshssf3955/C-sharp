using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {   
        int count=1;
        for (var i = 0; i < 4; i++)
        {
            for (var j = 0; j < 3-i; j++)
            {
                Console.Write(" ");
            }
            for (var k = 0; k < i+1; k++)
            {
                Console.Write(count+" ");
                 count=count+1;
            }
            System.Console.WriteLine("\n");
           
        }
    }
}