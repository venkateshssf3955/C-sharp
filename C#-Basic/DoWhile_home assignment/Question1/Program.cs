using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {   
        string option=" ";
        do{
            System.Console.WriteLine(" enter the number");
            int number=Convert.ToInt32(Console.ReadLine());
            if(number%2==0){
                System.Console.WriteLine(" given numbner is even number");
            }
            else{
                System.Console.WriteLine("given number is odd number");
            }
            System.Console.WriteLine(" do you want to continue: yes/no" );
            option=Console.ReadLine().ToLower(); 
        }while(option == "yes");
    }
}