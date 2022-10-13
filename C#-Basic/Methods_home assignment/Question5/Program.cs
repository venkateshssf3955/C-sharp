using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" Enter the number:");
        int number=Convert.ToInt32(Console.ReadLine());
        PrimeNumber(number);
          
        void PrimeNumber(int value){
            int flag=0;
            for (var i = 2; i < value/2; i++)
            {
                if(value%i==0){
                    flag=1;
                    break;
                }
            }
            if(flag==1){
                System.Console.WriteLine(" not a prime number");
            }
            else{
                System.Console.WriteLine(" it is a prime number");
            }
        }  
    }
}