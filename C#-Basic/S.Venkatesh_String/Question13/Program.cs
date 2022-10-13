using System;
namespace Question13;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" Enter the string");
        string str=Console.ReadLine();
        string str1=" ";
        int sum=0;
        for (int i = 0; i < str.Length; i++)
        {
            if(str[i]>='0' && str[i]<='9'){
               str1=str1+str[i]; 
            }
        }
        int number=int.Parse(str1);
        for (int i = 0; i < str1.Length; i++)
        {
            int rem=number%10;
            sum=sum+rem;
            number=number/10;
        }
        System.Console.WriteLine(" output is :"+sum);
    }
}
