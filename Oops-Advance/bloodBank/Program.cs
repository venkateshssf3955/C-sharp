using System;
using System.Collections.Generic;
namespace BloodBank;
class Program{
    public static void Main(string[] args)
    {   
        Files.Create();
        Files.ReadFiles();
        Operation.MainMenu();
        Files.WriteFiles();
    }
}