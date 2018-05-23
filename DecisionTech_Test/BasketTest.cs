using Decision_Tech;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTech_Test
{
    public class BasketTest
    {
        private Basket _basket;

        [SetUp]
        public void SetUp()
        {
            _basket = new Basket();
        }

        [Test]
        public void GivenEmptyBasket_IAddTwoButters_SHouldReturn160GBP()
        {

        }
    }
}
