using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" enter the string ");
        string str=Console.ReadLine().ToLower();
        int count=0;
        int count1=0;
        int count2=0;
        int i;
        for( i=0;i<str.Length;i++)
        {
        if(str[i] >='a' && str[i] <= 'z' )
        {
            count++;
        }
        else if(str[i]>='0'&&str[i]<='9')
        {
            count1++;
        }
        else
        {
            count2++;
        }
        
    }
    System.Console.WriteLine(" alphabets "+count);
    System.Console.WriteLine(" numbers "+count1);
    System.Console.WriteLine(" special character "+count2);
}
}