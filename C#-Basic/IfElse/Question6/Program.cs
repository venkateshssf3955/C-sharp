using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        
    
    System.Console.WriteLine("enter the price: ");
    int price=Convert.ToInt32(Console.ReadLine());
    double tax=0.18;
    float total=(float)(price+price*tax);
    System.Console.WriteLine("Total price of "+total);
    
}
}