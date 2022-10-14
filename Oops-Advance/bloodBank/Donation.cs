using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public class Donation
    {
        private static int s_donationId=1000;

        public string DonationId { get; set; }   

        public string DonorId { get; set; }

        public DateTime Donationdate{ get; set; }

        public double BloodPressure { get; set; }
        public double Weight { get; set; }

        public double HemoglopinCount { get; set; }


       public  Donation(string donorId,DateTime donationDate,double bloodPressure,double weight,double hemoglopin)
       {
        DonationId="DOID"+(++s_donationId);
        DonorId=donorId;
        Donationdate=donationDate;
        BloodPressure=bloodPressure;
        Weight=weight;
        HemoglopinCount=hemoglopin;

       }

       public Donation(string item)
       {
            string[] values=item.Split(",");
            s_donationId=int.Parse(values[0].Remove(0,4));
            DonationId=values[0];
            DonorId=values[1];
            Donationdate=DateTime.ParseExact(values[2],"dd/MM/yyyy",null);
            BloodPressure=double.Parse(values[3]);
            Weight=double.Parse(values[4]);
            HemoglopinCount=double.Parse(values[5]);
       }
    }
}