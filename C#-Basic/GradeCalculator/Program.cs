using System;
namespace GradeCalculator;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter your mark:");
        int mark=Convert.ToInt32(Console.ReadLine());
        if(mark<100){
            
            if(80<mark){
                System.Console.WriteLine("Grade A");
            }
            else if(60<mark)
            {
            System.Console.WriteLine("Grade B");
            }
            else if(35<mark){
            System.Console.WriteLine("Grade C");
            }
            else if(0<mark) {
            System.Console.WriteLine("Grade D");


            }
            else{
            System.Console.WriteLine("Invalid output");
            }
}
else{
    System.Console.WriteLine("invalid output");
}
}}