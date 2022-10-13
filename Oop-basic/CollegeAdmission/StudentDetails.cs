using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class StudentDetails
    {   
         // private string _name; //field declaration
        //public string Name { get{return _name;} set{_name=value; }}
        private static int _registerNumber=3000;

        public string RegisterNumber { get; }
        
        
        public string Name { get; set; }// auto property
        
        public string FatherName { get; set; }
        
        public DateTime DOB { get; set; }
        
        public string Gender { get; set; }
        
        public string Mail { get; set; }
        
        public long Phone { get; set; }
        
        public int Physics{ get; set; }
        
        public int Chemistry{ get; set; }
        
        public int Math { get; set; }
        
        public StudentDetails(){     //default contructor
            Name="Your name";
            FatherName=" Your father name";
        }
        public StudentDetails(string name,string fatherName,DateTime dob,long phone,string mail,int physics,int chemistry,int maths){
            _registerNumber++;
            RegisterNumber="SF"+_registerNumber;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Phone=phone;
            Mail=mail;
            Physics=physics;
            Chemistry=chemistry;
            Math=maths;
        }
        /*~StudentDetails{                  //destructor declaration

        }*/
        public bool CheckEligibility(double cutOff){
            double average=(double)(Physics+Chemistry+Math)/3.0;
            if(average>=cutOff){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
