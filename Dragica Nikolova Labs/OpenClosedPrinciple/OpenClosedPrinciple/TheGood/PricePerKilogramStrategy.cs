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
    public class PricePerKilogramStrategy : IPriceStrategy
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Identifier.StartsWith("Weight");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quantity * 3m / 1000;
        }
    }
}
