using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {

        DateTime[] date= {new DateTime(2016, 8, 16, 9, 28, 0),
                           new DateTime(2011, 5, 28, 10, 35, 0),
                           new DateTime(1979, 12, 25, 14, 30, 0) };

        System.Console.WriteLine(" current time is "+DateTime.Now);
        for (int i = 0; i < 3; i++)
        
        {
        System.Console.WriteLine("date:"+date[i].ToString("dd/MM/yyyy")+"  time:"+date[i].TimeOfDay);
    }}
}