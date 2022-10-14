using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food
{ 
    public delegate void Eventmanager();
    public static class Operation
    {
            static CustomerRegistration currentCustomer=null;
            public static List<CustomerRegistration> list=new List<CustomerRegistration>();
           public  static List<FoodDetails> list1=new List<FoodDetails>();
            public static List<OrderDetails> list2=new List<OrderDetails>();

           public  static List<BookingDetails> list3=new List<BookingDetails>();
            public static event Eventmanager eventlink=null;
            public static void Subscribe()
            {
                eventlink+=new Eventmanager(Files.Create);
                eventlink+=new Eventmanager(Files.ReadFiles);
                eventlink+=new Eventmanager(Operation.MainMenu);
                eventlink+=new Eventmanager(Files.WriteFiles);
            }
        public static void MainMenu()
        {
            
            string check="yes";
            do
            {
                System.Console.WriteLine("----Welcome to the site ----");
                System.Console.WriteLine(" please enter your option\n1.Customer Registration\n2.Customer Login\n3.Exit");
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
        }


        public static void Registration()
        {
               System.Console.WriteLine("Enter your details");
                System.Console.WriteLine("Enter your name:");
                string name=Console.ReadLine();

                System.Console.WriteLine("Enter your father name");
                string fatherName=Console.ReadLine();
                

                
                //System.Console.WriteLine("Enter your Mobile Number");
                //long phoneNumber=long.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter your Gender:");
                Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

                System.Console.WriteLine("Enter your mobile number");
                long mobileNumber=long.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter your date of birth");
                DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                

               System.Console.WriteLine("Enter the Email id");
               string mail=Console.ReadLine();
               
               System.Console.WriteLine("Enter your location ");
               string location=Console.ReadLine();

               System.Console.WriteLine("Enter the walletBalance");
               double walletBalance=double.Parse(Console.ReadLine());
               
            CustomerRegistration customer=new CustomerRegistration(name,fatherName,gender,mobileNumber,dob,mail,location,walletBalance);
            list.Add(customer);
        }

        public  static void Login()
        {
            System.Console.WriteLine("Enter your customer id");
            string customerId=Console.ReadLine();
            foreach (CustomerRegistration item in list)
            {
                if(customerId==item.RegistrationId)
                {
                    System.Console.WriteLine("Login successfull");
                    currentCustomer=item;
                    SubMenu();
                }
            }
        }

        static void SubMenu()
        {
            System.Console.WriteLine("Welcome to SubMenu");
            string choice="yes";
            do
            {
               System.Console.WriteLine("Choose the option\n1.Show food details\n2.Orderfood\n3.Cancel food\n4.Order historyr\n5.WalletRecharge\n6.Exit");
               int option=int.Parse(Console.ReadLine());
               switch(option)
               {
                case 1:
                {
                ShowFoodDetails();
                break;
                }
                case 2:
                {
                    OrderFood();
                    break;

                }
                case 3:
                {
                    //CancelFood();
                    break;
                }
                case 4:
                {
                   // OrderHistory();
                    break;
                }
                case 5:
                {
                   // WalletRecharge();
                    break;
                }
                
                case 6:
                {
                    System.Console.WriteLine("exit");
                    choice="no";
                    break;
                }

               }

            }while(choice=="yes");
        }


        static void ShowFoodDetails()
        {
            foreach (FoodDetails food in list1)
            {
                System.Console.WriteLine($"food Id is        {food.FoodId}");
                System.Console.WriteLine($"food name  is     {food.FoodName}");
                System.Console.WriteLine($"food per quantity {food.FoodCount}");
            }
        }


        static void OrderFood()
        {
            List<OrderDetails> tempOrderList=new List<OrderDetails>();
          BookingDetails tempBooking=new BookingDetails(currentCustomer.RegistrationId,0,DateTime.Now,BookingStatus.Initiated);
          string choice="yes";
          string check="yes";
          do{
          ShowFoodDetails();
          System.Console.WriteLine("Enter your Food Id ");
          string foodId=Console.ReadLine();
          foreach (FoodDetails item in list1)
        
          {
            if(foodId==item.FoodId)
            {
                System.Console.WriteLine("Enter the count of food");
                int count=int.Parse(Console.ReadLine());
                double price=item.FoodPerQuantity*count;
                OrderDetails tempOrder=new OrderDetails(tempBooking.BookingId,item.FoodId,count,price);
                tempOrderList.Add(tempOrder);
            }
          }
            System.Console.WriteLine("do you want to another item :yes/no ");
            choice=Console.ReadLine();
        

          }while(choice=="yes");
            double totalPrice=0;
          foreach (OrderDetails item in tempOrderList)
          {
            totalPrice =totalPrice+item.PriceOfOrder;
          }
        System.Console.WriteLine("do you sure purchase the current order list ");
        check=Console.ReadLine().ToLower();
        if(check=="yes")
        {
            while(true)
            {
                if(currentCustomer.WalletBalance>=totalPrice)
                {
                    currentCustomer.WalletBalance=currentCustomer.WalletBalance-totalPrice;
                    System.Console.WriteLine("food products booked");
                    BookingDetails originalBooking=new BookingDetails(currentCustomer.RegistrationId,totalPrice,DateTime.Now,BookingStatus.Booked);
                    list3.Add(originalBooking);
                    foreach (OrderDetails item in tempOrderList)
                    {
                        list2.Add(item);
                    }
                    break;
                }
                else
                {
                    currentCustomer.WalletRecharge();
                }
            }
        }
        else{
            System.Console.WriteLine("your cart detail are removed");
        }
        



        }
    
    
    
    
    
    }
}