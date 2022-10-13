using System;
namespace Question7;
class Program {
    public static void Main(string[] args)
    {   
        double number1;
        System.Console.WriteLine(" enter the first number");
        number1=Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine(" enter the second number");
        double number2=Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine(" enter the third number");
        double number3=Convert.ToDouble(Console.ReadLine());
        double percent=percentage(number1,number2,number3);
        System.Console.WriteLine(" percentage is "+percent);


        double percentage(double value1,double value2,double value3 ){
            double percent=(double)(value1+value2+value3)/300*100;
            return percent;
        }
        }
}
        