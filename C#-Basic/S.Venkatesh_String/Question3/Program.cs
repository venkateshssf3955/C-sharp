using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" enter the string ");
        string str=Console.ReadLine();
        int length=str.Length;
        string str2="";
        for(int i=length-1;i>=0;i--){
            str2=str2+str[i];
        }
        System.Console.WriteLine(" reversed string is "+str2);
    }
}