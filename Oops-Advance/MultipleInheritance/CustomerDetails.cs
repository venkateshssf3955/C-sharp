using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInhertance
{
    public class CustomerDetails:Personal
    {
        private static int  s_customerId=1000;

        public string CustomerId { get; set; }

        public double Balance { get; set; }

        public CustomerDetails(string aid,string name,string fatherName,Gender gender,long phoneNumber):base(aid,name,fatherName,gender,phoneNumber){
            s_customerId++;
            CustomerId="CID"+s_customerId;

        }

        public void Recharge()
        {
            System.Console.WriteLine("Enter your amount to recharge");
            Balance+=double.Parse(Console.ReadLine());
        }
        public void ShowDetail()
        {
            System.Console.WriteLine("Customer Id "+CustomerId);
            ShowDetails();
            System.Console.WriteLine("Balance "+Balance);
        }
    }
}