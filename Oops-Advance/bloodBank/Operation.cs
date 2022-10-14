using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public static class Operation
    {   
        static  UserDetails currentUser=null;
        public static List<UserDetails> list=new List<UserDetails>();

        public static List<Donation> list1=new List<Donation>();


        public static void MainMenu()
        {

            string check="yes";
            do
            {
                System.Console.WriteLine("----Welcome to the site ----");
                System.Console.WriteLine(" please enter your option\n1.Registration\n2.Login\n3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Registration();
                        break;
                    case 2:
                        Login();
                        break;
                    case 3:
                        check="no";
                        break;




                }
            }while(check=="yes");



            static  void Registration()
            {
                System.Console.WriteLine("Enter your details");
                System.Console.WriteLine("Enter your name:");
                string name=Console.ReadLine();
                
                System.Console.WriteLine("Enter your Mobile Number");
                long phoneNumber=long.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter your Blood Group:");
                Blood bloodGroup=Enum.Parse<Blood>(Console.ReadLine(),true);

                System.Console.WriteLine(" Enter your age:");
                int age=int.Parse(Console.ReadLine());

                System.Console.WriteLine("Last donation date dd/MM/YYYY ");
                DateTime lastDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

                UserDetails user=new UserDetails(name,phoneNumber,bloodGroup,age,lastDate);


                System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                System.Console.WriteLine(" your id is "+user.DonorId);
                System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                list.Add(user);



            }

            static  void Login()
            {
                System.Console.WriteLine(" Enter your Donor id ");
                string donorId=Console.ReadLine();
                foreach (UserDetails item in list)
                {
                    if(donorId==item.DonorId)
                    {
                        System.Console.WriteLine(" Login successfull");
                        currentUser=item;
                        SubMenu();
                    }
                }
            }

            static  void SubMenu()
            {
                string check="yes";
            do
            {
                System.Console.WriteLine("----Welcome to the site ----");
                System.Console.WriteLine(" please enter your option\n1.Donote blood\n2.Donation history\n3.Next Eligible\n4.exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        DonateBlood();
                        break;
                    case 2:
                        DonationHistory();
                        break;

                    case 3:
                        NextEligibleDate();
                        break;
                    case 4:
                        check="no";
                        break;




                }
            }while(check=="yes");
            }

            static void DonateBlood()
            {
                System.Console.WriteLine("Enter your donor id");
                string donorId=Console.ReadLine();
                DateTime donationDate=DateTime.Now;
                System.Console.WriteLine("Enter your weight");
                double weight=double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your blood pressure level");
                double bloodPressure=double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the hemoglopin level ");
                double hemoglopin=double.Parse(Console.ReadLine());
                if(weight>50)
                {
                    if(bloodPressure<130)
                    {
                        if(hemoglopin>13)
                        {
                            Donation donate=new Donation(donorId,donationDate,bloodPressure,weight,hemoglopin);
                            list1.Add(donate);
                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            System.Console.WriteLine("Your donation id is "+donate.DonationId);
                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        }
                        else{
                            System.Console.WriteLine("your not eligible for doantion because of low hemoglopin");
                        }
                    }
                    else{
                        System.Console.WriteLine(" high blood pressure not eligible ");
                    }

                }
                
                 }
                static void DonationHistory()
                {
                    foreach (Donation  item in list1)
                    {
                        if(currentUser.DonorId==item.DonorId)
                        {
                            System.Console.WriteLine("~~~~~~~~~~~~~~~~");
                            System.Console.WriteLine($"Donor id is {item.DonorId}\ndonation id {item.DonationId}\ndonation date is {item.Donationdate}\nweight is {item.Weight}\nblood pressure is {item.BloodPressure}\n");
                        }
                    }
                }

                static void NextEligibleDate()
                {
                    foreach (Donation item in list1)
                
                    {
                        if(currentUser.DonorId==item.DonorId)
                        {
                            DateTime nextDate=item.Donationdate.AddDays(60);
                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            System.Console.WriteLine("next eligibility date is "+nextDate);
                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        }
                        
                    }
                }
                

                













        } 
    }
}