using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace BloodBank
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("BloodBank"))
            {
                Directory.CreateDirectory("BloodBank");
            }
            if(!File.Exists("BloodBank/UserDetails.csv"))
            {
                File.Create("BloodBank/UserDetails.csv");
            }
            if(!File.Exists("BloodBank/Donation.csv"))
            {
                File.Create("BloodBank/Donation.csv");
            }
        }
        public static void ReadFiles()
        {
            string[] array=File.ReadAllLines("BloodBank/UserDetails.csv");
            foreach (string item in array)
            {
                UserDetails user=new UserDetails(item);
                Operation.list.Add(user);
            }
            string[] array2=File.ReadAllLines("BloodBank/Donation.csv");
            foreach (string item in array2)
            {
                Donation donate=new Donation(item);
                Operation.list1.Add(donate);
            }
                
    
        }

        public static void WriteFiles()
        {
            string[] userDetails=new string[Operation.list.Count];
            for (var i = 0; i < Operation.list.Count; i++)
            {
                userDetails[i]=Operation.list[i].DonorId+","+Operation.list[i].DonorName+","+Operation.list[i].MobileNumber+","+Operation.list[i].BloodGroup+","+Operation.list[i].Age+","+Operation.list[i].LastDonationDate.ToString("dd/MM/yyyy");
            }
            File.WriteAllLines("BloodBank/UserDetails.csv",userDetails);

            string[] donationDetails=new string[Operation.list1.Count];
            for (var i = 0; i < Operation.list1.Count; i++)
            {
                donationDetails[i]=Operation.list1[i].DonationId+","+Operation.list1[i].DonorId+","+Operation.list1[i].Donationdate.ToString("dd/MM/yyyy")+","+Operation.list1[i].BloodPressure+","+Operation.list1[i].Weight+","+Operation.list1[i].HemoglopinCount;
            }

            File.WriteAllLines("BloodBank/Donation.csv",donationDetails);
        }






    }
}