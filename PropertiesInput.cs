
namespace ProductDisplayApp
{
    internal class PropertiesInput
    {
        bool validInput = false;
        public void UserInput()
        {
            string[] properties;
            
            while (!validInput)
            {
                try
                {
                    Console.Write("\n  Enter the properties to display,Comma seperated! (e.g id, name): \n  ");

                    properties = Console.ReadLine().ToLower().Replace(" ", "").Split(',');

                    ProductMethods.ListProducts(properties);

                    validInput = true;
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("\n  Invalid properties entered, try again!");
                }
            }
            Console.Write("\n  Do you want to try again? (y/n)\n  ");
            var response = Console.ReadLine().ToLower();
            
            if (response == "y")
            {
                validInput = false;
                UserInput();
            }
        }
    }
}
