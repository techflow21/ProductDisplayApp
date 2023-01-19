namespace ProductDisplayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AppStarter appStarter = new AppStarter();

            string[] properties = appStarter.UserInputMethod().ToLower().Replace(" ", "").Split(',');

            ProductMethods productMethods = new ProductMethods();
            productMethods.ListProducts(properties);
        }
    }
}