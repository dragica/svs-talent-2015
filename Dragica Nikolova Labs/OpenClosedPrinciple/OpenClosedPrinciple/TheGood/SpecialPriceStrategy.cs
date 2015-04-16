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
    public class SpecialPriceStrategy : IPriceStrategy
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Identifier.StartsWith("Spec");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0m;
            total += item.Quantity * .3m;
            int setsOfFour = item.Quantity / 4;
            total -= setsOfFour * .15m;
            return total;
        }
    }
}
