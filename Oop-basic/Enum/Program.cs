using System;
namespace Enum1;
public enum Gender{Default,Male,Female,TransGender}
class Program{
    static void Main(string[] args){
        Console.WriteLine(" Select Gender options Male,Female,TransGender");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine(gender);

        System.Console.WriteLine(" Select Gender option Male,Female,TransGender");
        Gender gender2=Gender.Default;
        bool temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
        while(!temp||!((int)gender2<4 && (int)gender2>0)){
            System.Console.WriteLine(" invalid gender \n enter again");
            temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
        }
       System.Console.WriteLine(gender2);
    }
}