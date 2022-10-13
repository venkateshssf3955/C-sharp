using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {   
        System.Console.WriteLine("enter the size the array:");
        int arraySize=Convert.ToInt32(Console.ReadLine());
        string[] names=new string[arraySize];
        for(int i=0;i<names.Length;i++){
            System.Console.WriteLine("enter the name:");
            names[i]=Console.ReadLine().ToLower();
            
        }
        System.Console.WriteLine("Names are:");
        for(int j=0;j<names.Length;j++){
            System.Console.WriteLine(names[j]);
        }
        System.Console.WriteLine("search the name in array:");
        string searchName=Console.ReadLine().ToLower();
        int flag=0;
        for(int k=0;k<names.Length;k++){
            if(names[k]==searchName){
                System.Console.WriteLine(" The name is present in array");
                System.Console.WriteLine("Index of the name is "+k);
                flag=1;
            }}
        if(flag==0){
            System.Console.WriteLine("The name is not present in array");
        }  
        int l=0  ;
        int flag2=0;
        foreach(string newName in names){
        
            if(searchName==newName){
                System.Console.WriteLine("The name is present in array");
                System.Console.WriteLine("Index of the name is "+l);
                
                flag2=1;
            }
            l=l+1;
        }
        if(flag2==0){
            System.Console.WriteLine("The name is not present in array");
        }

        

    }
}
