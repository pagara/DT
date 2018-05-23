namespace Decision_Tech
{
    public class Butter : ProductDetails
    {

    }

    public class Product
    {
        public ProductDetails Butter { get; set; }
        public ProductDetails Milk { get; set; }
        public ProductDetails Bread { get; set; }
    }
}
