using System;
using System.Collections.Generic;

namespace EbBill
{
   
    public class Operation
    {
        static  List<UserDetails> list=new List<UserDetails>();
        static UserDetails currentUser=null;
        public static void MainMenu(){
               
            string choice="yes";
        do{
        Console.WriteLine(" select option 1.Registration 2.Login 3.exit");
        int option=int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                Registration();
                
                break;
            case 2:
                Login();
                break;
                
            case 3:
                Console.WriteLine(" Exit");
                choice="no";
                break;
        }
        }while(choice=="yes");
        }

        static void Registration(){
            System.Console.WriteLine(" enter your name:");
        string name=Console.ReadLine();
        System.Console.WriteLine(" enter your phone number:");
        long phone=long.Parse(Console.ReadLine());
        System.Console.WriteLine(" Enter your mail Id:");
        string mailId=Console.ReadLine();
        System.Console.WriteLine("Enter the unit to be consumed");
        double unit=double.Parse(Console.ReadLine());
        
        
        
        UserDetails user=new UserDetails(name,phone,mailId,unit);
       
        
        list.Add(user);
        System.Console.WriteLine(" your id is "+user.UserId);
        }

        static void Login(){
            System.Console.WriteLine("Enter your id");
            string id=Console.ReadLine();
            foreach (UserDetails  item in list)
            {
                if(id==item.UserId){
                    System.Console.WriteLine("login successfull");
                    currentUser =item;
                    SubMenu();
                }
            }

        }
        public static void SubMenu(){
        string choice="yes";
        do{
        Console.WriteLine(" select option 1.showdetails 2.calculateEB 3.exit");
        int option=int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                currentUser.ShowDetails();
                
                break;
            case 2:
                currentUser.CalculateEb();
                break;
                
            case 3:
                Console.WriteLine(" Exit");
                choice="no";
                break;
        }
        }while(choice=="yes");
        }
    }
}