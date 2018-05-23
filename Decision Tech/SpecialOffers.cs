using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Tech
{
    public class SpecialOffers
    {
        private IList<Product> _products;

        public SpecialOffers()
        {
            _products = new List<Product>();
        }

        public IList<Product> MilkOffer
        {
            get
            {
                if(_products.Select(x => x.Milk).Count() % 3 != 0)
                {
                    return _products
                }
            }
        }
    }
}
