using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food
{
    public class CustomerRegistration:PersonalDetails,IBalance
    {
        private static int s_registrationId=1000;
        public string RegistrationId { get; set; }
        public double WalletBalance { get; set; }
        public CustomerRegistration(string name,string fatherName,Gender gender,long mobileNumber,DateTime dob,string mail,string location,double walletBalance):base(name,fatherName,gender,mobileNumber,dob,mail,location)
        {
        s_registrationId++;
        RegistrationId="CID"+s_registrationId;
        WalletBalance=walletBalance;
        }
        public CustomerRegistration()
        {
            
        }
        
        public void WalletRecharge(){
            System.Console.WriteLine("Enter the amount to recharge");
            double amount=double.Parse(Console.ReadLine());
            WalletBalance=WalletBalance+amount;
        }

        public void CustomerDetails()
        {
            System.Console.WriteLine("---customer details---");

            System.Console.WriteLine($"RegistrationId      {RegistrationId}");
            System.Console.WriteLine($"WalletBalance is    {WalletBalance}");
            System.Console.WriteLine($"customer name       {Name}");
            System.Console.WriteLine($"Customer Fathername {FatherName}");
            System.Console.WriteLine($"Gender              {Gender}");
            System.Console.WriteLine($"Mobile              {MobileNumber}");
            System.Console.WriteLine($"date of birth       {DOB}");
            System.Console.WriteLine($"mailId is           {Mail}");
            System.Console.WriteLine($"location is         {Location}");
        }


    public CustomerRegistration(string item)
    {
        string[] values=item.Split(",");
        s_registrationId=int.Parse(values[0].Remove(0,3));
        RegistrationId=values[0];
        Name=values[1];
        FatherName=values[2];
        Gender=Enum.Parse<Gender>(values[3]);
        MobileNumber=long.Parse(values[4]);
        DOB=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
        Mail=values[6];
        Location=values[7];
        WalletBalance=double.Parse(values[8]);



    }
    }
}