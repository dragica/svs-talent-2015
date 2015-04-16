using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOpenClosedPrinciple.Model;

namespace TheOpenClosedPrinciple.TheGood
{
    /// <summary>
    /// Translate the if-else statements into concrete pricing strategies,
    /// now they are encapsulated within seperate classes.
    /// </summary>
    public class BuyThreeGetOneFree : IPriceStrategy
    {
        public bool IsMatch(OrderItem item)
        {
        return item.Identifier.StartsWith("Buy3OneFree");
        }
 
        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0m;
            total += item.Quantity * 1m;
            int setsOfThree = item.Quantity / 3;
            total -= setsOfThree * 1m;
            return total;
        }
    }    
}
