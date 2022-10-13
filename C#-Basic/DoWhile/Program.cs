using System;
namespace DoWhile;
class program{
    public static void Main(string[] args)
    {
      
        string check=" ";

        
        do{
            System.Console.WriteLine("enter the number :");
             int num=Convert.ToInt32(Console.ReadLine());
            if(num%2==0){
                System.Console.WriteLine("given number is even");

            }
            else{
                System.Console.WriteLine("given number is odd ");

            }
            System.Console.WriteLine("do you want to repeat? yes:no");
            check=Console.ReadLine().ToLower();
            
            if(check!="no")
            {
            System.Console.WriteLine("please enter the valid input");
            System.Console.WriteLine("do you want to repeat? yes:no");
            check=Console.ReadLine().ToLower();

            }
            
        
        }while(check=="yes");
        
    }}