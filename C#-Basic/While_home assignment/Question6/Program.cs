using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {   

    int i=0;
        while (i<100)
        {
            if(i%2==0){
                System.Console.WriteLine($"{i} is a even number");
            }
            else {
                System.Console.WriteLine( $" {i} is an odd number ");
            }
            i++;
        }
     int j=1;
    
    int flag;
     while (j<100)
     {  
       
       flag =0;
       for(int k=2; k <j/2; k++)
       {
        if(j % i==0){
        flag =1;
        break;
       }
       if(flag !=1){
        System.Console.WriteLine($"{j} prime number");
       }
       j++;
    }
}
}}