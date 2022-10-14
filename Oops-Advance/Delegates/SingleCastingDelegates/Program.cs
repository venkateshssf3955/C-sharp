using System;
namespace DelegateApp1;
public delegate int Calculator(int n);
class Program
{
    static int value=10;
    public static int AddNum(int number) 
    {
        value+=number;
        return value;
    }
    public static int MulNum(int number)
    {
        value*=number;
        return value;
    }
    public static int GetNum()
    {
        return value;
    }

    static void Main(string[] args)
    {
        Calculator nc1=new Calculator(AddNum);
        Calculator nc2=new Calculator(MulNum);
        nc1(25);
        System.Console.WriteLine("value of the num: {0}",GetNum());
        nc2(5);
        System.Console.WriteLine("value of num: {0}",GetNum());
        Console.ReadKey();
    }
}
