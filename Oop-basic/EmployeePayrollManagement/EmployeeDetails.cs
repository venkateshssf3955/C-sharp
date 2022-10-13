using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayrollManagement
{
    public enum Gender{Default,Male,Female,TransGender}
    public enum WorkLocation{Default,Mathura,Eymard
    }
    public class EmployeeDetails
    {   
        public static int s_employeeId=1000;
         public string EmployeeId { get; set; }
        public string Name { get; set; }

        public Gender Gender1{ get; set; }

        public WorkLocation Worklocation1 { get; set; }
        
        public string Role{ get; set; }
        public string Team { get; set; }
        public DateTime DOJ { get; set; }

        public double Salary { get; set; }
        
        
        
        
        
        
        public EmployeeDetails(string name,Gender gender,WorkLocation worklocation,string role,string team,DateTime doj){
            s_employeeId++;
            EmployeeId="SF"+s_employeeId;
            Name=name;
            Gender1=gender;
            Worklocation1=worklocation;
            Role=role;
            Team=team;
            DOJ=doj;

        }

        public EmployeeDetails(string data)
        {
            string[] values=data.Split(',');
            s_employeeId=int.Parse(values[0].Remove(0,2));
            EmployeeId=values[0];
            Name=values[1];
            Gender1=Enum.Parse<Gender>(values[2],true);
            Worklocation1=Enum.Parse<WorkLocation>(values[3],true);
            Role=values[4];
            Team=values[5];
            DOJ=DateTime.ParseExact(values[6],"dd/MM/yyyy",null);
        }

        
        
        
        
        public void CalculateSalary(){
            System.Console.WriteLine("enter the no fo working days");
            double value=double.Parse(Console.ReadLine());
            double Salary=value*500;
            System.Console.WriteLine("your salary is "+Salary);
            
        }
        
        
         public void ShowDetails(){
    
        System.Console.WriteLine($"employee id is {EmployeeId}\n employee name {Name}\n gender is:{Gender1}");
        System.Console.WriteLine($"worklocation is: {Worklocation1}\nrole is :{Role}\n team :.{Team}\n salary is{Salary}");
   
   
    
    }
        
        
        
        
    }
}