using System;
using System.Collections.Generic;

namespace EbBill
{
    public class UserDetails
    {
        static int userId=1000;
        public string Name { get; set; }
        
        public string Mail{ get; set; }

        public long Phone { get; set; }
        
        public string UserId { get; set; }

        public double UnitUsed{ get; set; }
        
        
    public UserDetails(string name,long phone,string mailId,double unit){
            userId++;
            UserId="EB"+userId;
            Name=name;
            Mail=mailId;
            Phone=phone;
            UnitUsed=unit;
        }
        public void CalculateEb(){
            System.Console.WriteLine(" Enter your unit consumed");
            double value=double.Parse(Console.ReadLine());
            if(value<100){
               System.Console.WriteLine(" free");
            }
            else if(value<200){
                System.Console.WriteLine(" your amount is "+(value*3));
            }
            else if(value<400){
                System.Console.WriteLine(" your amount is "+(value*5));
            }
            else if(value>=400){
                System.Console.WriteLine(" your amount is "+(value*6));
            }
        }
        public void ShowDetails(){
         System.Console.WriteLine($"user id is{UserId}\nname is :{Name}\nphone number is {Phone}\nmail id is{Mail}");
            System.Console.WriteLine($"unit used is {UnitUsed}\n");
        }
        
        
        
        
    }
}