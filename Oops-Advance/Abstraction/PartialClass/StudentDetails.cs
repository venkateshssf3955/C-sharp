using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
     public enum Gender{Default,Male,Female}
    public partial class StudentDetails
    {
       
     // private string _name; //field declaration
        //public string Name { get{return _name;} set{_name=value; }}
    
        /// </summary>
        private static int _registerNumber=3000;
        /// <summary>
        /// P9roperty identify the student register <see cref="RegisterNumber"/>
        /// </summary>
        /// <value></value>
        public string RegisterNumber { get;} 
        
        
        /// <summary>
        /// Identify the name<see cref="Name"/>
        /// </summary>
        /// <value></value>
        public string Name { get; set; }// auto property
        /// <summary>
        /// Student's father name
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        
        /// <summary>
        /// Student's date of birth
        /// </summary>
        /// <value></value>
        public DateTime DOB { get; set; }
        /// <summary>
        /// Student gender detail
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }
        
        /// <summary>
        /// Student mail
        /// </summary>
        /// <value></value>
        public string Mail { get; set; }
        /// <summary>
        /// Student Phone number
        /// </summary>
        /// <value></value>
        public long Phone { get; set; }
        /// <summary>
        /// Student physics mark
        /// </summary>
        /// <value></value>
        public int Physics{ get; set; }
        /// <summary>
        /// student chemistry mark
        /// </summary>
        /// <value></value>
        public int Chemistry{ get; set; }
        /// <summary>
        /// Student maths mark
        /// </summary>
        /// <value></value>
        public int Math { get; set; }
        
        
        /// <summary>
        /// <see cref="Studentdetails"/> used to initialize the values to its property
        /// </summary>
        /// <param name="name">parameter name used to initialize a student's Name to Name property</param>
        /// <param name="fatherName">Prameter fatherName is used to initialize value to a student's FatherName</param>
        /// <param name="dob">Prameter dob is used to initialize value to a student's Date of birth</param>
        /// <param name="phone">
        /// Prameter phone is used to initialize value to a student's phone number</param>
        /// <param name="mail">Prameter mail is used to initialize value to a student's mail</param>
        /// <param name="physics">Prameter physics is used to initialize value to a student's physics mark</param>
        /// <param name="chemistry">Prameter chemistry is used to initialize value to a student's chemistry mark</param>
        /// <param name="math">Prameter maths is used to initialize value to a student's maths mark</param>
        
    }
}