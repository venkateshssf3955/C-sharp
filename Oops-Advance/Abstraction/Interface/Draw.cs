using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Draw:IRectangle
    {
        public int Area { get; set; }    ///fully abstraction

        public int Length { get; set; }

        public int Breadth { get; set; }

        public void  CalculateArea(){
            Area=Length*Breadth;
            System.Console.WriteLine(Area);
        }
    }
}