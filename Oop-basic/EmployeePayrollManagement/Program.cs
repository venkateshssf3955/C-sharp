using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EmployeePayrollManagement;
class Program{
     public static void Main(string[] args)
    {   

        Files.Create();
        Files.ReadFiles();
        Operation.MainMenu();
        Files.WriteFiles();
    }
    
        
       
   
}

