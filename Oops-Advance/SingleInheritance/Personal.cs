using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Gender{Male,Female}
    public class Personal
    {
        private static int aid=1000;

        public string AID { get; set; }

        public string Name { get; set; }

    public string FatherName { get; set; }

    public Gender Gender { get; set; }

    public long PhoneNumber { get; set; }

  public Personal(string name,string fatherName,Gender gender,long phoneNumber){

        aid++;
        AID="AID"+aid;
        Name=name;
        FatherName=fatherName;
        Gender=gender;
        PhoneNumber=phoneNumber;
    }
    public Personal(string aid,string name,string fatherName,Gender gender,long phoneNumber){

        
        AID=aid;
        Name=name;
        FatherName=fatherName;
        Gender=gender;
        PhoneNumber=phoneNumber;
    }

    public void ShowDetails(){
        System.Console.WriteLine($"personId is {AID}\nname is {Name}\nfathername is {FatherName}\nGender is {Gender}\nphone number is {PhoneNumber} ");
    }


    }
}