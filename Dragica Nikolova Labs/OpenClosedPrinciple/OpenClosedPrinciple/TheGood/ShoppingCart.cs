using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOpenClosedPrinciple.Model;

namespace TheOpenClosedPrinciple.TheGood
{
    public class ShoppingCart
    {
        private readonly List<OrderItem> _orderItems;
        private readonly IPriceCalculator _priceCalculator;

        public ShoppingCart(IPriceCalculator priceCalculator)
        {
            _priceCalculator = priceCalculator;
            _orderItems = new List<OrderItem>();
        }
 
        public IEnumerable<OrderItem> OrderItems
        {
            get { return _orderItems; }
        }
 
        public void Add(OrderItem orderItem)
        {
            _orderItems.Add(orderItem);
        }

        /*The ShoppingCart is no longer responsible for the actual price calculation. 
        This responsibility is delegated to the DefaultPriceCalculator which selects the right strategy to calculate the price.*/
        public decimal TotalAmount()
        {
            decimal total = 0m;
            foreach (OrderItem orderItem in OrderItems)
            {
                total += _priceCalculator.CalculatePrice(orderItem);
            }
            return total;
        }
    }
}
