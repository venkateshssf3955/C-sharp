using System;
namespace Methods;
class Program{
    public static void Main(string[] args)
    {   
        string valid= " ";
        do
        {
        System.Console.WriteLine(" please enter your option:");
        System.Console.WriteLine(" 1-Addition \n 2-subtraction \n 3-multiplictin \n 4-division ");
        String option=Console.ReadLine().ToLower();
        System.Console.WriteLine("Enter the first number:");
        int number1=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the second number:");
        int number2=Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case "1" :
                int sum =Addition(number1,number2);
                System.Console.WriteLine(" sum of number is "+sum);
                break;
            case "2":
                int subtraction=Subtraction(number1,number2);
                System.Console.WriteLine(" subtraction of the number is "+subtraction);
                break;
            case "3":
                int multiplication=Multiplication(number1,number2);
                System.Console.WriteLine(" multiply of number is "+multiplication);
                break;    
            case "4":
                int division=Division(number1,number2); 
                System.Console.WriteLine(" division of the number is "+division);    
                break;
            

           
        }
        System.Console.WriteLine(" do you want to continue: yes/no : ");
        valid =Console.ReadLine().ToLower();
        }while(valid == "yes");

        int Addition(int value1,int value2){
            int sum =value1+value2;
            return sum;
        }
        int Subtraction(int value1,int value2){
            int subtraction=value1-value2;
            return subtraction;
        }
        int Multiplication(int value1,int value2){
            int multiplictin=value1*value2;
            return multiplictin;
        }
        int Division(int value1,int value2){
            int division=value1/value2;
            return division;
        }

    }
}
