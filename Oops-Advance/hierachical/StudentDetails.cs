using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hierarchicalInhertance
{
    public enum Department{Default,EEE,CSE,ECE}
    public class StudentDetails:Personal
    {
        private static int s_studentId=1000;

        public string  StudentId { get; set; } 

        public Department Department { get; set; }

        public string Year { get; set; }

        public StudentDetails(string aid,string name,string fatherName,Gender gender,long phoneNumber,Department department,string year):base(aid,name,fatherName,gender,phoneNumber){
            s_studentId++;
            StudentId="SID"+s_studentId;
            Department=department;
            Year=year;
        }
        public void ShowStudent(){
            System.Console.WriteLine("student Id"+StudentId);
            ShowDetails();
            System.Console.WriteLine($"Department {Department}\nYear {Year}");
        }
    }
}