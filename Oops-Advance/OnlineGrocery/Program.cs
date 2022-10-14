using System;
namespace OnlineGrocery;
class Program{
    public static void Main(string[] args)
    {   
        Files.Create();
        Files.ReadFiles();
        Operation.MainMenu();
        Files.WriteFlies();

    }
}