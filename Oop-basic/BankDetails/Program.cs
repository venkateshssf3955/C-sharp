using System;
using System.Collections.Generic;
namespace BankDetails
{
   
class Program
{
    public static void Main(string[] args)
    {   
        List<AccountDetails> list1=new List<AccountDetails>();
        System.Console.WriteLine("Are you willing to open an account: (yes/no)");
        string check=Console.ReadLine().ToLower();
        while(check=="yes"){
        System.Console.WriteLine(" Your details are :");
        System.Console.WriteLine(" Enter your name:");
        string name=Console.ReadLine();
        System.Console.WriteLine(" Enter your father name");
        string fatherName=Console.ReadLine();
        System.Console.WriteLine(" gender");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        
        System.Console.WriteLine(" enter your date of birth (dd/mm/yyyy)");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
        System.Console.WriteLine(" Enter your account type :");
        string accountType=Console.ReadLine();
        AccountDetails account=new AccountDetails(name,fatherName,gender,dob,accountType);
        list1.Add(account);
        System.Console.WriteLine(" account created");
        System.Console.WriteLine("Are you willing to open an account: (yes/no)");
        check=Console.ReadLine().ToLower();
        System.Console.WriteLine("\n");
        
        account.Deposit();
        account.Withdraw();
        account.Show();
        
        

        }
        int i=1;
        foreach(AccountDetails person in list1)
        {   
            System.Console.WriteLine($"     person{i} details     ");
            System.Console.WriteLine($"name is {person.Name}\nfather name is {person.FatherName}\ngender is {person.Gender}");
            System.Console.WriteLine($"date of birth is {person.DOB}\naccount type is {person.AccountType}\nbalance {person.Balance}");
            i++;
            
            
        }
    }
}
}