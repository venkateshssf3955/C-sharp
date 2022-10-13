using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date in this format M/dd/yyyy hh:mm:ss tt");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"M/dd/yyyy hh:mm:ss tt",null);
        
        System.Console.WriteLine("Enter the date in this format M/dd/yyyy hh:mm:ss tt");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(),"M/dd/yyyy hh:mm:ss tt",null);

         if(DateTime.Compare(date,date1)<0){
            System.Console.WriteLine("{0} is earlier than {1}",date,date1);
        }
        else if(DateTime.Compare(date,date1)==0){
            System.Console.WriteLine("{0} is same time as {1}",date,date1);
    }
    else{
         System.Console.WriteLine("{0} is later than {1}",date,date1);
    }
        
    }
}