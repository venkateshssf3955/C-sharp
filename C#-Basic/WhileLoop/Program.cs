using System;
namespace WhileLoop;
class program{
    public static void Main(string[] args)
    {   
        System.Console.WriteLine("Even numbers is:");
        int i=1;
        while(i<25){
            if(i%2==0){
                System.Console.WriteLine(i);
            }
            i++;
        }
        int number; 
         System.Console.WriteLine(" enter the number:");
        bool num=int.TryParse(Console.ReadLine(),out number);
       
        while(num==false){
            
            System.Console.WriteLine("Invalid output");
            System.Console.WriteLine("enter the number:");
            num=int.TryParse(Console.ReadLine(),out number);
            
            
        }
        
    }
}