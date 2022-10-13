using System;
namespace Question12;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" Enter the original of number :");
        string str=Console.ReadLine();
        string[] newStr=str.Split(" ");
      
        int[] array=new int[newStr.Length];
        for (int i = 0; i < newStr.Length; i++)
        {
           array[i]=Convert.ToInt32(newStr[i]);
        }
        int max =array[0];
        for (int i = 0; i < newStr.Length-1; i++)
        {
            if(max<array[i+1]){
                max=array[i+1];
            }
        }
        int min =array[0];
        for (int i = 0; i < newStr.Length-1; i++)
        {
            if(min>array[i+1]){
                min=array[i+1];
            }
        }
        System.Console.WriteLine(" maximum in the list "+max);
        System.Console.WriteLine(" minimun in the list "+min);
    }
}