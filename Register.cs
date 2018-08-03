using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore1
{
    public class Register
    {
        int priceA = 30;
        int priceB = 50;
        int special = 4;

        public double calculateTotal(int totalA, int totalB)
        {
            double totalCost;
            totalCost = priceA * totalA + priceB * (totalB / (special + 1)) * special + priceB * (totalB % (special + 1));
            //totalCost = totalCost / 100;
            return totalCost;
        }
    }
}
