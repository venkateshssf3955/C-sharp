using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food
{   public enum Gender{Default,Male,Female,Transgender}
    public class PersonalDetails
    {
        public string Name{ get; set; }

        public string  FatherName { get; set; }

        public Gender Gender{ get; set; }

        public long MobileNumber { get; set; }

        public DateTime DOB { get; set; }
        public string Mail { get; set; }

        public string Location { get; set; }

        public PersonalDetails(string name,string fatherName,Gender gender,long mobileNumber,DateTime dob,string mail,string location)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
            DOB=dob;
            Mail=mail;
            Location=location;
        }
        public PersonalDetails()
        {
            
        }

    }
}