using System;
using System.Collections.Generic;
namespace CollegeAdmission;
class Program{

    
    public static void Main(string[] args)
    { 
        List<StudentDetails> studentList=new List<StudentDetails>();
        string check;
        System.Console.WriteLine(" are you willing to join in this college : (yes/no)");
        check=Console.ReadLine().ToLower();
        
        while(check=="yes"){
    
        StudentDetails student1=new StudentDetails();
        System.Console.WriteLine(" student 1 details :");
        System.Console.WriteLine(" Enter your name :");
        student1.Name=Console.ReadLine();
        System.Console.WriteLine(" enter your father name :");
        student1.FatherName=Console.ReadLine();
        System.Console.WriteLine(" Enter your date of birth :");
        student1.DOB=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
        System.Console.WriteLine(" Enter your phone number :");
        student1.Phone=Convert.ToInt64(Console.ReadLine());
        System.Console.WriteLine(" Enter your mail id :");
        student1.Mail=Console.ReadLine();
        System.Console.WriteLine(" Enter your physics mark :");
        student1.Physics=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(" Enter your chemistry mark: ");
        student1.Chemistry=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(" Enter your maths mark :");
        student1.Math=Convert.ToInt32(Console.ReadLine());
        studentList.Add(student1);
        System.Console.WriteLine(" admitted");
         System.Console.WriteLine(" Are you willing to join in this college");
        check=Console.ReadLine().ToLower();
        }
        int i=1;
        foreach(StudentDetails student in studentList)
        {   
            System.Console.WriteLine($"student{i} details are :");
            System.Console.WriteLine($"Name is : {student.Name}\nFather name is : {student.FatherName}\ndate of birth is {student.DOB}\nphone number is {student.Phone}\nmail id is {student.Mail}\nphysics mark is {student.Physics}");
            System.Console.WriteLine($"chemistry mark is : {student.Name}\nmaths mark is: {student.Math}\n register number is {student.RegisterNumber}");      
            i++; 
        }
       
        
        System.Console.WriteLine(" student2 details :");// student2
         System.Console.WriteLine(" Enter your name :");
        string name=Console.ReadLine();
        System.Console.WriteLine(" enter your father name :");
        string fatherName=Console.ReadLine();
        System.Console.WriteLine(" Enter your date of birth :");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
        System.Console.WriteLine(" Enter your phone number :");
        long phone=long.Parse(Console.ReadLine());
        System.Console.WriteLine(" Enter your mail id :");
        string mail=Console.ReadLine();
        System.Console.WriteLine(" Enter your physics mark :");
        int physics=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(" Enter your chemistry mark: ");
        int chemistry=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(" Enter your maths mark :");
        int math=Convert.ToInt32(Console.ReadLine());
        StudentDetails student2=new StudentDetails(name,fatherName,dob,phone,mail,physics,chemistry,math);
        studentList.Add(student2);

         bool eligible=student2.CheckEligibility(75);
        if(eligible){
            System.Console.WriteLine("eligible");

        }
        else{
            System.Console.WriteLine(" not eligible");
        }
        
         

         /*StudentDetails student3=new StudentDetails();

        System.Console.WriteLine(" studnet 3 details ");
         System.Console.WriteLine(" Enter your name :");
        student3.Name=Console.ReadLine();
        System.Console.WriteLine(" enter your father name :");
        student3.FatherName=Console.ReadLine();
        System.Console.WriteLine(" Enter your date of birth :");
        student3.DOB=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
        System.Console.WriteLine(" Enter your phone number :");
        student3.Phone=Convert.ToInt64(Console.ReadLine());
        System.Console.WriteLine(" Enter your mail id :");
        student3.Mail=Console.ReadLine();
        System.Console.WriteLine(" Enter your physics mark :");
        student3.Physics=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(" Enter your chemistry mark: ");
        student3.Chemistry=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(" Enter your maths mark :");
        student3.Math=Convert.ToInt32(Console.ReadLine());
        studentList.Add(student3);
       

        /*System.Console.WriteLine(" \n \n");
        System.Console.WriteLine(" Student1 details are :");
        
        System.Console.WriteLine(" Your name is :"+student1.Name);
        System.Console.WriteLine(" Your father name is :"+student1.FatherName);
        System.Console.WriteLine(" Your date of birth is :"+student1.DOB);
        System.Console.WriteLine(" Your phone number is :"+student1.Phone);
        System.Console.WriteLine(" Your mail id is :"+student1.Mail);
        System.Console.WriteLine(" your physics mark is :"+student1.Physics);
        System.Console.WriteLine(" Your chemistry mark is :"+student1.Chemistry);
        System.Console.WriteLine(" Your maths is :"+student1.Math);

        

        System.Console.WriteLine(" \n \n");
        System.Console.WriteLine(" Student2 details are :");

        System.Console.WriteLine(" Your name is :"+student2.Name);
        System.Console.WriteLine(" Your father name is :"+student2.FatherName);
        System.Console.WriteLine(" Your date of birth is :"+student2.DOB);
        System.Console.WriteLine(" Your phone number is :"+student2.Phone);
        System.Console.WriteLine(" Your mail id is :"+student2.Mail);
        System.Console.WriteLine(" your physics mark is :"+student2.Physics);
        System.Console.WriteLine(" Your chemistry mark is :"+student2.Chemistry);
        System.Console.WriteLine(" Your maths is :"+student2.Math);

        System.Console.WriteLine(" \n \n");
        System.Console.WriteLine(" Student3 details are :");


        System.Console.WriteLine(" Your name is :"+student3.Name);
        System.Console.WriteLine(" Your father name is :"+student3.FatherName);
        System.Console.WriteLine(" Your date of birth is :"+student3.DOB);
        System.Console.WriteLine(" Your phone number is :"+student3.Phone);
        System.Console.WriteLine(" Your mail id is :"+student3.Mail);
        System.Console.WriteLine(" your physics mark is :"+student3.Physics);
        System.Console.WriteLine(" Your chemistry mark is :"+student3.Chemistry);
        System.Console.WriteLine(" Your maths is :"+student3.Math);*/



}}
