using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace EmployeePayrollManagement
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Employment"))
            {   

                Directory.CreateDirectory("Employment");
            }
            if(!File.Exists("Employment/EmployeeDetails.csv"))
            {
                File.Create("Employment/EmployeeDetails.csv");
            }
        }
        public static void ReadFiles()
        {
            string[] employees=File.ReadAllLines("Employment/EmployeeDetails.csv");

            foreach (string data in employees)
            {
                EmployeeDetails employee=new EmployeeDetails(data);
                Operation.list.Add(employee);
            }
        }

        public static void WriteFiles()
        {
            string[] employeeDetails=new string[Operation.list.Count];
            for (int i = 0; i < Operation.list.Count; i++)
            {
                employeeDetails[i]=Operation.list[i].EmployeeId+","+Operation.list[i].Name+","+Operation.list[i].Gender1+","+Operation.list[i].Worklocation1+","+Operation.list[i].Role+","+Operation.list[i].Team+","+Operation.list[i].DOJ.ToString("dd/MM/yyyy");
            }
            File.WriteAllLines("Employment/EmployeeDetails.csv",employeeDetails);
        }
    }
}