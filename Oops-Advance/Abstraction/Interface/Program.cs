using System;
namespace Interface;
class Program{
    public static void Main(string[] args)
    {
        Draw result=new Draw();
        result.Breadth=10;
        result.Length=10;
        result.CalculateArea();
    }
}