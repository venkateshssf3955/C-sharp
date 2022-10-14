using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class UserDetails:PersonalDetails,IWallet
    {
        private static int s_userId=1000;
        public string UserId { get; }
        public double  WalletBalance { get; set; }


        public UserDetails(string name,int age,long phoneNumber,double walletBalance):base(name,age,phoneNumber)
        {
            s_userId++;
            UserId="UID"+s_userId;
            WalletBalance=walletBalance;
        }

        public void RechargeWallet()
        {
            System.Console.WriteLine(" enter your amount for deposit");
            double amount=double.Parse(Console.ReadLine());
            WalletBalance=WalletBalance+amount;
        }


        public UserDetails(string data)
        {
          string[] values=data.Split(",");
          s_userId=int.Parse(values[0].Remove(0,3));
          UserId=values[0];
          Name=values[1];
          Age=int.Parse(values[2]);
          PhoneNumber=long.Parse(values[3]);
          WalletBalance=double.Parse(values[4]);
        }
    }
}