using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public enum Blood{Default,A_positive,B_positive,O_positive,AB_positive}
    public class UserDetails
    {
        private static int s_donorId=1000;

        public string DonorId { get; set; }

        public string DonorName { get; set; }

        public long MobileNumber { get; set; }

        public  Blood BloodGroup { get; set; }

        public int Age{get;set;}

        public DateTime LastDonationDate { get; set; }


        public  UserDetails(string name, long phoneNumber, Blood bloodGroup, int age, DateTime lastDate)
        {
        s_donorId++;
        DonorId="DID"+s_donorId;
        DonorName=name;
        MobileNumber=phoneNumber;
        BloodGroup=bloodGroup;
        Age=age;
        LastDonationDate=lastDate;

        }

        public UserDetails(string item)
        {
            string[] values=item.Split(",");
            s_donorId=int.Parse(values[0].Remove(0,3));
            DonorId=values[0];
            DonorName=values[1];
            MobileNumber=long.Parse(values[2]);
            BloodGroup=Enum.Parse<Blood>(values[3],true);
            Age=int.Parse(values[4]);
            LastDonationDate=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
        }

    }
}