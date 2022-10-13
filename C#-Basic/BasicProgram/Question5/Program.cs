using System;
namespace Question5;
class program{
    public static void Main(string[] args)
    {
        
    
    System.Console.WriteLine("enter your maths mark: ");
    int maths=Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("enter your chemistry mark");
    int chemistry=Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Enter your physics:");
    int physics=Convert.ToInt32(Console.ReadLine());
    float sum=(float)(maths+chemistry+physics);
    float percentage=(sum/300)*100;
    System.Console.WriteLine("sum of subjects is "+sum);

    System.Console.WriteLine("percentage is "+percentage);
    
}
}