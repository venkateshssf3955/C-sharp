using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        
    
    System.Console.WriteLine("enter the radius ");
    double radius=Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine(" enter the option\n1.area\n2.perimeter\n3.diameter");
    int option=Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            double area=(double)22/7*radius*radius;
            System.Console.WriteLine("the area is "+area);
            break;
        case 2:
            double perimeter=2*22/7*radius;  
            System.Console.WriteLine(" the perimeter "+perimeter);  
            break;
        case 3:
            System.Console.WriteLine(" the diameter is "+(2*radius));
            break;
        default:
            System.Console.WriteLine("invalid option");
            break;
    }
    
}
}