using System;
using System.Collections.Generic;
namespace OnlineGrocery;
public static class Operation
{   
    public static List<CustomerDetails> customerList=new List<CustomerDetails>();
    public static List<ProductDetails> productList=new List<ProductDetails>();
    public static List<BookingDetails> bookingList=new List<BookingDetails>();
    public static List<OrderDetails> orderList=new List<OrderDetails>();
        
    static CustomerDetails currentCustomer;
    
public static void MainMenu()

    {
      //AddDefault();
      System.Console.WriteLine("-----Welcome-----");
      System.Console.WriteLine("online grocery");

    string option1="yes";

    do{
      System.Console.WriteLine("choose the option\n1.customer Registration\n2.customer Login\n3.Exit");
      int option=int.Parse(Console.ReadLine());
      switch(option)
      {
        case 1:
        {
            System.Console.WriteLine("Customer registration");
            CustomerRegistration();
            break;
        }
        case 2:
        {
            System.Console.WriteLine("Customer Login");
            CustomerLogin();
            break;
        }
        case 3:
        {
            System.Console.WriteLine("Exit");
             option1="no";
            break;
        }

      }
       // System.Console.WriteLine("Do you want to continue :");
       // option1=Console.ReadLine().ToLower(); 
        }while(option1=="yes");



    
      }
static void CustomerRegistration()
       {
        System.Console.WriteLine("Customer Registration called");
        System.Console.WriteLine("Enter your name :");
        string name=Console.ReadLine();

        System.Console.WriteLine("Enter your fathername");
        string fatherName=Console.ReadLine();

        System.Console.WriteLine("Enter your Gender");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        
        System.Console.WriteLine("Enter your mobile number:");
        long mobileNumber=long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter your Date of birth ");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("mail.id");
        string mail=Console.ReadLine();

        System.Console.WriteLine("Enter the walletBalance");
        double walletBalance=double.Parse(Console.ReadLine());
        CustomerDetails customer=new CustomerDetails(name,fatherName,gender,mobileNumber,dob,mail,walletBalance);
        customerList.Add(customer);
        System.Console.WriteLine("Customer id is "+customer.CustomerId);



       }
static void CustomerLogin()
        {
            System.Console.WriteLine("Enter your customer id");
            string id=Console.ReadLine().ToUpper();
            int flag=0;
            foreach (CustomerDetails customer in customerList)
            {
                if(id==customer.CustomerId)
                {
                    flag =1;
                    currentCustomer=customer;
                    System.Console.WriteLine("login successfull");
                    SubMenu();

                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("invalid User");
            }
            
        }

static void SubMenu()
        {
            System.Console.WriteLine("Welcome to SubMenu");
            string choice="yes";
            do
            {
               System.Console.WriteLine("Choose the option\n1.Show customer details\n2.show product details\n3.Walletrecharge\n4.Take order\n5.Modify order Quantity\n6.Calcel order\n7.Exit");
               int option=int.Parse(Console.ReadLine());
               switch(option)
               {
                case 1:
                {
                currentCustomer.ShowCustomerDetails();
                break;
                }
                case 2:
                {
                    ShowProductDetails();
                    break;

                }
                case 3:
                {
                    currentCustomer.WalletRecharge();
                    break;
                }
                case 4:
                {
                    TakeOrder();
                    break;
                }
                case 5:
                {
                   // ModifyOrderQuantity();
                    break;
                }
                case 6:
                  //  CancelOrder();
                    break;
                case 7:
                {
                   // System.Console.WriteLine("exit");
                    choice="no";
                    break;
                }

               }

            }while(choice=="yes");
        }

static void AddDefault()
        {
                  
        //Operation.MainMenu();
        //customer details data
        CustomerDetails customer=new CustomerDetails("ravi","ettaparajan",Gender.Male,9876543,new DateTime(1990,11,11),"ravi@123",10000);
        CustomerDetails customer2=new CustomerDetails("Baskaran","sethurajan",Gender.Male,876543342,new DateTime(1990,11,11),"baskaran@123",15000);
        customerList.Add(customer);
        customerList.Add(customer2);


    //product Details data

    ProductDetails product=new ProductDetails("Suger",20,40);
    ProductDetails product1=new ProductDetails("Rice",100,50);
    ProductDetails product2=new ProductDetails("milk",10,40);
    ProductDetails product3=new ProductDetails("Coffee",10,10);
    ProductDetails product4=new ProductDetails("Tea",10,10);
    ProductDetails product5=new ProductDetails("MasalaPowder",10,20);
    ProductDetails product6=new ProductDetails("Salt",10,10);
    ProductDetails product7=new ProductDetails("Turmeric Powder",10,25);
    ProductDetails product8= new ProductDetails("Chilli Powder",10,20);
    ProductDetails product9=new ProductDetails("Groundnut Oil",10,140);

    productList.Add(product);
     productList.Add(product1);
    productList.Add(product2);
    productList.Add(product3);
     productList.Add(product4);
      productList.Add(product5);
       productList.Add(product6);
     productList.Add(product7);
      productList.Add(product8);
       productList.Add(product9);
    
     


    //Booking Details data

    BookingDetails booking1=new BookingDetails("CID3001",220,new DateTime(2022,07,26),BookingStatus.Booked);
    BookingDetails booking2=new BookingDetails("CID3002",400,new DateTime(2022,07,26),BookingStatus.Booked);
    BookingDetails booking3=new BookingDetails("CID3001",280,new DateTime(2022,07,26),BookingStatus.Cancelled);
    BookingDetails booking4=new BookingDetails("CID3002",0,new DateTime(2022,07,26),BookingStatus.Initiated);
    bookingList.Add(booking1);
    bookingList.Add(booking2);
    bookingList.Add(booking3);
    bookingList.Add(booking4);
    


//order details data

 OrderDetails order1 =new OrderDetails("BID3001","PID101",2,80);
 OrderDetails order2 =new OrderDetails("BID3001","PID102",2,100);
 OrderDetails order3 =new OrderDetails("BID3001","PID103",1,40);
 OrderDetails order4 =new OrderDetails("BID3002","PID101",1,40);
 OrderDetails order5 =new OrderDetails("BID3002","PID102",4,200);
 OrderDetails order6 =new OrderDetails("BID3002","PID110",1,140);
 OrderDetails order7 =new OrderDetails("BID3002","PID109",1,20);
 OrderDetails order8 =new OrderDetails("BID3003","PID102",2,100);
 OrderDetails order9 =new OrderDetails("BID3003","PID108",4,100);
 OrderDetails order10 =new OrderDetails("BID3003","PID101",2,80);

orderList.Add(order1);
orderList.Add(order2);
orderList.Add(order3);
orderList.Add(order4);
orderList.Add(order5);
orderList.Add(order6);
orderList.Add(order7);
orderList.Add(order8);
orderList.Add(order9);

orderList.Add(order10);




}

static void ShowProductDetails()
{
foreach (ProductDetails product in productList)
{
    product.ShowProductDetails();
}
}
static void TakeOrder()
{
   //creating a booking object 
  
   //select a product and check for list
   //get the quantity and caompare for available
   //calculate the price 
   //take order & create the object
   
    BookingDetails booking=new BookingDetails(currentCustomer.CustomerId,0,DateTime.Now,BookingStatus.Initiated);
   
   List<OrderDetails> tempOrderList=new List<OrderDetails>(); 
   double totalPrice=0;
    //show product detail list
   string choice="yes";
   do{
   ShowProductDetails();
   
   System.Console.WriteLine(" Please enter the product Id ");
   
   string productId=Console.ReadLine();
   foreach (ProductDetails product in productList)
   {
     
      //select a product and check for list
    if(productId==product.ProductId)
    {
        System.Console.WriteLine("howmany products you want to buy");
        int productCount=int.Parse(Console.ReadLine());
        if(productCount<=product.QuantityAvailable)
        {   
            double price=product.PricePerQuantity*productCount;
            OrderDetails tempOrder=new OrderDetails(booking.BookingId,product.ProductId,productCount,price);
            tempOrderList.Add(tempOrder);
        }

    }
   }
   System.Console.WriteLine("do you want to continue:yes/no");
   choice=Console.ReadLine().ToLower();
   }while (choice=="yes");
   
   foreach (OrderDetails tempOrders in tempOrderList)
   {
    
    totalPrice=totalPrice+tempOrders.PriceOfOrder;
   }

   System.Console.WriteLine("are you sure to buy this orders:yes/no");
   string choice1=Console.ReadLine().ToLower();
   if(choice1=="yes")
   {
    while(true)
    {
        
        if(currentCustomer.WalletBalance<totalPrice)
        {
        System.Console.WriteLine("insufficient balance ---Please recharge---");
        currentCustomer.WalletRecharge();
        }
        else
        {  
            System.Console.WriteLine("Booked successfully");
            currentCustomer.WalletBalance=currentCustomer.WalletBalance-totalPrice;
            BookingDetails originalBooking=new BookingDetails(currentCustomer.CustomerId,totalPrice,DateTime.Now,BookingStatus.Booked);
            bookingList.Add(originalBooking);
            break;

        }

   }
   }
   else{
        System.Console.WriteLine("cart removed successfully");
   }
}





}
