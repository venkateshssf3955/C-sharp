using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentDetails
    {
        public StudentDetails(string name,string fatherName,DateTime dob,Gender gender,string mail,long phone,int physics,int chemistry,int math){
           _registerNumber++;
            RegisterNumber="SF"+_registerNumber;
           
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Phone=phone;
            Mail=mail;
            Physics=physics;
            Chemistry=chemistry;
            Math=math;
            Gender=gender;
        }
        public StudentDetails(){     //default contructor
            Name="Your name";
            FatherName=" Your father name";
        }
    }
}