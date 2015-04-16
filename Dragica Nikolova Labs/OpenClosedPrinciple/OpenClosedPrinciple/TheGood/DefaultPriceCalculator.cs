using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOpenClosedPrinciple.Model;

namespace TheOpenClosedPrinciple.TheGood
{
    /// <summary>
    /// Selects the correct strategy and calculates the price.
    /// </summary>
    public class DefaultPriceCalculator : IPriceCalculator
    {
        private readonly IEnumerable<IPriceStrategy> _priceStrategies;

        //Injecting strategies as an IEnumerable. This way it is up to the caller to specify which strategies this calculator should use.
        public DefaultPriceCalculator(IEnumerable<IPriceStrategy> priceStrategies)
        {
            _priceStrategies = priceStrategies;
        }

        //Selecting the suitable pricing strategy based on LINQ and the IsMatch implementations and call its associated CalculatePrice method.
        public decimal CalculatePrice(OrderItem item)
        {
            return _priceStrategies.First(r => r.IsMatch(item)).CalculatePrice(item);
        }
    }
}
