using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {   
        int number1;
        bool check=false;
        string number;
        int fix;
        while (check==false)
        {   
            System.Console.WriteLine(" enter the input");
            number=Console.ReadLine();
            
            check=int.TryParse(number,out number1 );
            if(check){
                fix=Convert.ToInt32(number);
                if(fix<7){
                    System.Console.WriteLine("valid input");
                }
                else{
                System.Console.WriteLine("invalid input");   
                check=false;
            }
            
            }
           
            
       
        }
        
        
    }
}