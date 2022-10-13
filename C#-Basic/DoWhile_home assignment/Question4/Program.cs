using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {   int number;
        bool check;
        do{
            System.Console.WriteLine(" input value");
            string input=Console.ReadLine();
            check=int.TryParse(input,out number );
            if(check==true){
            if(Convert.ToInt32(input)<10 && Convert.ToInt32(input)>0){
                System.Console.WriteLine(Convert.ToInt32(input));
                break;
            }
            else{
                check =false;
            }
            }

        }while(check==false);
        
    }
}