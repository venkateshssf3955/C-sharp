using System;
namespace Question;


    class Program{
        public static void Main(string[] args)
        {
        System.Console.WriteLine(" Enter the number:");
        int number=Convert.ToInt32(Console.ReadLine());
        int result=Factorial(number);
        System.Console.WriteLine("Factorial is  "+result );
          
        int Factorial(int value){
         if(value==1 || value==0){
            return 1;
         }
         else{
            return value*Factorial(value-1);
         }
        }
    }
    }
