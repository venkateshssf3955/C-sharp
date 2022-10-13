using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" input number of terms to display");
        int input=Convert.ToInt32(Console.ReadLine());
        int number1=0;
        int number2=1;
        System.Console.WriteLine("{0}\n{1} ",number1,number2);
        do{
             
            int number3=number1+number2;
            number1=number2;
            number2=number3;
            System.Console.WriteLine(number3);
            input--;

        }while (2<input);
    }
}