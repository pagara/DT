namespace Decision_Tech
{
    public class ProductDetails : IProduct
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public ProductDetails(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}