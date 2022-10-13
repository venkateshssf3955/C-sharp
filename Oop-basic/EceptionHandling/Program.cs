using System;
namespace ExceptionHandling;
class Program{
    public static void Main(string[] args)
    {

         try{
        System.Console.WriteLine(" enter the first value");
        int value1=int.Parse(Console.ReadLine());
        System.Console.WriteLine(" Enter the second number :");
        int value2=int.Parse(Console.ReadLine());
        int value3=value1/value2;
        System.Console.WriteLine(value3);
         }
         catch(DivideByZeroException e){
            System.Console.WriteLine(e.Message);
            

         }
         catch(FormatException e)
         {
            System.Console.WriteLine(e.Message);
         }
         catch(Exception e)
         {
            System.Console.WriteLine(e.Message);
         }
         finally{
            System.Console.WriteLine("all the exception handled");
         }
     
    }
}