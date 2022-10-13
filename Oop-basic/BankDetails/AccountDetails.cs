using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankDetails

{
    public enum Gender{Default,Male,Female,TransGender}
      public class AccountDetails
    {
        public string Name { get; set; }
         
        public string FatherName { get; set; }
        
        public Gender Gender { get; set; }

        public DateTime DOB { get; set; }
        
        
        
        public string AccountType{ get; set; }

        public double Balance { get; set; }
        
        
        public AccountDetails(string name,string fatherName,Gender gender,DateTime dob,string accountType)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            DOB=dob;
            AccountType=accountType;
        }
        public void Deposit(){
            System.Console.WriteLine(" enter the deposit amount :");
            double amount=Convert.ToDouble(Console.ReadLine());
            Balance=Balance+amount;
            System.Console.WriteLine(" amount is added \n balance is "+Balance);
        }
         
         public void Withdraw(){
            System.Console.WriteLine(" enter the withdraw amount :");
            double amount=Convert.ToDouble(Console.ReadLine());
            Balance=Balance-amount;
            System.Console.WriteLine(" amount is withdraw /n balance is "+Balance);
         }

         public void Show(){
            System.Console.WriteLine("your balance is "+Balance);
         }
    }   
    
        
    }
