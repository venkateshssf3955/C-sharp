using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food
{
    public class FoodDetails
    {
        private static int s_foodId=100;
        public string FoodId { get; set; }
        public string  FoodName { get; set; }

        public int FoodCount { get; set; }

        public double FoodPerQuantity { get; set; }


        public FoodDetails(string foodName,int foodCount,double foodPerQuantity)
        {
            s_foodId++;
            FoodId="FID"+s_foodId;
            FoodName=foodName;
            FoodCount=foodCount;
            FoodPerQuantity=foodPerQuantity;
        }


        public FoodDetails(string item)
        {
            string[] values=item.Split(",");
            s_foodId=int.Parse(values[0].Remove(0,3));
            FoodId=values[0];
            FoodName=values[1];
            FoodCount=int.Parse(values[2]);
        }
    }
}