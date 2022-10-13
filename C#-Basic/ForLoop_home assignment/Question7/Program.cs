using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        for(int i=0;i<4; i++){
            for(int j=0; j<3-i; j++){
                System.Console.Write(" ");
            }
            for(int k=0; k<i+1;k++){
                Console.Write("* ");
            }
            System.Console.WriteLine("\r");
        }
    }
}