using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        int value=15;
        int value1=20;
        System.Console.WriteLine(value>value1);
        System.Console.WriteLine(value<value1);
        System.Console.WriteLine(value>=value1);
        System.Console.WriteLine(value==value1);
        System.Console.WriteLine(value!=value1);
        System.Console.WriteLine(value<=value1);
        System.Console.WriteLine(value>=10&&value1>=10);
        System.Console.WriteLine(value>=10||value>=30);
        System.Console.WriteLine(!(value>20));
        string value3=value==15?"true":"false";
        System.Console.WriteLine(value3);
        System.Console.WriteLine(value++);
        System.Console.WriteLine(value--);

    }
}