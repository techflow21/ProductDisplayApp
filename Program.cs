namespace ProductDisplayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductMethods productMethods = new ProductMethods();

            productMethods.AddProduct(new Product { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 2300.5, Category = "PCs", OrderCount = 100 });
            productMethods.AddProduct(new Product { Id = 2, Name = "Ergonomic Chair", Quantity = 40, Price = 840, Category = "Chairs", OrderCount = 400 });
            productMethods.AddProduct(new Product { Id = 3, Name = "Table", Quantity = 10, Price = 290.65, Category = "Tables", OrderCount = 300 });

            string[] properties = productMethods.UserInputMethod().Replace(" ", "").Split(',');

            productMethods.ListProducts(properties);
        }
    }
}