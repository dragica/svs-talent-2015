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
    public class PricePerUnitStrategy : IPriceStrategy
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Identifier.StartsWith("Each");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quantity * 4m;
        }
    }
}
