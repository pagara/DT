namespace Decision_Tech
{
    //public class Butter : ProductDetails
    //{
    //    //base should be base(name, cost) and another class should deal with assigning name and prices and other properties that might be necessary, 
    //    //but for sake of simplicity they will be hardcoded
    //    public Butter(string name, decimal cost) : base(name, cost) { }
    //}

    public class Product : ProductDetails
    {
        public Product(string name, decimal cost) : base(name, cost) { }
    }
    //public class Product
    //{
    //    public ProductDetails Butter { get; set; }
    //    public ProductDetails Milk { get; set; }
    //    public ProductDetails Bread { get; set; }
    //}
}
