using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOpenClosedPrinciple.Model;

namespace TheOpenClosedPrinciple.TheGood
{
    public interface IPriceStrategy
    {
        bool IsMatch(OrderItem item);

        decimal CalculatePrice(OrderItem item);
    }
}
