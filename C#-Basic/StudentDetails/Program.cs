
using System;
namespace StudentDetails;
class Program
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("Enter the student name:");
            string name=Console.ReadLine();
            Console.WriteLine("enter the father name");
            string fatherName=Console.ReadLine();
            Console.WriteLine("ente the mail id");
            String mailId=Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("gender");
            string gender=Console.ReadLine();
            Console.WriteLine("enter your maths mark:");
            int maths=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your chemistry mark:");
            int chemistry=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your physics mark:");
            int physics=Convert.ToInt32(Console.ReadLine());
            float average=(float)(maths+chemistry+physics)/3;
            float sum =(float)(maths+chemistry+physics);
            float percentage=(float)((sum/600)*100);
            Console.WriteLine("your name is "+name);
            Console.WriteLine("your father name is "+ fatherName);
            Console.WriteLine("your mailId is "+mailId);
            Console.WriteLine("your age is "+age);
            Console.WriteLine("your chemistry mark is "+chemistry);
            Console.WriteLine("your physics mark is "+physics);
            Console.WriteLine("your maths mark is "+maths);
            Console.WriteLine("average of the mark "+average);
            Console.WriteLine("percentage " +percentage);
        }
    }

