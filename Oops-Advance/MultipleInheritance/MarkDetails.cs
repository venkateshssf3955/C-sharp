using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInhertance
{
    public interface IMarkDetails
    {
         int Physics { get; set; }

         int Chemistry{ get; set; }

         int Maths{get; set;}

         int Total{get;set;}

         double Average{get;set;}

         void Calculate();

         void GetMark(int physics,int chemistry,int maths);

         void ShowMark();
    }

}