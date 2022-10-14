using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class PersonalDetails
    {   
        /// <summary>
        /// username
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// user age
        /// </summary>
        /// <value></value>

        public int Age{ get; set; }

        public long PhoneNumber { get; set; }

        public PersonalDetails()
        {

        }


        public PersonalDetails(string name,int age,long phoneNumber)
        {
            Name=name;
            Age=age;
            PhoneNumber=phoneNumber;
        }
    }
}