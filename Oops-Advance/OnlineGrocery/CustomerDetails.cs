using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{
    public class CustomerDetails:PersonalDetails,IBalance
    {
        private static int s_customerId=1000;
        public string  CustomerId { get; set; }
        public double WalletBalance{get;set;}
       
        public CustomerDetails(string name,string fatherName,Gender gender,long mobileNumber,DateTime dob,string mail,double walletBalance):base(name,fatherName,gender,mobileNumber,dob,mail)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            WalletBalance=walletBalance;
        }

        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount to recharge ");
            double amount=double.Parse(Console.ReadLine());
            WalletBalance+=amount;
        }
        

        public void ShowCustomerDetails()
        {
            System.Console.WriteLine("customer id is " +CustomerId);
            System.Console.WriteLine("customer name is "+Name);
            System.Console.WriteLine("Customer fathername "+FatherName);
            System.Console.WriteLine("gender is "+Gender);
            System.Console.WriteLine("mobile number is "+MobileNumber);
            System.Console.WriteLine("date of birth "+DOB);
            System.Console.WriteLine("mail id is "+Mail);
            System.Console.WriteLine("walletBalance is"+WalletBalance);
        }
        
        public CustomerDetails(string data)
        {
            string[] values=data.Split(",");
            s_customerId=int.Parse(values[0].Remove(0,3));
            CustomerId=values[0];
            Name=values[1];
            FatherName=values[2];
            Gender=Enum.Parse<Gender>(values[3],true);
            MobileNumber=long.Parse(values[4]);
            DOB=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            Mail=values[6];
            WalletBalance=double.Parse(values[7]);

        }

    }
}