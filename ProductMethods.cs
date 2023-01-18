namespace ProductDisplayApp
{
    internal class ProductMethods
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ListProducts(string[] properties = null)
        {
            Console.WriteLine("\n  List of Products based on Properties entered\n  ============================================\n");

            foreach (Product product in products)
            {
                foreach (string prop in properties)
                {
                    switch (prop)
                    {
                        case "" and "" and "" and "" and "" and "":
                            Console.WriteLine($"  {product.Id}, {product.Name}, {product.Quantity}, {product.Price}, {product.Category}, {product.OrderCount}");
                            break;

                        case "Id":
                            Console.Write($"  {product.Id},");
                            break;

                        case "Name":
                            Console.Write($"  {product.Name},");
                            break;

                        case "Quantity":
                            Console.Write($"  {product.Quantity},");
                            break;

                        case "Price":
                            Console.Write($"  ${product.Price},");
                            break;

                        case "Category":
                            Console.Write($"  {product.Category},");
                            break;

                        case "OrderCount":
                            Console.Write($"  {product.OrderCount},");
                            break;

                        default:
                            Console.Clear();

                            Console.WriteLine("\n  Invalid Properties entered,try again!");
                            UserInputMethod();
                            break;
                    }
                }
                Console.WriteLine("\n");

            }
        }


        public string UserInputMethod()
        {
            Console.Write("\n  Enter properties to display (Use comma to seperate if many properties): \n\n  ");

            string input = Console.ReadLine();

            /*string output = "";

            input = input.Replace(" ", "").ToLower();

            string[] words = input.Split(',');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                output += words[i] + " ";
            }
            return output;
             */

            return input;
        }
    }
}
