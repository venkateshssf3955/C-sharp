using System;
namespace hierarchicalInhertance;
class Program{


    public static void Main(string[] args)
    {
        System.Console.WriteLine(" personal details");
        System.Console.WriteLine(" Enetr your name:");
        string name=Console.ReadLine();
        
        System.Console.WriteLine(" Enter your father name");
        string fatherName=Console.ReadLine();
        
        System.Console.WriteLine(" Enter your gender");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

        System.Console.WriteLine(" Enter your phone number ");
        long phoneNumber=long.Parse(Console.ReadLine());

        Personal person=new Personal(name,fatherName,gender,phoneNumber);
        person.ShowDetails();

        StudentDetails student=new StudentDetails("1234","venkatesh","sankar",Gender.Male,987654321,Department.CSE,"2year");
        student.ShowStudent();

        CustomerDetails customer=new CustomerDetails("1234","venkatesh","sankar",Gender.Male,98765432);
        customer.Recharge();
        customer.ShowDetail();
        
        
    }
}