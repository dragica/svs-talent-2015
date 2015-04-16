using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOpenClosedPrinciple.Model;

namespace TheOpenClosedPrinciple.TheGood
{
    public interface IPriceCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}
