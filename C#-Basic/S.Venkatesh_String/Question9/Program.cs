using System;
namespace Question9;
class Program{
public static void Main(string[] args)
{
    System.Console.WriteLine(" enter the string ");
    string str=Console.ReadLine();
    System.Console.WriteLine(" enter the substring ");
    string str2=Console.ReadLine();
    int length=str2.Length;
    string[] str3=new string[str.Length];
        for (var i = 0; i < str.Length-1; i++)
        {
            str3[i]=str.Substring(i,length);
            
        }
        for (var i = 0; i < str.Length-1; i++)
        {
            if (str3[i]==str2)
            {
                System.Console.WriteLine(" sub string is present in the string");
                break;
            }
        }
        
    
   
    
}}
