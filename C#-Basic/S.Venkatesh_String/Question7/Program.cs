using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" enter the string");
        string str=Console.ReadLine().ToLower();
        int count=0;
        int count1=0;
        char[] str2=str.ToCharArray();
        for(int i=0;i<str.Length;i++){
            if(str2[i]=='a' || str2[i]=='e' ||str2[i]=='i' ||str2[i]=='o'||str2[i]=='u'){
                count++;
            }
            else if((str2[i] >='a') && (str2[i]<='z'))
            {
                count1++;
            }
        }
        System.Console.WriteLine("total vowels is "+count);
        System.Console.WriteLine("total consonent is "+count1);
    }
}