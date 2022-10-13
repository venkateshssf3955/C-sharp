using System;
 namespace Question;
 class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" enter the first string");
        string str1=Console.ReadLine();
        System.Console.WriteLine(" enter the second string");
        string str2=Console.ReadLine();
        if(str1==str2){
            System.Console.WriteLine("both are equal");
        }
        else{
            System.Console.WriteLine(" both are not same");
        }
    }
 }