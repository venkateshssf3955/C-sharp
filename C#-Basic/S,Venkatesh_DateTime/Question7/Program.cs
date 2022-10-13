using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date dd/MM/yyyy hh/mm/ss tt");
        string date=Console.ReadLine();
        DateTime date1=Convert.ToDateTime(date);
         System.Console.WriteLine("Enter the date dd/MM/yyyy hh/mm/ss tt");
        string date2=Console.ReadLine();
        DateTime date3=Convert.ToDateTime(date2);
        if(DateTime.Compare(date1,date3)<0){
            System.Console.WriteLine("{0} is earlier than {1}",date1,date3);
        }
        else if(DateTime.Compare(date1,date3)==0){
            System.Console.WriteLine("{0} is same time as {1}",date1,date3);
    }
    else{
         System.Console.WriteLine("{0} is later than {1}",date1,date3);
    }
}
}