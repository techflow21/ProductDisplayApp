using System.Dynamic;

namespace ProductDisplayApp
{
    internal class ProductMethods
    {
        private List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 2300.5, Category = "PCs", OrderCount = 100 },
            new Product { Id = 2, Name = "Ergonomic Chair", Quantity = 40, Price = 840, Category = "Chairs", OrderCount = 400 },
            new Product { Id = 3, Name = "Table", Quantity = 10, Price = 290.65, Category = "Tables", OrderCount = 300 }
        };

        public void ListProducts(string[] properties = null)
        {
            Console.WriteLine("\n  List of Products based on Properties entered\n  ============================================\n");

            foreach (Product product in products)
            {
                dynamic productProperty = new ExpandoObject();

                productProperty.Id = product.Id;
                productProperty.Name = product.Name;

                productProperty.Quantity = product.Quantity;
                productProperty.Price = product.Price;

                productProperty.Category = product.Category;
                productProperty.OrderCount = product.OrderCount;


                foreach (string property in properties)
                {
                    switch (property)
                    {
                        case "" and "" and "" and "" and "" and "":
                            Console.WriteLine($"  {productProperty.Id}, {productProperty.Name}, {productProperty.Quantity}, {productProperty.Price}, {productProperty.Category}, {productProperty.OrderCount}");
                            break;

                        case "id":
                            Console.Write($"  {productProperty.Id},");
                            break;

                        case "name":
                            Console.Write($"  {productProperty.Name},");
                            break;

                        case "quantity":
                            Console.Write($"  {productProperty.Quantity},");
                            break;

                        case "price":
                            Console.Write($"  ${productProperty.Price},");
                            break;

                        case "category":
                            Console.Write($"  {productProperty.Category},");
                            break;

                        case "ordercount":
                            Console.Write($"  {productProperty.OrderCount},");
                            break;

                        default:
                            Console.Clear();

                            Console.WriteLine("\n  Invalid Properties entered, try again!");
                            AppStarter appStarter = new AppStarter();

                            appStarter.UserInputMethod();
                            break;
                    }
                }

                Console.WriteLine("\n");
            }
        }
    }
}
