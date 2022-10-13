using System;
using System.Collections;



namespace EmployeePayrollManagement
{
    public class Operation
    {
         public static List<EmployeeDetails> list=new List<EmployeeDetails>();
          static EmployeeDetails currentUser;
        public static void MainMenu()
        {   
           
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
             System.Console.WriteLine(" enter your employee details");
        System.Console.WriteLine("");
        System.Console.WriteLine(" Enter your name:");
        string name=Console.ReadLine();
       
        System.Console.WriteLine(" gender");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine(" enter your role:");
        string role=Console.ReadLine();
        System.Console.WriteLine(" enter your worklocation :");
        WorkLocation workLocation=Enum.Parse<WorkLocation>(Console.ReadLine(),true);
        System.Console.WriteLine(" enter your team name :");
        string team=Console.ReadLine();
        System.Console.WriteLine(" enter your date of joining (dd/mm/yyyy)");
        DateTime doj=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        EmployeeDetails employee=new EmployeeDetails(name,gender,workLocation,role,team,doj);
        
        list.Add(employee);
        System.Console.WriteLine(" Registration id "+employee.EmployeeId);
        }

        static void Login(){
            System.Console.WriteLine("Enter your id");
            string id=Console.ReadLine();
            foreach (EmployeeDetails  item in list)
            {
                if(id==item.EmployeeId){
                    System.Console.WriteLine("login successfull");
                    currentUser =item;
                    SubMenu();
                }
            }
        }

        public static void SubMenu(){
        string choice="yes";
        do{
        Console.WriteLine(" select option 1.ShoWdetails 2.Calculate salary 3.exit");
        int option=int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                currentUser.ShowDetails();
                
                break;
            case 2:
                currentUser.CalculateSalary();
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