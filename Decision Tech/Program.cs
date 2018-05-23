using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Tech
{
    class Program
    {
        public static void Main(string[] args)
        {
            Basket basket = new Basket();
            basket.AddToBasket(new Product("Bread", 1.00M), 1);
            basket.AddToBasket(new Product("Butter", 0.80M), 1);
            basket.AddToBasket(new Product("Milk", 1.15M), 1);
            Console.WriteLine(basket.Checkout().ToString("C"));
            Console.ReadKey();
        }
    }
}
