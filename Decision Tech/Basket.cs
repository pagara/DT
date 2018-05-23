using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Tech
{
    public class Basket
    {
        IDictionary<IProduct, int> Products { get; set; }

        public Basket()
        {
            Products = new Dictionary<IProduct, int>();
        }

        public void AddToBasket(IProduct product, int amount)
        {
            Products.Add(product, amount);
        }

        public decimal Checkout()
        {
            decimal totalCost = 0;
            foreach(var product in Products)
            {
                totalCost += product.Key.Cost * product.Value;
            }
            return totalCost;
        }
    }
}
