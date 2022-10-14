using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInhertance
{
    public enum Department{Default,EEE,CSE,ECE}
    public class StudentDetails:Personal,IMarkDetails
    {
        private static int s_studentId=1000;

        public string  StudentId { get; set; } 

        public Department Department { get; set; }

        public string Year { get; set; }

        public int Physics { get; set; }

        public int Chemistry { get; set; }

        public int Maths { get; set; }

        public int Total { get; set; }

        public double Average { get; set; }

        public StudentDetails(string aid,string name,string fatherName,Gender gender,long phoneNumber,Department department,string year):base(aid,name,fatherName,gender,phoneNumber){
            s_studentId++;
            StudentId="SID"+s_studentId;
            Department=department;
            Year=year;
        }

        public void GetMark(int physics,int chemistry,int maths){
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        public void Calculate(){
            Total=(Physics+Chemistry+Maths);
            Average=Total/3.0;
        }

        public void ShowMark(){
            System.Console.WriteLine($"Total is {Total}\naverage is {Average}");
        }
        public void ShowStudent(){
            System.Console.WriteLine("student Id"+StudentId);
            ShowDetails();
            System.Console.WriteLine($"Department {Department}\nYear {Year}");
        }
    }
}